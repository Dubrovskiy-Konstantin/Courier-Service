using ClientApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text;
using System.Net.Mail;
using System.Net;
using ClientApp.Services;
using System.Globalization;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Cors;

namespace ClientApp.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private UserOrder _order;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [EnableCors("SiteCorsPolicy")]
        public IActionResult Index(string? paymentId, string? payerId)
        {
            return View();
        }

        [EnableCors("SiteCorsPolicy")]
        [HttpPost]
        public IActionResult PayBill(UserOrder order)
        {
            //return Redirect(@"https://metanit.com/sharp/mvc5/4.1.php");

            try
            {
                var redirectUrl = @"https://" + Request.Host.Value + "/Home/Success"; // успешная оплата
                var paymentPayPal = PayPalPaymentService.CreatePayment(redirectUrl, double.Parse(order.Cost, CultureInfo.InvariantCulture));

                var url = paymentPayPal.GetApprovalUrl();

                _order = order;
                return Redirect(url);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Success(string paymentId, string payerId)
        {
            if (!string.IsNullOrEmpty(paymentId) && !string.IsNullOrEmpty(payerId))
            {
                try
                {
                    var payment = PayPalPaymentService.ExecutePayment(paymentId, payerId);
                }
                catch 
                {
                    return View("Exeption during PayPal payment");
                }
                _order.Payed = "true";
                InsertInDB(_order);

                return View("Success payment");
            }

            return View("Invalid Payer and Payment id");
        }

        [HttpPost]
        public IActionResult Create(UserOrder order)
        {
            InsertInDB(order);
            return View();
        }

        public void InsertInDB(UserOrder order)
        {
            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourierService;Integrated Security=True";
            string connectionString = "Data Source=mssql-99901-0.cloudclusters.net,10105;" +
                  "Initial Catalog=CourierService;" +
                  "User id=Site;" +
                  "Password=123QWErty;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "BEGIN TRANSACTION;";
                command.ExecuteNonQuery();
                try
                {
                    //Адреса
                    command.CommandText = "INSERT INTO [dbo].[Addresses](X, Y, [Address]) VALUES " +
                        $"({order.PointFrom.X}, {order.PointFrom.Y}, N'{order.PointFrom.Text}'), " +
                        $"({order.PointTo.X}, {order.PointTo.Y}, N'{order.PointTo.Text}');";

                    command.ExecuteNonQuery();
                    command.CommandText = "select ident_current('[dbo].[Addresses]')";
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    int idPointTo = Convert.ToInt32(reader.GetValue(0));
                    int idPointFrom = idPointTo - 1;
                    reader.Close();

                    //Заказ
                    string CheckEmail(string email) => string.IsNullOrWhiteSpace(email) ? "null" : $"'{email}'";
                    int CheckBool(string boolvalue) => Convert.ToInt32(Convert.ToBoolean(boolvalue));
                    command.CommandText = "INSERT INTO [dbo].[Orders](Total_Distance, Cost, Payed, [Status], Client_Name, Client_Phone, " +
                        "Client_Email, Expected_Num_Of_Movers, Id_Point_From, Id_Point_To, Time_From, Time_To, [Date]) VALUES " +
                        $"({order.Distance}, {order.Cost}, {CheckBool(order.Payed)}, {1}, N'{order.Name}', '{order.Phone}', {CheckEmail(order.Email)}, {order.Movers}, {idPointFrom}, {idPointTo}, '{order.TimeFrom}', '{order.TimeTo}', '{order.Date}');";

                    command.ExecuteNonQuery();
                    command.CommandText = "select ident_current('[dbo].[Orders]')";
                    reader = command.ExecuteReader();
                    reader.Read();
                    int idOrder = Convert.ToInt32(reader.GetValue(0));
                    reader.Close();

                    //Детали
                    StringBuilder cmd = new StringBuilder("INSERT INTO [dbo].[Details](Id_Order, Unit, Unit_Description, Unit_Amount) VALUES");
                    foreach (Item item in order.Items)
                    {
                        cmd.Append($" ({idOrder}, N'{item.Name}', N'{item.Description}', {item.Count}),");
                    }
                    cmd[^1] = ';';
                    command.CommandText = cmd.ToString();
                    command.ExecuteNonQuery();
                    command.CommandText = "COMMIT;";
                    command.ExecuteNonQuery();

                    if (!string.IsNullOrEmpty(order.Email))
                    {
                        SendEmail(order.Email);
                    }
                }
                catch (Exception e)
                {
                    command.CommandText = "ROLLBACK;";
                    command.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void SendEmail(string email)
        {
            
            MailAddress from = new MailAddress("curier.aaa.bbb@yandex.ru", "Site");// отправитель - устанавливаем адрес и отображаемое в письме имя            
            MailAddress to = new MailAddress(email);// кому отправляем            
            MailMessage m = new MailMessage(from, to);// создаем объект сообщения            
            m.Subject = "Доставка";// тема письма            
            m.Body = "<h2>Ваша заказ успешно зарегестрирован!</h2>";// текст письма            
            m.IsBodyHtml = true;// письмо представляет код html            
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 465);// адрес smtp-сервера и порт, с которого будем отправлять письмо            
            smtp.Credentials = new NetworkCredential("curier.aaa.bbb@yandex.ru", "nhgjnjab");// логин и пароль
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View("Contacts");
        }

        public IActionResult Order()
        {
            return View();
        }

        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Feature()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
