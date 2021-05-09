using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "turkhackteam")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();


            }

            else
            {
                MessageBox.Show("Türk Hack Team Üyesi Olmayanlar Giremez!");
                System.Diagnostics.Process.Start("www.turkhackteam.org");
            }
            }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
