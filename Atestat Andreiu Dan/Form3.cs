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
    public partial class Form3 : Form
    {
        public Form1 f1;
        public Form2 f2;
        static string folderName = Application.StartupPath;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + folderName + "\\Agentie de turism.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        public Form3()
        {
            InitializeComponent();
            data_SosiriiDateTimePicker.MinDate = data_SosiriiDateTimePicker.Value;
        }


        private void rezervariBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rezervariBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentie_de_turismDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Locatie FROM Locatii";
            rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                comboBox1.Items.Add(rd["Locatie"]);
            }
            con.Close();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void data_SosiriiDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            data_PlecariiDateTimePicker.MinDate = data_SosiriiDateTimePicker.Value.AddDays(1);
            data_PlecariiDateTimePicker.Visible = true;
            data_PlecariiDateTimePicker.Value = data_SosiriiDateTimePicker.Value.AddDays(1);
            label5.Visible = true;
            variabile.data_sosirii = data_SosiriiDateTimePicker.Value.Date;
            variabile.data_plecarii = data_PlecariiDateTimePicker.Value.Date;
            if (comboBox1.SelectedIndex > -1)
            {
                button1.Enabled = true;
                cautareToolStripMenuItem.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label3.Visible = true;
                numericUpDown2.Visible = true;
                numericUpDown2.Value = 1;
            }
            else
            {
                label3.Visible = false;
                numericUpDown2.Visible = false;
                numericUpDown2.Value = 0;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.f4.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Apasă 'Ieșire' pentru a opri programul sau 'Căutare' pentru a căuta după ce ai ales locația și data. Pentru informații despre program apasă 'About'.";
            string title = "Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(data_PlecariiDateTimePicker.Visible == true)
            {
                button1.Enabled = true;
                cautareToolStripMenuItem.Enabled = true;
            }
            variabile.locatie = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void cautareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void data_PlecariiDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            variabile.data_plecarii = data_PlecariiDateTimePicker.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            variabile.numar_persoane = (int)numericUpDown1.Value + (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            variabile.numar_camere = (int)numericUpDown3.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            variabile.numar_persoane = (int)numericUpDown1.Value + (int)numericUpDown2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.TimeSpan ts = new TimeSpan(variabile.data_plecarii.Ticks - variabile.data_sosirii.Ticks);
            variabile.zile = Convert.ToInt32(ts.Days);
            f2 = new Form2();
            f2.f3 = this;
            f2.Show();
            this.Hide();
        }
    }
}
