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

namespace MarketManagmentSystem
{
    public partial class ProductManagment : Form
    {
        public ProductManagment()
        {
            InitializeComponent();
        }

        

        public SqlConnection bgl = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Marketmanagmentsystem.mdf;Integrated Security=True");
        public SqlCommand komut;
        public SqlDataAdapter da;
        public DataTable dt;

        private void ProductManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketmanagmentsystemDataSet.Productmanagment' table. You can move, or remove it, as needed.
            this.productmanagmentTableAdapter.Fill(this.marketmanagmentsystemDataSet.Productmanagment);
           
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Name.Text == "" || Txt_Name.Text == string.Empty || Txt_Unit.Text == "" || Txt_Unit.Text == string.Empty || Txt_Stock.Text == "" || Txt_Stock.Text == string.Empty || Txt_Description.Text=="" || Txt_Description.Text ==string.Empty) 
                {
                    MessageBox.Show("Bu alanlar boş bırakılamaz", "Hata oluştu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    bgl.Open();
                    komut = new SqlCommand("INSERT INTO Productmanagment (Name,Type,Company,Price,Stock,Description) Values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl);
                    komut.Parameters.AddWithValue("@p1", Txt_Name.Text);
                    komut.Parameters.AddWithValue("@p2", comboBox2.Text);
                    komut.Parameters.AddWithValue("@p3", comboBox1.Text);
                    komut.Parameters.AddWithValue("@p4", Txt_Unit.Text);
                    komut.Parameters.AddWithValue("@p5", Txt_Stock.Text);
                    komut.Parameters.AddWithValue("@p6", Txt_Description.Text);
                    komut.ExecuteNonQuery();
                    bgl.Close();
                    MessageBox.Show("Kaydetme işlemi yapıldı.", "Kaydetme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.productmanagmentTableAdapter.Fill(this.marketmanagmentsystemDataSet.Productmanagment);
                }
            }
            catch
            {
                MessageBox.Show("Hatalı giriş yapıldı", "Hata oluştu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
   
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Name.Text == "" || Txt_Name.Text == string.Empty || Txt_Unit.Text == "" || Txt_Unit.Text == string.Empty || Txt_Stock.Text == "" || Txt_Stock.Text == string.Empty || Txt_Description.Text == "" || Txt_Description.Text == string.Empty)
                {
                    MessageBox.Show("Bu alanlar boş bırakılamaz", "Hata oluştu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    bgl.Open();

            komut = new SqlCommand("update Productmanagment set Name=@p1,Type=@p2,Company=@p3,Price=@p4,Stock=@p5,Description=@p6 where Id=@p7", bgl);

            komut.Parameters.AddWithValue("@p7", Txt_Id.Text);
            komut.Parameters.AddWithValue("@p1", Txt_Name.Text);
            komut.Parameters.AddWithValue("@p2", comboBox2.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4", Txt_Unit.Text);
            komut.Parameters.AddWithValue("@p5", Txt_Stock.Text);
            komut.Parameters.AddWithValue("@p6", Txt_Description.Text);
            komut.ExecuteNonQuery();
                    bgl.Close();
            MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti");
                    this.productmanagmentTableAdapter.Fill(this.marketmanagmentsystemDataSet.Productmanagment);
                }
            }
            catch
            {
                MessageBox.Show("Hatalı giriş yapıldı", "Hata oluştu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

            bgl.Open();

            SqlCommand komut = new SqlCommand("delete from Productmanagment where Id=@p1 ", bgl);

            komut.Parameters.AddWithValue("@p1", Txt_Id.Text);

            komut.ExecuteNonQuery();

            bgl.Close();
            MessageBox.Show(" Silme işlemi başarılı bir şekilde gerçekleşti");
            this.productmanagmentTableAdapter.Fill(this.marketmanagmentsystemDataSet.Productmanagment);
           
        }

        public void listele()
        {
            SqlCommand komut = new SqlCommand("Select * from Productmanagment", bgl);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Btn_Find_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * from Productmanagment where Id=@p1 ", bgl);
            komut.Parameters.AddWithValue("@p1", Txt_Id.Text);
             da = new SqlDataAdapter(komut);
             dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.productmanagmentTableAdapter.Fill(this.marketmanagmentsystemDataSet.Productmanagment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Datagridviewda tıklanılan değerleri textbpxa at. 
            Txt_Id .Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Txt_Name .Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1 .Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Txt_Unit .Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Txt_Stock.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Txt_Description.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }
    }
}
