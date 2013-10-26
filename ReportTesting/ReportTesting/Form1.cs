using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Customers' table. You can move, or remove it, as needed.
            this.CustomersTableAdapter.Fill(this.DataSet1.Customers, this.FirstName.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
