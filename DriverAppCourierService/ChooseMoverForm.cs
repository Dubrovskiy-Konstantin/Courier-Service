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
    public partial class ChooseMoverForm : Form
    {
        public ChooseMoverForm()
        {
            InitializeComponent();

            carsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carsDataGridView.AllowUserToAddRows = false;
            carsDataGridView.DataSource = DataHandler.SetData("Cars").Tables[0];

            moversDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            moversDataGridView.AllowUserToAddRows = false;
            moversDataGridView.DataSource = DataHandler.SetData("Movers").Tables[0];
        }
    }
}
