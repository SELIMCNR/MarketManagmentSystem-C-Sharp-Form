using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagmentSystem
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketmanagmentsystemDataSet3.Salesmanagment' table. You can move, or remove it, as needed.
            this.salesmanagmentTableAdapter.Fill(this.marketmanagmentsystemDataSet3.Salesmanagment);
            // TODO: This line of code loads data into the 'marketmanagmentsystemDataSet3.Salesmanagment' table. You can move, or remove it, as needed.
            this.salesmanagmentTableAdapter.Fill(this.marketmanagmentsystemDataSet3.Salesmanagment);
            // TODO: This line of code loads data into the 'marketmanagmentsystemDataSet.Productmanagment' table. You can move, or remove it, as needed.
            this.productmanagmentTableAdapter.Fill(this.marketmanagmentsystemDataSet.Productmanagment);
            timer1.Start();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            sayac++;
            if(sayac %2 == 0)
            {
                label1.BackColor = Color.Blue;
                label1.ForeColor= Color.Yellow;
                label2.BackColor = Color.Yellow;
                label2.ForeColor = Color.Blue;
            }
            else
            {
                label1.BackColor = Color.Yellow;
                label1.ForeColor = Color.Blue;
                 label2.BackColor = Color.Blue;
                label2.ForeColor = Color.Yellow;
            }
           
            
        }
    }
}
