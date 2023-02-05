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
    public partial class Marketmanagment : Form
    {
        public Marketmanagment()
        {
            InitializeComponent();
        }

        private void productManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagment frm = new ProductManagment();
            frm.ShowDialog();
            frm.Dispose();

        }


        private void startSellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderedManagment frm = new OrderedManagment();
            frm.ShowDialog();
            frm.Dispose();  
            
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void aboutProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("Market yönetim sistemi c-sharp form uygulamasıdır. Selim çınar tarafından tasarlanmış ve kodlanmıştır.");
          

           
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
          
                Application.Exit();
            
              
            
        }
    }
}
