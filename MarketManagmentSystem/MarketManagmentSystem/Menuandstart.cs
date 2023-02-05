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
    public partial class Menuandstart : Form
    {
        public Menuandstart()
        {
            
            InitializeComponent();
          
        }


    
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;


            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                Login frm= new Login();
                frm.Show();
               
                return;
           
            }

            progressBar1.Value += 1;
        

        }

        private void Menuandstart_Load(object sender, EventArgs e)
        {
            timer1.Start();
         
        }

      
    }
}
