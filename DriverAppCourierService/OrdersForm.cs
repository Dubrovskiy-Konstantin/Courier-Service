using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverAppCourierService
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            ChooseMoverForm chooseMoverForm = new ChooseMoverForm();
            chooseMoverForm.Show();
        }
    }
}
