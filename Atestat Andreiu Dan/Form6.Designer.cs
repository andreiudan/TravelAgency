namespace Atestat_Andreiu_Dan
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label telefonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentie_de_turismDataSet = new Atestat_Andreiu_Dan.Agentie_de_turismDataSet();
            this.rezervariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervariTableAdapter = new Atestat_Andreiu_Dan.Agentie_de_turismDataSetTableAdapters.RezervariTableAdapter();
            this.tableAdapterManager = new Atestat_Andreiu_Dan.Agentie_de_turismDataSetTableAdapters.TableAdapterManager();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentie_de_turismDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.BackColor = System.Drawing.Color.Transparent;
            numeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            numeLabel.Location = new System.Drawing.Point(154, 131);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(52, 18);
            numeLabel.TabIndex = 26;
            numeLabel.Text = "Nume:";
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.BackColor = System.Drawing.Color.Transparent;
            prenumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            prenumeLabel.Location = new System.Drawing.Point(154, 159);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(72, 18);
            prenumeLabel.TabIndex = 27;
            prenumeLabel.Text = "Prenume:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.BackColor = System.Drawing.Color.Transparent;
            telefonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            telefonLabel.Location = new System.Drawing.Point(154, 188);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(61, 18);
            telefonLabel.TabIndex = 28;
            telefonLabel.Text = "Telefon:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(141, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rezervă";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(407, 25);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cautareToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.fileToolStripMenuItem.Text = "&Menu";
            // 
            // cautareToolStripMenuItem
            // 
            this.cautareToolStripMenuItem.Name = "cautareToolStripMenuItem";
            this.cautareToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.cautareToolStripMenuItem.Text = "Înapoi";
            this.cautareToolStripMenuItem.Click += new System.EventHandler(this.cautareToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.iesireToolStripMenuItem.Text = "&Ieșire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // agentie_de_turismDataSet
            // 
            this.agentie_de_turismDataSet.DataSetName = "Agentie_de_turismDataSet";
            this.agentie_de_turismDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervariBindingSource
            // 
            this.rezervariBindingSource.DataMember = "Rezervari";
            this.rezervariBindingSource.DataSource = this.agentie_de_turismDataSet;
            // 
            // rezervariTableAdapter
            // 
            this.rezervariTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CamereTableAdapter = null;
            this.tableAdapterManager.HoteluriTableAdapter = null;
            this.tableAdapterManager.LocatiiTableAdapter = null;
            this.tableAdapterManager.RezervariTableAdapter = this.rezervariTableAdapter;
            this.tableAdapterManager.UpdateOrder = Atestat_Andreiu_Dan.Agentie_de_turismDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervariBindingSource, "Nume", true));
            this.numeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numeTextBox.Location = new System.Drawing.Point(258, 129);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 24);
            this.numeTextBox.TabIndex = 27;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervariBindingSource, "Prenume", true));
            this.prenumeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prenumeTextBox.Location = new System.Drawing.Point(258, 159);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(100, 24);
            this.prenumeTextBox.TabIndex = 28;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervariBindingSource, "Telefon", true));
            this.telefonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonTextBox.Location = new System.Drawing.Point(258, 189);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 24);
            this.telefonTextBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(136, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Rezervări";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 396);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traveler";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentie_de_turismDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Agentie_de_turismDataSet agentie_de_turismDataSet;
        private System.Windows.Forms.BindingSource rezervariBindingSource;
        private Agentie_de_turismDataSetTableAdapters.RezervariTableAdapter rezervariTableAdapter;
        private Agentie_de_turismDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Label label1;
    }
}