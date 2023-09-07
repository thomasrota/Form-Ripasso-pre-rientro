namespace Form_Ripasso_pre_rientro
{
    partial class FormVisualizzazione
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
			this.panelCancellazioneContent = new System.Windows.Forms.Panel();
			this.panelTitleCancellazione = new System.Windows.Forms.Panel();
			this.TitleVisualizza = new System.Windows.Forms.Label();
			this.listViewVisualizza = new System.Windows.Forms.ListView();
			this.panelContentVisualizza = new System.Windows.Forms.Panel();
			this.checkBoxMunicipio = new System.Windows.Forms.CheckBox();
			this.checkBoxZoneUrbane = new System.Windows.Forms.CheckBox();
			this.checkBoxRione = new System.Windows.Forms.CheckBox();
			this.checkBoxQuartiere = new System.Windows.Forms.CheckBox();
			this.checkBoxSubUrbio = new System.Windows.Forms.CheckBox();
			this.checkBoxZoneAgro = new System.Windows.Forms.CheckBox();
			this.checkBoxBorgate = new System.Windows.Forms.CheckBox();
			this.checkBoxExMunicipi = new System.Windows.Forms.CheckBox();
			this.checkBoxEtichetta = new System.Windows.Forms.CheckBox();
			this.checkBoxMioValore = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelCancellazioneContent.SuspendLayout();
			this.panelTitleCancellazione.SuspendLayout();
			this.panelContentVisualizza.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelCancellazioneContent
			// 
			this.panelCancellazioneContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(181)))), ((int)(((byte)(159)))));
			this.panelCancellazioneContent.Controls.Add(this.panelContentVisualizza);
			this.panelCancellazioneContent.Controls.Add(this.listViewVisualizza);
			this.panelCancellazioneContent.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelCancellazioneContent.Location = new System.Drawing.Point(0, 0);
			this.panelCancellazioneContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelCancellazioneContent.Name = "panelCancellazioneContent";
			this.panelCancellazioneContent.Size = new System.Drawing.Size(719, 498);
			this.panelCancellazioneContent.TabIndex = 11;
			// 
			// panelTitleCancellazione
			// 
			this.panelTitleCancellazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(142)))));
			this.panelTitleCancellazione.Controls.Add(this.TitleVisualizza);
			this.panelTitleCancellazione.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleCancellazione.Location = new System.Drawing.Point(0, 0);
			this.panelTitleCancellazione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelTitleCancellazione.Name = "panelTitleCancellazione";
			this.panelTitleCancellazione.Size = new System.Drawing.Size(719, 52);
			this.panelTitleCancellazione.TabIndex = 10;
			// 
			// TitleVisualizza
			// 
			this.TitleVisualizza.AutoSize = true;
			this.TitleVisualizza.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleVisualizza.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.TitleVisualizza.Location = new System.Drawing.Point(284, 11);
			this.TitleVisualizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TitleVisualizza.Name = "TitleVisualizza";
			this.TitleVisualizza.Size = new System.Drawing.Size(139, 28);
			this.TitleVisualizza.TabIndex = 0;
			this.TitleVisualizza.Text = "Visualizza";
			// 
			// listViewVisualizza
			// 
			this.listViewVisualizza.HideSelection = false;
			this.listViewVisualizza.Location = new System.Drawing.Point(253, 20);
			this.listViewVisualizza.Name = "listViewVisualizza";
			this.listViewVisualizza.Size = new System.Drawing.Size(463, 460);
			this.listViewVisualizza.TabIndex = 0;
			this.listViewVisualizza.UseCompatibleStateImageBehavior = false;
			// 
			// panelContentVisualizza
			// 
			this.panelContentVisualizza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelContentVisualizza.Controls.Add(this.label1);
			this.panelContentVisualizza.Controls.Add(this.checkBoxMioValore);
			this.panelContentVisualizza.Controls.Add(this.checkBoxEtichetta);
			this.panelContentVisualizza.Controls.Add(this.checkBoxExMunicipi);
			this.panelContentVisualizza.Controls.Add(this.checkBoxBorgate);
			this.panelContentVisualizza.Controls.Add(this.checkBoxZoneAgro);
			this.panelContentVisualizza.Controls.Add(this.checkBoxSubUrbio);
			this.panelContentVisualizza.Controls.Add(this.checkBoxQuartiere);
			this.panelContentVisualizza.Controls.Add(this.checkBoxRione);
			this.panelContentVisualizza.Controls.Add(this.checkBoxZoneUrbane);
			this.panelContentVisualizza.Controls.Add(this.checkBoxMunicipio);
			this.panelContentVisualizza.Location = new System.Drawing.Point(13, 20);
			this.panelContentVisualizza.Name = "panelContentVisualizza";
			this.panelContentVisualizza.Size = new System.Drawing.Size(234, 460);
			this.panelContentVisualizza.TabIndex = 1;
			// 
			// checkBoxMunicipio
			// 
			this.checkBoxMunicipio.AutoSize = true;
			this.checkBoxMunicipio.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxMunicipio.Location = new System.Drawing.Point(26, 71);
			this.checkBoxMunicipio.Name = "checkBoxMunicipio";
			this.checkBoxMunicipio.Size = new System.Drawing.Size(119, 25);
			this.checkBoxMunicipio.TabIndex = 0;
			this.checkBoxMunicipio.Text = "Municipio";
			this.checkBoxMunicipio.UseVisualStyleBackColor = true;
			this.checkBoxMunicipio.Click += new System.EventHandler(this.checkBoxMunicipio_Click);
			// 
			// checkBoxZoneUrbane
			// 
			this.checkBoxZoneUrbane.AutoSize = true;
			this.checkBoxZoneUrbane.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxZoneUrbane.Location = new System.Drawing.Point(26, 98);
			this.checkBoxZoneUrbane.Name = "checkBoxZoneUrbane";
			this.checkBoxZoneUrbane.Size = new System.Drawing.Size(145, 25);
			this.checkBoxZoneUrbane.TabIndex = 1;
			this.checkBoxZoneUrbane.Text = "Zone Urbane";
			this.checkBoxZoneUrbane.UseVisualStyleBackColor = true;
			this.checkBoxZoneUrbane.Click += new System.EventHandler(this.checkBoxZoneUrbane_Click);
			// 
			// checkBoxRione
			// 
			this.checkBoxRione.AutoSize = true;
			this.checkBoxRione.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxRione.Location = new System.Drawing.Point(26, 129);
			this.checkBoxRione.Name = "checkBoxRione";
			this.checkBoxRione.Size = new System.Drawing.Size(82, 25);
			this.checkBoxRione.TabIndex = 2;
			this.checkBoxRione.Text = "Rione";
			this.checkBoxRione.UseVisualStyleBackColor = true;
			this.checkBoxRione.Click += new System.EventHandler(this.checkBoxRione_Click);
			// 
			// checkBoxQuartiere
			// 
			this.checkBoxQuartiere.AutoSize = true;
			this.checkBoxQuartiere.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxQuartiere.Location = new System.Drawing.Point(26, 160);
			this.checkBoxQuartiere.Name = "checkBoxQuartiere";
			this.checkBoxQuartiere.Size = new System.Drawing.Size(119, 25);
			this.checkBoxQuartiere.TabIndex = 3;
			this.checkBoxQuartiere.Text = "Quartiere";
			this.checkBoxQuartiere.UseVisualStyleBackColor = true;
			this.checkBoxQuartiere.Click += new System.EventHandler(this.checkBoxQuartiere_Click);
			// 
			// checkBoxSubUrbio
			// 
			this.checkBoxSubUrbio.AutoSize = true;
			this.checkBoxSubUrbio.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxSubUrbio.Location = new System.Drawing.Point(26, 191);
			this.checkBoxSubUrbio.Name = "checkBoxSubUrbio";
			this.checkBoxSubUrbio.Size = new System.Drawing.Size(121, 25);
			this.checkBoxSubUrbio.TabIndex = 4;
			this.checkBoxSubUrbio.Text = "Sub Urbio";
			this.checkBoxSubUrbio.UseVisualStyleBackColor = true;
			this.checkBoxSubUrbio.Click += new System.EventHandler(this.checkBoxSubUrbio_Click);
			// 
			// checkBoxZoneAgro
			// 
			this.checkBoxZoneAgro.AutoSize = true;
			this.checkBoxZoneAgro.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxZoneAgro.Location = new System.Drawing.Point(26, 222);
			this.checkBoxZoneAgro.Name = "checkBoxZoneAgro";
			this.checkBoxZoneAgro.Size = new System.Drawing.Size(122, 25);
			this.checkBoxZoneAgro.TabIndex = 5;
			this.checkBoxZoneAgro.Text = "Zone Agro";
			this.checkBoxZoneAgro.UseVisualStyleBackColor = true;
			this.checkBoxZoneAgro.Click += new System.EventHandler(this.checkBoxZoneAgro_Click);
			// 
			// checkBoxBorgate
			// 
			this.checkBoxBorgate.AutoSize = true;
			this.checkBoxBorgate.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxBorgate.Location = new System.Drawing.Point(26, 253);
			this.checkBoxBorgate.Name = "checkBoxBorgate";
			this.checkBoxBorgate.Size = new System.Drawing.Size(102, 25);
			this.checkBoxBorgate.TabIndex = 6;
			this.checkBoxBorgate.Text = "Borgate";
			this.checkBoxBorgate.UseVisualStyleBackColor = true;
			this.checkBoxBorgate.Click += new System.EventHandler(this.checkBoxBorgate_Click);
			// 
			// checkBoxExMunicipi
			// 
			this.checkBoxExMunicipi.AutoSize = true;
			this.checkBoxExMunicipi.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxExMunicipi.Location = new System.Drawing.Point(26, 284);
			this.checkBoxExMunicipi.Name = "checkBoxExMunicipi";
			this.checkBoxExMunicipi.Size = new System.Drawing.Size(138, 25);
			this.checkBoxExMunicipi.TabIndex = 7;
			this.checkBoxExMunicipi.Text = "Ex Municipi";
			this.checkBoxExMunicipi.UseVisualStyleBackColor = true;
			this.checkBoxExMunicipi.Click += new System.EventHandler(this.checkBoxExMunicipi_Click);
			// 
			// checkBoxEtichetta
			// 
			this.checkBoxEtichetta.AutoSize = true;
			this.checkBoxEtichetta.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxEtichetta.Location = new System.Drawing.Point(26, 315);
			this.checkBoxEtichetta.Name = "checkBoxEtichetta";
			this.checkBoxEtichetta.Size = new System.Drawing.Size(115, 25);
			this.checkBoxEtichetta.TabIndex = 8;
			this.checkBoxEtichetta.Text = "Etichetta";
			this.checkBoxEtichetta.UseVisualStyleBackColor = true;
			this.checkBoxEtichetta.Click += new System.EventHandler(this.checkBoxEtichetta_Click);
			// 
			// checkBoxMioValore
			// 
			this.checkBoxMioValore.AutoSize = true;
			this.checkBoxMioValore.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxMioValore.Location = new System.Drawing.Point(26, 346);
			this.checkBoxMioValore.Name = "checkBoxMioValore";
			this.checkBoxMioValore.Size = new System.Drawing.Size(129, 25);
			this.checkBoxMioValore.TabIndex = 9;
			this.checkBoxMioValore.Text = "Mio Valore";
			this.checkBoxMioValore.UseVisualStyleBackColor = true;
			this.checkBoxMioValore.Click += new System.EventHandler(this.checkBoxMioValore_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Selezione campi";
			// 
			// FormVisualizzazione
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 498);
			this.Controls.Add(this.panelTitleCancellazione);
			this.Controls.Add(this.panelCancellazioneContent);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormVisualizzazione";
			this.Text = "FormVisualizzazione";
			this.Load += new System.EventHandler(this.FormVisualizzazione_Load);
			this.panelCancellazioneContent.ResumeLayout(false);
			this.panelTitleCancellazione.ResumeLayout(false);
			this.panelTitleCancellazione.PerformLayout();
			this.panelContentVisualizza.ResumeLayout(false);
			this.panelContentVisualizza.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCancellazioneContent;
        private System.Windows.Forms.Panel panelTitleCancellazione;
        private System.Windows.Forms.Label TitleVisualizza;
		private System.Windows.Forms.ListView listViewVisualizza;
		private System.Windows.Forms.Panel panelContentVisualizza;
		private System.Windows.Forms.CheckBox checkBoxMunicipio;
		private System.Windows.Forms.CheckBox checkBoxZoneUrbane;
		private System.Windows.Forms.CheckBox checkBoxEtichetta;
		private System.Windows.Forms.CheckBox checkBoxExMunicipi;
		private System.Windows.Forms.CheckBox checkBoxBorgate;
		private System.Windows.Forms.CheckBox checkBoxZoneAgro;
		private System.Windows.Forms.CheckBox checkBoxSubUrbio;
		private System.Windows.Forms.CheckBox checkBoxQuartiere;
		private System.Windows.Forms.CheckBox checkBoxRione;
		private System.Windows.Forms.CheckBox checkBoxMioValore;
		private System.Windows.Forms.Label label1;
	}
}