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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Admin";
            string password = "12345";
            if(Txt_Username.Text == String.Empty || Txt_Username.Text == "" || Txt_Password.Text =="" || Txt_Password.Text==String.Empty ) 
            {
                MessageBox.Show("Bu alanlar boş bırakılamaz", "Hata oluştu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Marketmanagment frm = new Marketmanagment();
                frm.Show();
                Login frm1 = new Login();
                frm1.Dispose();
                this.Close();
                
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
