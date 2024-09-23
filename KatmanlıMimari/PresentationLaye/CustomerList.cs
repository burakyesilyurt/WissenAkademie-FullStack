using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLaye
{
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();

            this.Load += CustomerList_Load;
        }

        private void CustomerList_Load(object? sender, EventArgs e)
        {
            BusinessLogicLayer businessLayer = new BusinessLogicLayer();
            dgvCustomers.DataSource = businessLayer.Customers();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string customerID = string.Empty;
            customerID = dgvCustomers[0,e.RowIndex].Value.ToString();

            MessageBox.Show(customerID);
        }
    }
}
