using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKayitSistemi3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }
            else
            {
                Form2 frm = new Form2();
                frm.number = maskedTextBox1.Text;
                frm.Show();
                this.Hide();
            }
        }
    }
}
