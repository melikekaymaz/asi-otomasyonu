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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4gecis = new Form4();
          
            form4gecis.Show();
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3gecis = new Form3();
         
            form3gecis.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://covid19asi.saglik.gov.tr/?gclid=CjwKCAjwhYOFBhBkEiwASF3KGfu9hrXcSUbC60FUag3UobpinsllNlisUGuhiD2lUDhd9nmotjJQ9RoCSKwQAvD_BwE");
        }
    }
}
