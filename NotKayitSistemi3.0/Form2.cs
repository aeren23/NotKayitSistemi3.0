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
using System.Data.SqlClient;

namespace NotKayitSistemi3._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string number;
        SqlConnection baglanti = new SqlConnection("SQL_Server_Name");

        private void Form2_Load(object sender, EventArgs e)
        {
            label15.Text = number;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLDERS WHERE OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", number);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label9.Text = dr[2].ToString() + " " + dr[3].ToString();
                label6.Text = dr[4].ToString();
                label7.Text = dr[5].ToString();
                label8.Text = dr[6].ToString();
                label12.Text = dr[7].ToString();
                label14.Text = dr[8].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
