using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriverAppCourierService.Entities;

namespace DriverAppCourierService
{
    public partial class ChooseMoverForm : Form
    {
        private int orderId, driverId;

        public ChooseMoverForm(int orderId, int driverId)
        {
            InitializeComponent();

            this.orderId = orderId;
            this.driverId = driverId;

            carsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carsDataGridView.AllowUserToAddRows = false;
            carsDataGridView.DataSource = DataHandler.SetData("Cars").Tables[0];

            for (int i = 0; i < carsDataGridView.Rows.Count; i++)
            {
                if (!(bool)carsDataGridView.Rows[i].Cells[6].Value)
                {
                    carsDataGridView.Rows.RemoveAt(carsDataGridView.Rows[i].Index);
                }
            }

            moversDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            moversDataGridView.AllowUserToAddRows = false;
            moversDataGridView.DataSource = DataHandler.SetData("Movers").Tables[0];

            for (int i = 0; i < moversDataGridView.Rows.Count; i++)
            {
                if (moversDataGridView.Rows[i].Cells[1].Value == null)
                {
                    moversDataGridView.Rows.RemoveAt(moversDataGridView.Rows[i].Index);
                }
            }

            unitsLabel.Text = "Unit(s): ";
            unitsDescriptionLabel.Text = "Description: ";
            unitsAmountLabel.Text = "Amount: ";
            
            List<Details> orderDetails = SqlWorkerDriverApp.GetDetailById("Id_Order", orderId);

            foreach (Details details in orderDetails)
            {
                unitsLabel.Text += details.Unit + "; ";
                unitsDescriptionLabel.Text += details.UnitDescription + "; ";
                unitsAmountLabel.Text += details.UnitAmount + "; ";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Orders order = SqlWorkerDriverApp.GetOrderById(orderId);

            if (carsDataGridView.SelectedRows.Count.Equals(1) && moversDataGridView.SelectedRows.Count.Equals(order.ExpectedNumOfMovers))
            {
                SqlWorkerDriverApp.AddNode(orderId, (int)carsDataGridView.SelectedRows[0].Cells[0].Value, driverId);

                for (int i = 0; i < moversDataGridView.SelectedRows.Count; i++)
                {
                    SqlWorkerDriverApp.Update("Movers", (int)moversDataGridView.SelectedRows[i].Cells[0].Value, "Id_Order", orderId);
                }

                SqlWorkerDriverApp.Update("Orders", orderId, "Status", 2);
                SqlWorkerDriverApp.Update("Drivers", driverId, "Count_of_Order", 1);
                SqlWorkerDriverApp.Update("Cars", (int)carsDataGridView.SelectedRows[0].Cells[0].Value, "Is_Free", 0);

                MessageBox.Show($"Order successfully started!", "Success", MessageBoxButtons.OK);
                
                OrdersForm ordersForm = new OrdersForm(driverId, this.Close);
                ordersForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Select only one car and no more than {order.ExpectedNumOfMovers} movers!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void ChooseMoverForm_Load(object sender, EventArgs e)
        {
            carsDataGridView.ClearSelection();
            moversDataGridView.ClearSelection();
        }

        private void ChooseMoverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm(driverId, this.Close);
            ordersForm.Show();
            this.Hide();
        }

        private void SendEmail(string email)
        {

            MailAddress from = new MailAddress("curier.aaa.bbb@yandex.ru", "Site");// отправитель - устанавливаем адрес и отображаемое в письме имя            
            MailAddress to = new MailAddress(email);// кому отправляем            
            MailMessage m = new MailMessage(from, to);// создаем объект сообщения            
            m.Subject = "Доставка";// тема письма            
            m.Body = "<h2>Ваш заказ в пути!</h2>";// текст письма            
            m.IsBodyHtml = true;// письмо представляет код html            
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 465);// адрес smtp-сервера и порт, с которого будем отправлять письмо            
            smtp.Credentials = new NetworkCredential("curier.aaa.bbb@yandex.ru", "nhgjnjab");// логин и пароль
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
