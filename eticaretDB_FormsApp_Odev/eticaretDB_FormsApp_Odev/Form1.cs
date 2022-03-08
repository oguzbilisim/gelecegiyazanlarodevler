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

namespace eticaretDB_FormsApp_Odev
{
    public partial class Form1 : Form
    {
       
        
      


        public Form1()
        {
            InitializeComponent();

        }

        SqlConnection baglanti;
        SqlDataAdapter sda;
        SqlCommand scm;
        DataSet ds;


       public void doldur()
        {
            baglanti = new SqlConnection(@"Data Source=CINKAYA;Initial Catalog=eticaretDB;Integrated Security=True");
            sda = new SqlDataAdapter("select *From Araba", baglanti);
            ds = new DataSet();
            baglanti.Open();
            sda.Fill(ds, "Araba");
            dataGridView1.DataSource = ds.Tables["Araba"];
            baglanti.Close();
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            doldur();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            scm = new SqlCommand();
            scm.Connection = baglanti;
            scm.CommandText = "insert into Araba(ArabaID,Marka,Model,Yil,KategoriID,Km) values ('" + textBox1.Text+"','"+textBox2.Text+"','" +textBox3.Text +"','" + textBox4.Text+ "','" + textBox5.Text + "','" + textBox6.Text + "')";
            scm.ExecuteNonQuery();
            baglanti.Close();
            doldur();

            MessageBox.Show("Başarıyla eklendi");
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            scm = new SqlCommand();
            scm.Connection = baglanti;
            scm.CommandText = "delete from Araba where ArabaID=" + textBox1.Text+"";
            scm.ExecuteNonQuery();
            baglanti.Close();
            doldur();
            MessageBox.Show("Başarıyla silindi");
        }
    }
}
