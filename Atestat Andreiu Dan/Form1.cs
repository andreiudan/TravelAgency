using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Atestat_Andreiu_Dan
{

    public partial class Form1 : Form
    {
        public Form3 f3 = new Form3();
        public Form4 f4 = new Form4();
        public Form1()
        {
            InitializeComponent();
            f3.f1 = this;
            f4.f1 = this;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Hide();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cautareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Apasă 'Ieșire' pentru a opri programul sau 'Căutare' pentru a căuta o locație. Pentru informații despre program apasă 'About'.";
            string title = "Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }
    }

    static class variabile
    {
        public static int zile;
        public static DateTime data_sosirii, data_plecarii;
        public static int numar_persoane = 1, numar_camere = 1;
        public static string locatie;
        public static int hotel_id, numar_butoane;
    }
}
