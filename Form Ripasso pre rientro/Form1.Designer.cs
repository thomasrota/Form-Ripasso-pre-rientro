namespace Form_Ripasso_pre_rientro
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonCancLogica = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.buttonRicerca = new System.Windows.Forms.Button();
            this.buttonVisualizza = new System.Windows.Forms.Button();
            this.buttonAggRecord = new System.Windows.Forms.Button();
            this.buttonLunghezzaRC = new System.Windows.Forms.Button();
            this.buttonContaCampi = new System.Windows.Forms.Button();
            this.buttonAggMyValue = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeftMenu.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.Title.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.panelLeftMenu.Controls.Add(this.panelButtons);
            this.panelLeftMenu.Controls.Add(this.Title);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(245, 444);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.panelButtons.Controls.Add(this.buttonCancLogica);
            this.panelButtons.Controls.Add(this.buttonModifica);
            this.panelButtons.Controls.Add(this.buttonRicerca);
            this.panelButtons.Controls.Add(this.buttonVisualizza);
            this.panelButtons.Controls.Add(this.buttonAggRecord);
            this.panelButtons.Controls.Add(this.buttonLunghezzaRC);
            this.panelButtons.Controls.Add(this.buttonContaCampi);
            this.panelButtons.Controls.Add(this.buttonAggMyValue);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 81);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(245, 363);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonCancLogica
            // 
            this.buttonCancLogica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.buttonCancLogica.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCancLogica.FlatAppearance.BorderSize = 0;
            this.buttonCancLogica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancLogica.Location = new System.Drawing.Point(0, 238);
            this.buttonCancLogica.Name = "buttonCancLogica";
            this.buttonCancLogica.Size = new System.Drawing.Size(245, 34);
            this.buttonCancLogica.TabIndex = 8;
            this.buttonCancLogica.Text = "Cancellazione";
            this.buttonCancLogica.UseVisualStyleBackColor = false;
            this.buttonCancLogica.Click += new System.EventHandler(this.buttonCancLogica_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.buttonModifica.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonModifica.FlatAppearance.BorderSize = 0;
            this.buttonModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifica.Location = new System.Drawing.Point(0, 204);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(245, 34);
            this.buttonModifica.TabIndex = 7;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.UseVisualStyleBackColor = false;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // buttonRicerca
            // 
            this.buttonRicerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.buttonRicerca.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRicerca.FlatAppearance.BorderSize = 0;
            this.buttonRicerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRicerca.Location = new System.Drawing.Point(0, 170);
            this.buttonRicerca.Name = "buttonRicerca";
            this.buttonRicerca.Size = new System.Drawing.Size(245, 34);
            this.buttonRicerca.TabIndex = 6;
            this.buttonRicerca.Text = "Ricerca";
            this.buttonRicerca.UseVisualStyleBackColor = false;
            this.buttonRicerca.Click += new System.EventHandler(this.buttonRicerca_Click);
            // 
            // buttonVisualizza
            // 
            this.buttonVisualizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.buttonVisualizza.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVisualizza.FlatAppearance.BorderSize = 0;
            this.buttonVisualizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisualizza.Location = new System.Drawing.Point(0, 136);
            this.buttonVisualizza.Name = "buttonVisualizza";
            this.buttonVisualizza.Size = new System.Drawing.Size(245, 34);
            this.buttonVisualizza.TabIndex = 5;
            this.buttonVisualizza.Text = "Visualizza";
            this.buttonVisualizza.UseVisualStyleBackColor = false;
            this.buttonVisualizza.Click += new System.EventHandler(this.buttonVisualizza_Click);
            // 
            // buttonAggRecord
            // 
            this.buttonAggRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.buttonAggRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAggRecord.FlatAppearance.BorderSize = 0;
            this.buttonAggRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAggRecord.Location = new System.Drawing.Point(0, 102);
            this.buttonAggRecord.Name = "buttonAggRecord";
            this.buttonAggRecord.Size = new System.Drawing.Size(245, 34);
            this.buttonAggRecord.TabIndex = 4;
            this.buttonAggRecord.Text = "Aggiunta record in coda";
            this.buttonAggRecord.UseVisualStyleBackColor = false;
            this.buttonAggRecord.Click += new System.EventHandler(this.buttonAggRecord_Click);
            // 
            // buttonLunghezzaRC
            // 
            this.buttonLunghezzaRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.buttonLunghezzaRC.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLunghezzaRC.FlatAppearance.BorderSize = 0;
            this.buttonLunghezzaRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLunghezzaRC.Location = new System.Drawing.Point(0, 68);
            this.buttonLunghezzaRC.Name = "buttonLunghezzaRC";
            this.buttonLunghezzaRC.Size = new System.Drawing.Size(245, 34);
            this.buttonLunghezzaRC.TabIndex = 3;
            this.buttonLunghezzaRC.Text = "Lunghezza record / campi";
            this.buttonLunghezzaRC.UseVisualStyleBackColor = false;
            this.buttonLunghezzaRC.Click += new System.EventHandler(this.buttonLunghezzaRC_Click);
            // 
            // buttonContaCampi
            // 
            this.buttonContaCampi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.buttonContaCampi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonContaCampi.FlatAppearance.BorderSize = 0;
            this.buttonContaCampi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContaCampi.Location = new System.Drawing.Point(0, 34);
            this.buttonContaCampi.Name = "buttonContaCampi";
            this.buttonContaCampi.Size = new System.Drawing.Size(245, 34);
            this.buttonContaCampi.TabIndex = 2;
            this.buttonContaCampi.Text = "Conta campi";
            this.buttonContaCampi.UseVisualStyleBackColor = false;
            this.buttonContaCampi.Click += new System.EventHandler(this.buttonContaCampi_Click);
            // 
            // buttonAggMyValue
            // 
            this.buttonAggMyValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.buttonAggMyValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAggMyValue.FlatAppearance.BorderSize = 0;
            this.buttonAggMyValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAggMyValue.Location = new System.Drawing.Point(0, 0);
            this.buttonAggMyValue.Name = "buttonAggMyValue";
            this.buttonAggMyValue.Size = new System.Drawing.Size(245, 34);
            this.buttonAggMyValue.TabIndex = 1;
            this.buttonAggMyValue.Text = "Aggiungi \'Mio valore\'";
            this.buttonAggMyValue.UseVisualStyleBackColor = false;
            this.buttonAggMyValue.Click += new System.EventHandler(this.buttonAggMyValue_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.Title.Controls.Add(this.label1);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(245, 90);
            this.Title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mappa dei municipi di Roma";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(251, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.pictureBox1);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(245, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(555, 444);
            this.panelInput.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Form_Ripasso_pre_rientro.Properties.Resources.mmdr;
            this.pictureBox1.Location = new System.Drawing.Point(182, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 166);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelLeftMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 483);
            this.MinimumSize = new System.Drawing.Size(816, 483);
            this.Name = "Form1";
            this.Text = "ROMA CAPITALE - MAPPA DEI MUNICIPI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.Title.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAggMyValue;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAggRecord;
        private System.Windows.Forms.Button buttonLunghezzaRC;
        private System.Windows.Forms.Button buttonContaCampi;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.Button buttonRicerca;
        private System.Windows.Forms.Button buttonVisualizza;
        private System.Windows.Forms.Button buttonCancLogica;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

