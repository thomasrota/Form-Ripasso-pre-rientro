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
            this.panelTitleRicerca.SuspendLayout();
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
            this.TitleRicerca.Location = new System.Drawing.Point(261, 10);
            this.TitleRicerca.Name = "TitleRicerca";
            this.TitleRicerca.Size = new System.Drawing.Size(82, 23);
            this.TitleRicerca.TabIndex = 0;
            this.TitleRicerca.Text = "Ricerca";
            // 
            // FormRicerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 405);
            this.Controls.Add(this.panelTitleRicerca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRicerca";
            this.Text = "ROMA CAPITALE - MAPPA DEI MUNICIPI";
            this.panelTitleRicerca.ResumeLayout(false);
            this.panelTitleRicerca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleRicerca;
        private System.Windows.Forms.Label TitleRicerca;
    }
}