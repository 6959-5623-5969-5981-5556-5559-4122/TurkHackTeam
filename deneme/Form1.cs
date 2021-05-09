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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
        }
        Form2 fr;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                MessageBox.Show("Program hatasız çalışıyor");
            }
            catch
            {
                MessageBox.Show("Programda bilinmeyen bir arıza bulunmaktadır.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Kodlamaya Hoşgeldin!");

            int x = 232456;
            int y = 35256;
            int z = 257223;
            MessageBox.Show(x.ToString(),"X Sayısı: ");
            MessageBox.Show(y.ToString(),"Y Sayısı: ");
            MessageBox.Show(z.ToString(),"Z Sayısı: ");
            button19.Enabled = false;
            button17.Enabled = false;
            trackBar1.Minimum = 20;
            trackBar1.Maximum = 150;
            notifyIcon1.ShowBalloonTip(1000, "Türk Hack Team", "Sisteme Girmiş Bulunmaktasınız!", ToolTipIcon.Info);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string
            
                Topla = textBox2.Text + textBox3.Text;

            MessageBox.Show(Topla);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = textBox4.Text;
            string str2 = str.Substring(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));

            MessageBox.Show(str2);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Width = Convert.ToInt32(textBox7.Text);
            this.Height = Convert.ToInt32(textBox8.Text);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int sayi = r.Next(100, 1000);

            MessageBox.Show("Random Sayı = " + sayi);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button15.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button14.Enabled = true;
            button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            button17.Enabled = true;
            timer1.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            button17.Enabled = false;
                timer1.Stop();

        }
        string mtamodding = "mtamodding.blogspot.com";
        private void timer1_Tick(object sender, EventArgs e)
        {
            mtamodding = mtamodding.Substring(1) + mtamodding.Substring(0, 1);
            label12.Text = mtamodding;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label13.Text = label13.Text.Insert(0, "www.");
            //0. karakterden sonra ekle
            label13.Text = label13.Text.Insert(14, ".blogspot.com");
            //11. karakterden sonra ekle
            button18.Enabled = false;
            button19.Enabled = true;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            label13.Text = label13.Text.Remove(0, 4);
            // 0. karakterden sonra 4 tane karakter sil
            label13.Text = label13.Text.Remove(10, 13);
            // 14. karakterden sonra 13 tane karakteri sil
            button18.Enabled = true;
            button19.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox9.Text.ToUpper());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox9.Text.ToLower());
        }

        private void button22_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox10.Text = openFileDialog1.FileName;
            label17.Text = openFileDialog1.SafeFileName;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            DialogResult cik;

            cik = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (cik==DialogResult.Yes)
            {
                MessageBox.Show("Çıkış Başarılı!");
                Close();
            }
            if (cik==DialogResult.No)
            {
                MessageBox.Show("Çıkış Başarısız!");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                MessageBox.Show("Yazı yazıp tekrar deneyiniz!");
            }
            listBox1.Items.Add(textBox11.Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            for (int i = 0; i <= 200;i++)
            {
                progressBar1.Value = i;
            }
            
        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            button42.Height = trackBar1.Value;
            button42.Width = trackBar1.Value;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Form2();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Zaten Yeni Sayfa Açık");
            }
        }
    }
}
