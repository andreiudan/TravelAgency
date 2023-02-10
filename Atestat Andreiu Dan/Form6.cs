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
    public partial class Form6 : Form
    {
        public Form2 f2;
        static string folderName = Application.StartupPath;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + folderName + "\\Agentie de turism.accdb");
        OleDbCommand cmd = new OleDbCommand();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
            // TODO: This line of code loads data into the 'agentie_de_turismDataSet.Rezervari' table. You can move, or remove it, as needed.
            //this.rezervariTableAdapter.Fill(this.agentie_de_turismDataSet.Rezervari);

        }

        private void rezervariBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rezervariBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentie_de_turismDataSet);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.f4.Show();
        }

        private void cautareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.f5.Show();
            this.Hide();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Apasă 'Ieșire' pentru a opri programul sau 'Înapoi' pentru a reveni la fereastra cu informații. Pentru informații despre program apasă 'About'.";
            string title = "Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numeTextBox.Text == "" || prenumeTextBox.Text == "" || telefonTextBox.Text == "")
            {
                string message_error = "Nu ai introdus toate informațiile necesare pentru a efectua rezervarea.";
                string title_error = "Error";
                MessageBoxButtons buttons_error = MessageBoxButtons.OK;
                MessageBox.Show(message_error, title_error, buttons_error, MessageBoxIcon.Exclamation);
            }
            else
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Rezervari (Nume , Prenume , Telefon , Data_Sosirii , Data_Plecarii , Hotel_ID , Numar_Persoane , Numar_Camere) VALUES('" + numeTextBox.Text + "' , '" + prenumeTextBox.Text + "' , '" + telefonTextBox.Text + "' , '" + variabile.data_sosirii.Date + "' , '" + variabile.data_plecarii.Date + "' , " + variabile.hotel_id + " , " + variabile.numar_persoane + " , " + variabile.numar_camere + ")";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                con.Close();
                MessageBox.Show("Rezervarea a fost înregistrată!");
                this.Hide();
            }
        }
    }
}
