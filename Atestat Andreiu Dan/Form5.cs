using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Atestat_Andreiu_Dan
{
    public partial class Form5 : Form
    {
        public Form2 f2;
        private int image_number=1;
        static string folderName = Application.StartupPath;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + folderName + "\\Agentie de turism.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            button1.TabStop = false;
            cmd.Connection = con;
            label4.Text = File.ReadAllText($@"{folderName}\Resources\Hoteluri\" + variabile.hotel_id + "\\descriere_" + variabile.hotel_id + ".txt");
            label6.Text = File.ReadAllText($@"{folderName}\Resources\Hoteluri\" + variabile.hotel_id + "\\facilitati_" + variabile.hotel_id + ".txt");
            pictureBox1.Image = Image.FromFile($@"{folderName}\Resources\Hoteluri\" + variabile.hotel_id + "\\Poze\\poza_" + variabile.hotel_id + "_1.jpg");
            con.Open();
            cmd.CommandText = "SELECT Hotel,Adresa,Email,Telefon,Pret FROM Hoteluri WHERE Hotel_ID =" + variabile.hotel_id + "";
            rd = cmd.ExecuteReader();
            if (rd.Read() == true)
            {
                label1.Text = rd[0].ToString();
                label5.Text = rd[1].ToString();
                label11.Text = rd[2].ToString();
                label12.Text = rd[3].ToString();
                label8.Text = Convert.ToString(variabile.zile * variabile.numar_persoane * (int)rd[4]);
            }
            con.Close();
            timer1.Interval = 2500;
            timer1.Start();
        }

        private void changeImage()
        {
            if (image_number == 11)
            {
                image_number = 1;
            }
            pictureBox1.Image = Image.FromFile($@"{folderName}\Resources\Hoteluri\" + variabile.hotel_id + "\\Poze\\poza_" + variabile.hotel_id + "_" + image_number + ".jpg");
            image_number++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            changeImage();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.f4.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Apasă 'Ieșire' pentru a opri programul sau 'Înapoi' pentru a alege alt hotel. Pentru informații despre program apasă 'About'.";
            string title = "Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }

        private void cautareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
