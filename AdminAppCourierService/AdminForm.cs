using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminAppCourierService.Entities;

namespace AdminAppCourierService
{
    public partial class AdminForm : Form
    {
        string[] tablesName = { "Accounts", "Addresses", "Cars", "Details", "Drivers", "Movers", "Nodes", "Orders", "Taxes" };

        public AdminForm()
        {
            InitializeComponent();

            tablesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablesDataGridView.AllowUserToAddRows = false;

            archiveDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            archiveDataGridView.AllowUserToAddRows = false;

            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;

            if (SqlWorkerAdminApp.GetLog().Count != 0)
            {
                Log log = SqlWorkerAdminApp.GetLogById(1);

                dateTimePickerStart.MinDate = DateTime.ParseExact(log.EndDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                dateTimePickerEnd.MinDate = DateTime.ParseExact(log.EndDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }
            else
            {
                dateTimePickerStart.MinDate = DateTime.Now;
                dateTimePickerEnd.MinDate = DateTime.Now;
            }

            dateTimePickerStart.MaxDate = DateTime.Now;
            dateTimePickerEnd.MaxDate = DateTime.Now;
            carLastMaintenanceDateTimePicker.MinDate = new DateTime(2000, 1, 1);
            carLastMaintenanceDateTimePicker.MaxDate = DateTime.Now;
        }

        private void dropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
        }

        private void addDriverButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(driverNameTextBox.Text) || string.IsNullOrWhiteSpace(driverPhoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(accountEmailTextBox.Text) || string.IsNullOrWhiteSpace(accountPasswordTextBox.Text))
            {
                MessageBox.Show("Empty box detected. Please fill all boxes.", "Warning", MessageBoxButtons.OK);
                return;
            }

            var trimmedEmail = accountEmailTextBox.Text.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                MessageBox.Show("Email isn't correct!", "Warning", MessageBoxButtons.OK);
                return;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(accountEmailTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Email isn't correct!", "Warning", MessageBoxButtons.OK);
                return;
            }

            List<Drivers> drivers = SqlWorkerAdminApp.GetDrivers();

            for (int i = 0; i < drivers.Count; i++)
            {
                if (drivers[i].Phone == driverPhoneTextBox.Text)
                {
                    MessageBox.Show("Driver with this phone number already exists!", "Warning", MessageBoxButtons.OK);
                    return;
                }
            }

            SqlWorkerAdminApp.AddDriver(driverNameTextBox.Text, driverPhoneTextBox.Text);

            drivers = SqlWorkerAdminApp.GetDrivers();

            for (int i = 0; i < drivers.Count; i++)
            {
                if (drivers[i].Name == driverNameTextBox.Text && drivers[i].Phone == driverPhoneTextBox.Text)
                {
                    SqlWorkerAdminApp.AddAccount(accountEmailTextBox.Text, accountPasswordTextBox.Text, drivers[i].Id);
                    break;
                }
            }

            driverNameTextBox.Text = string.Empty;
            driverPhoneTextBox.Text = string.Empty;
            accountEmailTextBox.Text = string.Empty;
            accountPasswordTextBox.Text = string.Empty;

            MessageBox.Show("Driver successfully added!", "Success", MessageBoxButtons.OK);
        }

        private void addMoverButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(moverNameTextBox.Text) || string.IsNullOrWhiteSpace(moverPhoneTextBox.Text))
            {
                MessageBox.Show("Empty box detected. Please fill all boxes.", "Warning", MessageBoxButtons.OK);
                return;
            }

            List<Movers> movers = SqlWorkerAdminApp.GetMovers();

            for (int i = 0; i < movers.Count; i++)
            {
                if (movers[i].Phone == driverPhoneTextBox.Text)
                {
                    MessageBox.Show("Mover with this phone number already exists!", "Warning", MessageBoxButtons.OK);
                    return;
                }
            }

            SqlWorkerAdminApp.AddMover(moverNameTextBox.Text, moverPhoneTextBox.Text);

            moverNameTextBox.Text = string.Empty;
            moverPhoneTextBox.Text = string.Empty;

            MessageBox.Show("Mover successfully added!", "Success", MessageBoxButtons.OK);
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>()
            {
                carMarkTextBox, carRegistryNumberTextBox, carIssueYearTextBox, carMileageTextBox
            };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Text == string.Empty)
                {
                    MessageBox.Show("Empty box detected. Please fill all boxes.", "Warning", MessageBoxButtons.OK);
                    return;
                }
            }

            if (!int.TryParse(carIssueYearTextBox.Text, out _))
            {
                MessageBox.Show("Issue year contains only digit!", "Warning", MessageBoxButtons.OK);
                return;
            }

            List<Cars> cars = SqlWorkerAdminApp.GetCars();

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].RegistryNumber == carRegistryNumberTextBox.Text)
                {
                    MessageBox.Show("Car with this registry number already exists!", "Warning", MessageBoxButtons.OK);
                    return;
                }
            }

            string date = carLastMaintenanceDateTimePicker.Value.ToString("yyyy-MM-dd");

            SqlWorkerAdminApp.AddCar(carMarkTextBox.Text, carRegistryNumberTextBox.Text, Convert.ToInt32(carIssueYearTextBox.Text), Convert.ToDouble(carMileageTextBox.Text), date);

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Text = string.Empty;
            }

            MessageBox.Show("Car successfully added!", "Success", MessageBoxButtons.OK);
        }

        private void tablesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string[] bannedColumns = { "Id", "Id_Order", "Id_Car", "Id_Driver", "Id_Point_From", "Id_Point_To", "Count_of_Order", "Is_Free", "Archive_Id", "Payed", "Status" };

            if (string.IsNullOrEmpty(tablesDataGridView.CurrentCell.Value.ToString()))
            {
                MessageBox.Show("Value cannot be null!", "Warning", MessageBoxButtons.OK);
                tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
            }
            else if (bannedColumns.Any(tablesDataGridView.Columns[tablesDataGridView.CurrentCell.ColumnIndex].Name.Contains) ||
                (tablesName[dropDownList.SelectedIndex].Equals("Taxes") && tablesDataGridView.Columns[tablesDataGridView.CurrentCell.ColumnIndex].Name == "Name"))
            {
                MessageBox.Show("Cant update a value in this column!", "Warning", MessageBoxButtons.OK);
                tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
            }
            else if (tablesName[dropDownList.SelectedIndex].Equals("Taxes"))
            {
                SqlWorkerAdminApp.UpdateTaxes((string)tablesDataGridView.Rows[tablesDataGridView.CurrentCell.RowIndex].Cells[0].Value, (string)tablesDataGridView.Rows[tablesDataGridView.CurrentCell.RowIndex].Cells[1].Value);
                MessageBox.Show("Taxes successfully updated!", "Success", MessageBoxButtons.OK);
                tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
            }
            else if (tablesDataGridView.Columns[tablesDataGridView.CurrentCell.ColumnIndex].Name == "Email" ||
                tablesDataGridView.Columns[tablesDataGridView.CurrentCell.ColumnIndex].Name == "Client_Email")
            {
                var trimmedEmail = ((string)tablesDataGridView.CurrentCell.Value).Trim();

                if (trimmedEmail.EndsWith("."))
                {
                    MessageBox.Show("Email isn't correct!", "Warning", MessageBoxButtons.OK);
                    tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
                    return;
                }
                try
                {
                    var addr = new System.Net.Mail.MailAddress((string)tablesDataGridView.CurrentCell.Value);
                }
                catch
                {
                    MessageBox.Show("Email isn't correct!", "Warning", MessageBoxButtons.OK);
                    tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
                    return;
                }

                string tableName = tablesName[dropDownList.SelectedIndex];
                int id = (int)tablesDataGridView.Rows[tablesDataGridView.CurrentCell.RowIndex].Cells[0].Value;
                string columnName = tablesDataGridView.Columns[tablesDataGridView.CurrentCell.ColumnIndex].Name;
                object value = tablesDataGridView.CurrentCell.Value;
                SqlWorkerAdminApp.Update(tableName, id, columnName, value);
                tablesDataGridView.CurrentCell.Selected = false;
                MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK);
            }
            else if (tablesDataGridView.Columns[tablesDataGridView.CurrentCell.ColumnIndex].Name == "Issue_Year")
            {
                if (tablesDataGridView.CurrentCell.ValueType == typeof(int) && ((int)tablesDataGridView.CurrentCell.Value >= 1980 && (int)tablesDataGridView.CurrentCell.Value <= DateTime.Now.Year))
                {
                    string tableName = tablesName[dropDownList.SelectedIndex];
                    int id = (int)tablesDataGridView.Rows[tablesDataGridView.CurrentCell.RowIndex].Cells[0].Value;
                    string columnName = tablesDataGridView.Columns[tablesDataGridView.CurrentCell.ColumnIndex].Name;
                    object value = tablesDataGridView.CurrentCell.Value;
                    SqlWorkerAdminApp.Update(tableName, id, columnName, value);
                    tablesDataGridView.CurrentCell.Selected = false;
                    MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Invalid input!", "Warning", MessageBoxButtons.OK);
                    tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
                }
            }
            else if (tablesDataGridView.Columns[tablesDataGridView.CurrentCell.ColumnIndex].Name == "Last_Maintenance")
            {
                string regex = @"\d{4}-\d{2}-\d{2}";

                if (!Regex.IsMatch((string)tablesDataGridView.CurrentCell.Value, regex))
                {
                    MessageBox.Show("Invalid input!\nInput date like 'yyyy-MM-dd'", "Warning", MessageBoxButtons.OK);
                    tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
                }
                else
                {
                    try
                    {
                        DateTime dt = DateTime.ParseExact((string)tablesDataGridView.CurrentCell.Value, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                        string tableName = tablesName[dropDownList.SelectedIndex];
                        int id = (int)tablesDataGridView.Rows[tablesDataGridView.CurrentCell.RowIndex].Cells[0].Value;
                        string columnName = tablesDataGridView.Columns[tablesDataGridView.CurrentCell.ColumnIndex].Name;
                        object value = tablesDataGridView.CurrentCell.Value;
                        SqlWorkerAdminApp.Update(tableName, id, columnName, value);
                        tablesDataGridView.CurrentCell.Selected = false;
                        MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input!", "Warning", MessageBoxButtons.OK);
                        tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
                    }
                }
            }
            else
            {
                string tableName = tablesName[dropDownList.SelectedIndex];
                int id = (int)tablesDataGridView.Rows[tablesDataGridView.CurrentCell.RowIndex].Cells[0].Value;
                string columnName = tablesDataGridView.Columns[tablesDataGridView.CurrentCell.ColumnIndex].Name;
                object value = tablesDataGridView.CurrentCell.Value;
                SqlWorkerAdminApp.Update(tableName, id, columnName, value);
                tablesDataGridView.CurrentCell.Selected = false;
                MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tablesName[dropDownList.SelectedIndex] == "Taxes")
            {
                MessageBox.Show("Taxes cannot be deleted, they can only be changed", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (tablesName[dropDownList.SelectedIndex] == "Accounts")
            {
                MessageBox.Show("Accounts cannot be deleted manually!", "Warning", MessageBoxButtons.OK);
                return;
            }

            for (int i = 0; i < tablesDataGridView.SelectedRows.Count; i++)
            {
                int id = (int)tablesDataGridView.SelectedRows[i].Cells[0].Value;

                switch (tablesName[dropDownList.SelectedIndex])
                {
                    case "Orders":
                        int addressFrom = (int)tablesDataGridView.SelectedRows[i].Cells[9].Value;
                        int addressTo = (int)tablesDataGridView.SelectedRows[i].Cells[10].Value;
                        List<Details> details = SqlWorkerAdminApp.GetDetails();

                        for (int index = 0; index < details.Count; index++)
                        {
                            if (details[index].IdOrder == id)
                            {
                                SqlWorkerAdminApp.Delete("Details", "Id_Order", id);
                            }
                        }

                        List<Nodes> nodes = SqlWorkerAdminApp.GetNodes();

                        for (int index = 0; index < nodes.Count; index++)
                        {
                            if (nodes[index].IdOrder == id)
                            {
                                SqlWorkerAdminApp.Delete("Nodes", "Id_Order", id);
                                break;
                            }
                        }

                        List<Movers> movers = SqlWorkerAdminApp.GetMovers();

                        for (int index = 0; index < movers.Count; index++)
                        {
                            if (movers[index].IdOrder == id)
                            {
                                SqlWorkerAdminApp.Update("Movers", movers[index].Id, "Id_Order", DBNull.Value);
                            }
                        }

                        SqlWorkerAdminApp.Delete("Orders", "Id", id);
                        SqlWorkerAdminApp.Delete("Addresses", "Id", addressFrom);
                        SqlWorkerAdminApp.Delete("Addresses", "Id", addressTo);

                        MessageBox.Show("Successfully deleted!", "Success", MessageBoxButtons.OK);
                        tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
                        break;
                    case "Nodes":
                        int orderId = (int)tablesDataGridView.SelectedRows[i].Cells[1].Value;
                        int carId = (int)tablesDataGridView.SelectedRows[i].Cells[2].Value;
                        int driverId = (int)tablesDataGridView.SelectedRows[i].Cells[3].Value;

                        SqlWorkerAdminApp.Delete("Nodes", "Id", id);

                        movers = SqlWorkerAdminApp.GetMovers();

                        for (int index = 0; index < movers.Count; index++)
                        {
                            if (movers[index].IdOrder == orderId)
                            {
                                SqlWorkerAdminApp.Update("Movers", movers[index].Id, "Id_Order", DBNull.Value);
                            }
                        }

                        SqlWorkerAdminApp.Update("Orders", orderId, "Status", 1);
                        SqlWorkerAdminApp.Update("Cars", carId, "Is_Free", 1);
                        SqlWorkerAdminApp.Update("Drivers", driverId, "Count_of_Order", 0);

                        MessageBox.Show("Successfully deleted!", "Success", MessageBoxButtons.OK);
                        tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
                        break;
                    case "Details":
                        SqlWorkerAdminApp.Delete("Details", "Id", id);
                        MessageBox.Show("Successfully deleted!", "Success", MessageBoxButtons.OK);
                        tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
                        break;
                    case "Cars":
                        List<Cars> cars = SqlWorkerAdminApp.GetCars();

                        for (int index = 0; index < cars.Count; index++)
                        {
                            if (cars[index].Id == id)
                            {
                                if (cars[index].IsFree)
                                {
                                    SqlWorkerAdminApp.Delete("Cars", "Id", cars[index].Id);
                                }
                                else
                                {
                                    MessageBox.Show($"Car with id = {cars[index].Id} is busy right now.", "Warning", MessageBoxButtons.OK);
                                }
                            }
                        }

                        MessageBox.Show("Successfully deleted!", "Success", MessageBoxButtons.OK);
                        tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
                        break;
                    case "Drivers":
                        List<Drivers> drivers = SqlWorkerAdminApp.GetDrivers();

                        for (int index = 0; index < drivers.Count; index++)
                        {
                            if (drivers[index].Id == id)
                            {
                                if (drivers[index].CountOfOrder == 0)
                                {
                                    SqlWorkerAdminApp.Delete("Drivers", "Id", drivers[index].Id);
                                }
                                else
                                {
                                    MessageBox.Show($"Driver with id = {drivers[index].Id} is busy right now.", "Warning", MessageBoxButtons.OK);
                                }

                            }
                        }

                        MessageBox.Show("Successfully deleted!", "Success", MessageBoxButtons.OK);
                        tablesDataGridView.DataSource = DataHandler.SetData(tablesName[dropDownList.SelectedIndex]).Tables[0];
                        break;
                    default:
                        MessageBox.Show($"Cannot delete a row in {tablesName[dropDownList.SelectedIndex]}");
                        break;
                }
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            archiveDataGridView.DataSource = null;

            if (archiveDataGridView.Columns.Count != 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    archiveDataGridView.Columns.RemoveAt(0);
                }
            }

            string[] columnsName = { "Driver_Name", "Car_Number", "Orders_Points" };
            List<Archive> archive = SqlWorkerAdminApp.GetArchive();
            List<Log> log = SqlWorkerAdminApp.GetLog();
            int income = 0;

            DateTime dateStart = dateTimePickerStart.Value;
            DateTime dateEnd = dateTimePickerEnd.Value;

            log = log.FindAll(x =>
                DateTime.ParseExact(x.EndDate, "yyyy-MM-dd", CultureInfo.InvariantCulture) >= dateStart &&
                DateTime.ParseExact(x.EndDate, "yyyy-MM-dd", CultureInfo.InvariantCulture) <= dateEnd);

            List<Archive> currentArchive = new List<Archive>();

            for (int i = 0; i < log.Count; i++)
            {
                for (int j = 0; j < archive.Count; j++)
                {
                    if (log[i].ArchiveId == archive[j].Id)
                    {
                        currentArchive.Add(archive[j]);
                        break;
                    }
                }
            }

            if (log.Count != 0)
            {
                BindingList<Log> logs = new BindingList<Log>();

                for (int i = 0; i < log.Count; i++)
                {
                    logs.Add(SqlWorkerAdminApp.GetLogById(log[i].Id));
                }

                archiveDataGridView.DataSource = logs;

                if (archiveDataGridView.Columns.Count != 7)
                {
                    for (int i = 0; i < columnsName.Length; i++)
                    {
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        column.Name = columnsName[i];
                        column.ValueType = typeof(string);
                        archiveDataGridView.Columns.Add(column);
                    }
                }

                for (int i = 0; i < archiveDataGridView.Rows.Count; i++)
                {
                    archiveDataGridView.Rows[i].Cells[5].Value = currentArchive[i].DriverName;
                    archiveDataGridView.Rows[i].Cells[6].Value = currentArchive[i].CarNumber;
                    archiveDataGridView.Rows[i].Cells[7].Value = currentArchive[i].OrderPoints;
                }

                for (int i = 0; i < log.Count; i++)
                {
                    income += log[i].Income;
                }

                countOfOrdersLabel.Text = $"Count of orders : {log.Count}";
                totalIncomeLabel.Text = $"Total income : {income}";
            }
            else
            {
                countOfOrdersLabel.Text = $"Count of orders";
                totalIncomeLabel.Text = $"Total income";
            }
            
        }
    }
}
