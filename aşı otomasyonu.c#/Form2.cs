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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string ad1;

        private void Form2_Load(object sender, EventArgs e)
        {
           /* listView1.View= View.Details;
            listView1.FullRowSelect= true;
            listView1.Columns.Add("Ad Soyad",150);
            listView1.Columns.Add("aşi seçimi",150);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kontrol.Items.Add( Form3.doktoragiden.ToString()+" - "+ Form3.doktoragiden2.ToString());
         
            listBox1.Items.Add(Form3.doktoragiden3.ToString()+" - "+Form3.doktoragiden6.ToString());
            listBox2.Items.Add(Form3.doktoragiden4.ToString() + " - "+Form3.doktoragiden5.ToString() );
            
       








        }
    }
}
