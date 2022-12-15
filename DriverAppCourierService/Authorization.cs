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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>()
            {
                loginTextBox, passwordTextBox
            };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Text == string.Empty)
                {
                    MessageBox.Show("Empty box detected. Please fill all boxes.", "Warning", MessageBoxButtons.OK);
                    return;
                }
            }

            List<Accounts> accounts = SqlWorkerDriverApp.GetAccounts();

            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Email == loginTextBox.Text && accounts[i].Password == passwordTextBox.Text)
                {
                    OrdersForm ordersForm = new OrdersForm(accounts[i].IdDriver, this.Close);
                    ordersForm.Show();
                    break;
                }

                if (i.Equals(accounts.Count - 1))
                {
                    MessageBox.Show("Incorrect email or password!", "Warning", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}
