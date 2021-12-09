using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form2 : Form
    {
        private object customersBindingSource;
        private object ordersBindingSource;

        public object northwindDataSet { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void UpdateData()
        {
            this.Validate();
            this.customersBindingSource.Id();
            this.ordersBindingSource.EndEdit();

            using (System.Transactions.TransactionScope updateTransaction =
                new System.Transactions.TransactionScope())
            {
                DeleteOrders();
                DeleteCustomers();
                AddNewCustomers();
                AddNewOrders();

                updateTransaction.Complete();
                northwindDataSet.AcceptChanges();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
