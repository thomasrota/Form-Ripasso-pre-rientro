namespace Form_Ripasso_pre_rientro
{
    partial class FormModifica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifica));
            this.panelTitleModifica = new System.Windows.Forms.Panel();
            this.TitleModifica = new System.Windows.Forms.Label();
            this.panelTitleModifica.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleModifica
            // 
            this.panelTitleModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(142)))));
            this.panelTitleModifica.Controls.Add(this.TitleModifica);
            this.panelTitleModifica.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleModifica.Location = new System.Drawing.Point(0, 0);
            this.panelTitleModifica.Name = "panelTitleModifica";
            this.panelTitleModifica.Size = new System.Drawing.Size(539, 42);
            this.panelTitleModifica.TabIndex = 1;
            // 
            // TitleModifica
            // 
            this.TitleModifica.AutoSize = true;
            this.TitleModifica.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleModifica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleModifica.Location = new System.Drawing.Point(261, 10);
            this.TitleModifica.Name = "TitleModifica";
            this.TitleModifica.Size = new System.Drawing.Size(94, 23);
            this.TitleModifica.TabIndex = 0;
            this.TitleModifica.Text = "Modifica";
            // 
            // FormModifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 405);
            this.Controls.Add(this.panelTitleModifica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifica";
            this.Text = "ROMA CAPITALE - MAPPA DEI MUNICIPI";
            this.panelTitleModifica.ResumeLayout(false);
            this.panelTitleModifica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleModifica;
        private System.Windows.Forms.Label TitleModifica;
    }
}