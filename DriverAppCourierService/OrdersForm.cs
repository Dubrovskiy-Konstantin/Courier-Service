using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriverAppCourierService.Entities;

namespace DriverAppCourierService
{
    public partial class OrdersForm : Form
    {
        public OrdersForm(int DriverId)
        {
            InitializeComponent();

            List<Drivers> drivers = SqlWorkerDriverApp.GetDrivers();
            Drivers driver = new Drivers();

            for (int i = 0; i < drivers.Count; i++)
            {
                if (drivers[i].Id == DriverId)
                {
                    driver = drivers[i];
                    break;
                }
            }

            userInfoLabel.Text = string.Empty;
            userInfoLabel.Text += driver.Name;
        }

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            ChooseMoverForm chooseMoverForm = new ChooseMoverForm();
            chooseMoverForm.Show();
        }
    }
}
