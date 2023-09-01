namespace Form_Ripasso_pre_rientro
{
    partial class FormRicerca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRicerca));
            this.panelTitleRicerca = new System.Windows.Forms.Panel();
            this.TitleRicerca = new System.Windows.Forms.Label();
            this.textBoxSearchMunicipio = new System.Windows.Forms.TextBox();
            this.labelMunicipio = new System.Windows.Forms.Label();
            this.panelRicercaMunicipio = new System.Windows.Forms.Panel();
            this.panelContentRicerca = new System.Windows.Forms.Panel();
            this.panelSearchResult = new System.Windows.Forms.Panel();
            this.labelSearchResult = new System.Windows.Forms.Label();
            this.buttonRicerca = new System.Windows.Forms.Button();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.panelTitleRicerca.SuspendLayout();
            this.panelRicercaMunicipio.SuspendLayout();
            this.panelContentRicerca.SuspendLayout();
            this.panelSearchResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleRicerca
            // 
            this.panelTitleRicerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(142)))));
            this.panelTitleRicerca.Controls.Add(this.TitleRicerca);
            this.panelTitleRicerca.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleRicerca.Location = new System.Drawing.Point(0, 0);
            this.panelTitleRicerca.Name = "panelTitleRicerca";
            this.panelTitleRicerca.Size = new System.Drawing.Size(539, 42);
            this.panelTitleRicerca.TabIndex = 0;
            // 
            // TitleRicerca
            // 
            this.TitleRicerca.AutoSize = true;
            this.TitleRicerca.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleRicerca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleRicerca.Location = new System.Drawing.Point(244, 10);
            this.TitleRicerca.Name = "TitleRicerca";
            this.TitleRicerca.Size = new System.Drawing.Size(82, 23);
            this.TitleRicerca.TabIndex = 0;
            this.TitleRicerca.Text = "Ricerca";
            // 
            // textBoxSearchMunicipio
            // 
            this.textBoxSearchMunicipio.Location = new System.Drawing.Point(17, 49);
            this.textBoxSearchMunicipio.Name = "textBoxSearchMunicipio";
            this.textBoxSearchMunicipio.Size = new System.Drawing.Size(195, 20);
            this.textBoxSearchMunicipio.TabIndex = 1;
            // 
            // labelMunicipio
            // 
            this.labelMunicipio.AutoSize = true;
            this.labelMunicipio.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMunicipio.Location = new System.Drawing.Point(74, 12);
            this.labelMunicipio.Name = "labelMunicipio";
            this.labelMunicipio.Size = new System.Drawing.Size(88, 18);
            this.labelMunicipio.TabIndex = 0;
            this.labelMunicipio.Text = "Municipio";
            // 
            // panelRicercaMunicipio
            // 
            this.panelRicercaMunicipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.panelRicercaMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRicercaMunicipio.Controls.Add(this.textBoxSearchMunicipio);
            this.panelRicercaMunicipio.Controls.Add(this.labelMunicipio);
            this.panelRicercaMunicipio.Location = new System.Drawing.Point(36, 31);
            this.panelRicercaMunicipio.Name = "panelRicercaMunicipio";
            this.panelRicercaMunicipio.Size = new System.Drawing.Size(232, 83);
            this.panelRicercaMunicipio.TabIndex = 0;
            // 
            // panelContentRicerca
            // 
            this.panelContentRicerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(181)))), ((int)(((byte)(159)))));
            this.panelContentRicerca.Controls.Add(this.panelSearchResult);
            this.panelContentRicerca.Controls.Add(this.buttonRicerca);
            this.panelContentRicerca.Controls.Add(this.panelRicercaMunicipio);
            this.panelContentRicerca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContentRicerca.Location = new System.Drawing.Point(0, 0);
            this.panelContentRicerca.Name = "panelContentRicerca";
            this.panelContentRicerca.Size = new System.Drawing.Size(539, 405);
            this.panelContentRicerca.TabIndex = 7;
            // 
            // panelSearchResult
            // 
            this.panelSearchResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.panelSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchResult.Controls.Add(this.listViewResult);
            this.panelSearchResult.Controls.Add(this.labelSearchResult);
            this.panelSearchResult.Location = new System.Drawing.Point(36, 165);
            this.panelSearchResult.Name = "panelSearchResult";
            this.panelSearchResult.Size = new System.Drawing.Size(480, 106);
            this.panelSearchResult.TabIndex = 10;
            // 
            // labelSearchResult
            // 
            this.labelSearchResult.AutoSize = true;
            this.labelSearchResult.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchResult.Location = new System.Drawing.Point(127, 9);
            this.labelSearchResult.Name = "labelSearchResult";
            this.labelSearchResult.Size = new System.Drawing.Size(228, 23);
            this.labelSearchResult.TabIndex = 0;
            this.labelSearchResult.Text = "Risultato della ricerca";
            // 
            // buttonRicerca
            // 
            this.buttonRicerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(68)))));
            this.buttonRicerca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRicerca.FlatAppearance.BorderSize = 0;
            this.buttonRicerca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRicerca.Location = new System.Drawing.Point(296, 33);
            this.buttonRicerca.Name = "buttonRicerca";
            this.buttonRicerca.Size = new System.Drawing.Size(220, 81);
            this.buttonRicerca.TabIndex = 8;
            this.buttonRicerca.Text = "Ricerca";
            this.buttonRicerca.UseVisualStyleBackColor = false;
            this.buttonRicerca.Click += new System.EventHandler(this.buttonRicerca_Click);
            // 
            // listViewResult
            // 
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(74, 35);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(329, 53);
            this.listViewResult.TabIndex = 2;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            // 
            // FormRicerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 405);
            this.Controls.Add(this.panelTitleRicerca);
            this.Controls.Add(this.panelContentRicerca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRicerca";
            this.Text = "ROMA CAPITALE - MAPPA DEI MUNICIPI";
            this.Load += new System.EventHandler(this.FormRicerca_Load);
            this.panelTitleRicerca.ResumeLayout(false);
            this.panelTitleRicerca.PerformLayout();
            this.panelRicercaMunicipio.ResumeLayout(false);
            this.panelRicercaMunicipio.PerformLayout();
            this.panelContentRicerca.ResumeLayout(false);
            this.panelSearchResult.ResumeLayout(false);
            this.panelSearchResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleRicerca;
        private System.Windows.Forms.Label TitleRicerca;
        private System.Windows.Forms.TextBox textBoxSearchMunicipio;
        private System.Windows.Forms.Label labelMunicipio;
        private System.Windows.Forms.Panel panelRicercaMunicipio;
        private System.Windows.Forms.Panel panelContentRicerca;
        private System.Windows.Forms.Button buttonRicerca;
        private System.Windows.Forms.Panel panelSearchResult;
        private System.Windows.Forms.Label labelSearchResult;
        private System.Windows.Forms.ListView listViewResult;
    }
}