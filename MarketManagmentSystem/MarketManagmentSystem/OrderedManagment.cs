using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketManagmentSystem
{
    public partial class OrderedManagment : Form
    {
        public OrderedManagment()
        {
            InitializeComponent();
        }
        public SqlConnection bgl = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Marketmanagmentsystem.mdf;Integrated Security=True");
        public SqlCommand komut;
        public SqlDataAdapter da;
        public DataTable dt;

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;

            Txt_Orderıd.Visible = true;
            Txt_Dat.Visible = true;

            groupBox2.Visible = true;

            dataGridView1.Visible = true;
            groupBox3.Visible = true;


         
        }



        private void OrderedManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketmanagmentsystemDataSet2.Ordermanagment' table. You can move, or remove it, as needed.
            this.ordermanagmentTableAdapter1.Fill(this.marketmanagmentsystemDataSet2.Ordermanagment);
            // TODO: This line of code loads data into the 'marketmanagmentsystemDataSet1.Ordermanagment' table. You can move, or remove it, as needed.
        

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            bgl.Open();
            komut = new SqlCommand("INSERT INTO Salesmanagment (CustomerName,Date_,OrderStatus,ContactNumber) Values (@p1,@p2,@p3,@p4)", bgl);
            komut.Parameters.AddWithValue("@p1", Txt_Customer.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Dat.Text);
            komut.Parameters.AddWithValue("@p3", Txt_Orderıd.Text);
            komut.Parameters.AddWithValue("@p4", Txt_Phone.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydetme işlemi yapıldı.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.Close() ;

        }

        private void Btn_item_Click(object sender, EventArgs e)
        {
            bgl.Open();
            komut = new SqlCommand("INSERT INTO Ordermanagment (ProductName,Quantity) Values (@p1,@p2)", bgl);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Quantity.Text);

            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Ekleme işlemi yapıldı.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ordermanagmentTableAdapter1.Fill(this.marketmanagmentsystemDataSet2.Ordermanagment);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           label8.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
