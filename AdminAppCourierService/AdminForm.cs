using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminAppCourierService.Entities;

namespace AdminAppCourierService
{
    public partial class AdminForm : Form
    {
        string[] tablesName = { "Accounts", "Adresses", "Cars", "Details", "Drivers", "Log", "Movers", "Nodes", "Orders", "Taxes" };

        public AdminForm()
        {
            InitializeComponent();

            tablesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablesDataGridView.AllowUserToAddRows = false;
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
            List<TextBox> list = new List<TextBox>()
            {
                driverNameTextBox, driverPhoneTextBox, accountEmailTextBox, accountPasswordTextBox
            };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Text == string.Empty)
                {
                    MessageBox.Show("Empty box detected. Please fill all boxes.");
                    return;
                }
            }

            List<Drivers> drivers = SqlWorkerAdminApp.GetDrivers();

            for (int i = 0; i < drivers.Count; i++)
            {
                if (drivers[i].Phone == driverPhoneTextBox.Text)
                {
                    MessageBox.Show("Driver with this phone number already exists!");
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

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Text = string.Empty;
            }

            MessageBox.Show("Driver successfully added!");
        }

        private void addMoverButton_Click(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>()
            {
                moverNameTextBox, moverPhoneTextBox
            };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Text == string.Empty)
                {
                    MessageBox.Show("Empty box detected. Please fill all boxes.");
                    return;
                }
            }

            List<Movers> movers = SqlWorkerAdminApp.GetMovers();

            for (int i = 0; i < movers.Count; i++)
            {
                if (movers[i].Phone == driverPhoneTextBox.Text)
                {
                    MessageBox.Show("Mover with this phone number already exists!");
                    return;
                }
            }

            SqlWorkerAdminApp.AddMover(moverNameTextBox.Text, moverPhoneTextBox.Text);

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Text = string.Empty;
            }

            MessageBox.Show("Mover successfully added!");
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>()
            {
                carMarkTextBox, carRegistryNumberTextBox, carIssueYearTextBox, carMileageTextBox, carLastMaintenanceTextBox
            };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Text == string.Empty)
                {
                    MessageBox.Show("Empty box detected. Please fill all boxes.");
                    return;
                }
            }

            List<Cars> cars = SqlWorkerAdminApp.GetCars();

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].RegistryNumber == carRegistryNumberTextBox.Text)
                {
                    MessageBox.Show("Car with this registry number already exists!");
                    return;
                }
            }

            SqlWorkerAdminApp.AddCar(carMarkTextBox.Text, carRegistryNumberTextBox.Text, Convert.ToInt32(carIssueYearTextBox.Text), Convert.ToDouble(carMileageTextBox.Text), carLastMaintenanceTextBox.Text);

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Text = string.Empty;
            }

            MessageBox.Show("Car successfully added!");
        }
    }
}
