using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlar_arası_geçiş
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void sifreBtn_Click(object sender, EventArgs e)
        {
            Form2 form2gecis = new Form2();
            if (txt_kadi.Text == "MUSTAFA KEMAL" && txt_sifre.Text == "ATATÜRK")
            {
                this.Hide();
                form2gecis.Show();
               
             
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış lütfen tekrar deneyiniz. ");

            }
         }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                
                txt_sifre.PasswordChar = '\0';
            }
            
            else
            {
                txt_sifre.PasswordChar = '/';
            }
        }
    }
}
