using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Atestat_Andreiu_Dan
{
    public partial class Form2 : Form
    {
        public Form2 f2;
        public Form3 f3;
        public Form5 f5;
        public Form4 f4 = new Form4();
        static string folderName = Application.StartupPath;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + folderName + "\\Agentie de turism.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        int i = 0, dif_nume=41, dif_adresa = 66, dif_buton = 29, dif_poza = 41;
        TextBox[] t1 = new TextBox[25];
        Label[] nume = new Label[25];
        Label[] adresa = new Label[25];
        Button[] b1 = new Button[25];
        PictureBox[] poza = new PictureBox[25];
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT COUNT(*) FROM Hoteluri WHERE Locatie_ID = (SELECT ID FROM Locatii WHERE Locatie = '" + variabile.locatie + "')";
            variabile.numar_butoane = (int)cmd.ExecuteScalar();
            cmd.CommandText = "SELECT Hotel,Adresa,Hotel_ID FROM Hoteluri WHERE Locatie_ID = (SELECT ID FROM Locatii WHERE Locatie = '" + variabile.locatie + "')";
            rd = cmd.ExecuteReader();
            for (int a = 1; a <= variabile.numar_butoane; a++)
            {
                if (rd.Read())
                {
                    nume[i] = new Label();
                    nume[i].Location = new System.Drawing.Point(197, dif_nume);
                    nume[i].Size = new System.Drawing.Size(400, 25);
                    nume[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                    nume[i].Text = Convert.ToString(rd[0]);
                    adresa[i] = new Label();
                    adresa[i].Location = new System.Drawing.Point(197, dif_adresa);
                    adresa[i].Size = new System.Drawing.Size(400, 18);
                    adresa[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
                    adresa[i].Text = Convert.ToString(rd[1]);
                    b1[i] = new Button();
                    b1[i].Location = new System.Drawing.Point(0, dif_buton);
                    b1[i].Size = new System.Drawing.Size(849, 138);
                    b1[i].Name = Convert.ToString(rd[2]);
                    b1[i].Text = "";
                    b1[i].Padding = new Padding(0);
                    b1[i].Click += new System.EventHandler(this.button3_Click);
                    poza[i] = new PictureBox();
                    poza[i].Location = new System.Drawing.Point(12, dif_poza);
                    poza[i].Size = new System.Drawing.Size(179, 106);
                    poza[i].Image = Image.FromFile($@"{folderName}\Resources\Hoteluri\{b1[i].Name}\Poze\poza_{b1[i].Name}_1.jpg");
                    poza[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(b1[i]);
                    this.Controls.Add(nume[i]);
                    this.Controls.Add(adresa[i]);
                    this.Controls.Add(poza[i]);
                    this.Show();
                    this.Refresh();
                    nume[i].BringToFront();
                    adresa[i].BringToFront();
                    poza[i].BringToFront();
                    b1[i].BackColor = Color.AntiqueWhite;
                    nume[i].BackColor = Color.AntiqueWhite;
                    adresa[i].BackColor = Color.AntiqueWhite;
                    dif_buton = dif_buton + 144;
                    dif_adresa = dif_adresa + 144;
                    dif_nume = dif_nume + 144;
                    dif_poza = dif_poza + 144;
                    i++;
                }
            }
            con.Close();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cautareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Apasă 'Ieșire' pentru a opri programul sau 'Căutare' pentru a te întoarce la fereastra de căutare. Pentru informații despre program apasă 'About'.";
            string title = "Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button hotel = sender as Button;
            variabile.hotel_id = Convert.ToInt32(hotel.Name);
            f5 = new Form5();
            f5.f2 = this;
            f5.Show();
            this.Hide();
            
        }
    }
}
