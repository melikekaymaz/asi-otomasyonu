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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static string doktoragiden = "";
        public static string doktoragiden2 = "";
        public static string doktoragiden3 = "";
        public static string doktoragiden4 = "";
        public static string doktoragiden5 = "";
        public static string doktoragiden6 = "";

        private void button1_Click(object sender, EventArgs e)
        {
            tarih.Items.Add (dateTimePicker1.Text+" - "+dateTimePicker2.Text);
            Random rnd = new Random();
          
            string metin = textBox1.Text;
           
            textBox1.Text="";

            string tc = textBox2.Text;

            textBox2.Text = "";
            ad.Items.Add( metin+" - "+ tc );
           
            asi.Items.Add(comboBox1.Text + " - " + rnd.Next(87654, 98764).ToString());

            doktoragiden = metin;
            doktoragiden2 =tc;
            doktoragiden3 = dateTimePicker1.Text;
            doktoragiden4 =  comboBox1.Text;
            doktoragiden5 = rnd.Next(87654, 98764).ToString();
            doktoragiden6 = dateTimePicker2.Text;
            Form2 frm2 = new Form2() ;

            frm2.Show();
            frm2.Hide();

            




        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("BioNTech");
            comboBox1.Items.Add("Sinovak");
            comboBox1.Items.Add("Sputnik");

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }

