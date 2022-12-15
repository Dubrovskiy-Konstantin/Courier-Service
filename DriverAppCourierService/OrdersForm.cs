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
        private Drivers currentDriver;
        public delegate void ShowAncestor();
        private ShowAncestor showAncestor;

        public OrdersForm(int driverId, ShowAncestor _delegate)
        {
            showAncestor = _delegate;

            InitializeComponent();

            currentDriver = SqlWorkerDriverApp.GetDriverById(driverId);
        }

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            if (currentDriver.CountOfOrder == 0)
            {
                MessageBox.Show("You don't have an order to finish!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                Nodes node = SqlWorkerDriverApp.GetNodeById("Id_Driver", currentDriver.Id);
                Cars car = SqlWorkerDriverApp.GetCarById(node.IdCar);
                Orders order = SqlWorkerDriverApp.GetOrderById(node.IdOrder);
                Addresses addressPointA = SqlWorkerDriverApp.GetAddressById(order.IdPointFrom);
                Addresses addressPointB = SqlWorkerDriverApp.GetAddressById(order.IdPointTo);
                string address = addressPointA.Address + " " + addressPointB.Address;

                
                List<Details> details = SqlWorkerDriverApp.GetDetails();
                List<Nodes> nodes = SqlWorkerDriverApp.GetNodes();
                List<Movers> movers = SqlWorkerDriverApp.GetMovers();

                SqlWorkerDriverApp.Delete("Nodes", "Id", node.Id);

                for (int index = 0; index < movers.Count; index++)
                {
                    if (movers[index].IdOrder == order.Id)
                    {
                        SqlWorkerDriverApp.Update("Movers", movers[index].Id, "Id_Order", DBNull.Value);
                    }
                }

                for (int index = 0; index < details.Count; index++)
                {
                    if (details[index].IdOrder == order.Id)
                    {
                        SqlWorkerDriverApp.Delete("Details", "Id_Order", order.Id);
                    }
                }

                SqlWorkerDriverApp.Delete("Orders", "Id", order.Id);
                SqlWorkerDriverApp.Delete("Addresses", "Id", addressPointA.Id);
                SqlWorkerDriverApp.Delete("Addresses", "Id", addressPointB.Id);
                SqlWorkerDriverApp.Update("Drivers", currentDriver.Id, "Count_of_Order", 0);
                SqlWorkerDriverApp.Update("Cars", car.Id, "Is_Free", 1);

                SqlWorkerDriverApp.AddArchive(currentDriver.Name, car.RegistryNumber, address);
                List<Archive> archive = SqlWorkerDriverApp.GetArchive();
                SqlWorkerDriverApp.AddLog(order.Id, order.Date, archive[archive.Count - 1].Id, (int)order.Cost);

                MessageBox.Show("Order finished successfully!", "Success", MessageBoxButtons.OK);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ordersDataGridView.DataSource = DataHandler.SetData("Orders").Tables[0];
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.AllowUserToAddRows = false;

            for (int i = 0; i < ordersDataGridView.Rows.Count; i++)
            {
                if (!((int)ordersDataGridView.Rows[i].Cells[4].Value).Equals(1))
                {
                    ordersDataGridView.Rows.RemoveAt(ordersDataGridView.Rows[i].Index);
                }
            }

            if (currentDriver.CountOfOrder.Equals(1))
            {
                Orders order = SqlWorkerDriverApp.GetOrderById(SqlWorkerDriverApp.GetNodeById("Id_Driver", currentDriver.Id).IdOrder);
                currentOrderLabel.Text = order.ToString();
                currentOrderLabel.Left = 700 - (2 * currentOrderLabel.Size.Width);
            }
        }

        private void ordersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentDriver.CountOfOrder == 1)
            {
                MessageBox.Show("You already have an order.\nYou can pick another when you finish with current order!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                ChooseMoverForm chooseMoverForm = new ChooseMoverForm((int)ordersDataGridView.Rows[e.RowIndex].Cells[0].Value, currentDriver.Id, this.Close);
                chooseMoverForm.Show();
            }
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            if (currentDriver.CountOfOrder == 0)
            {
                MessageBox.Show("You don't have an order yet!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                Orders order = SqlWorkerDriverApp.GetOrderById(SqlWorkerDriverApp.GetNodeById("Id_Driver", currentDriver.Id).IdOrder);

                Addresses addressPointA = SqlWorkerDriverApp.GetAddressById(order.IdPointFrom);
                Addresses addressPointB = SqlWorkerDriverApp.GetAddressById(order.IdPointTo);

                System.Diagnostics.Process.Start($@"https://yandex.by/maps/?ll=auto&mode=routes&rtext={addressPointA.X}%2C{addressPointA.Y}~{addressPointB.X}%2C{addressPointB.Y}&rtt=auto&ruri=~&z=auto");
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            userInfoLabel.Text = string.Empty;
            userInfoLabel.Text += currentDriver.Name;

            ordersDataGridView.DataSource = DataHandler.SetData("Orders").Tables[0];
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.AllowUserToAddRows = false;

            for (int i = 0; i < ordersDataGridView.Rows.Count; i++)
            {
                if (!((int)ordersDataGridView.Rows[i].Cells[4].Value).Equals(1))
                {
                    ordersDataGridView.Rows.RemoveAt(ordersDataGridView.Rows[i].Index);
                }
            }

            if (currentDriver.CountOfOrder.Equals(1))
            {
                Orders order = SqlWorkerDriverApp.GetOrderById(SqlWorkerDriverApp.GetNodeById("Id_Driver", currentDriver.Id).IdOrder);
                currentOrderLabel.Text = order.ToString();
                currentOrderLabel.Left = 700 - 2 * (currentOrderLabel.Size.Width / 2);
            }
        }

        private void OrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            showAncestor.Invoke();
        }
    }
}
