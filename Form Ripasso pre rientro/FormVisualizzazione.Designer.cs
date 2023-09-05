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
            this.panelTitleCancellazione.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCancellazioneContent
            // 
            this.panelCancellazioneContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(181)))), ((int)(((byte)(159)))));
            this.panelCancellazioneContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCancellazioneContent.Location = new System.Drawing.Point(0, 0);
            this.panelCancellazioneContent.Name = "panelCancellazioneContent";
            this.panelCancellazioneContent.Size = new System.Drawing.Size(539, 405);
            this.panelCancellazioneContent.TabIndex = 11;
            // 
            // panelTitleCancellazione
            // 
            this.panelTitleCancellazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(142)))));
            this.panelTitleCancellazione.Controls.Add(this.TitleVisualizza);
            this.panelTitleCancellazione.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleCancellazione.Location = new System.Drawing.Point(0, 0);
            this.panelTitleCancellazione.Name = "panelTitleCancellazione";
            this.panelTitleCancellazione.Size = new System.Drawing.Size(539, 42);
            this.panelTitleCancellazione.TabIndex = 10;
            // 
            // TitleVisualizza
            // 
            this.TitleVisualizza.AutoSize = true;
            this.TitleVisualizza.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleVisualizza.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleVisualizza.Location = new System.Drawing.Point(213, 9);
            this.TitleVisualizza.Name = "TitleVisualizza";
            this.TitleVisualizza.Size = new System.Drawing.Size(113, 23);
            this.TitleVisualizza.TabIndex = 0;
            this.TitleVisualizza.Text = "Visualizza";
            // 
            // FormVisualizzazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 405);
            this.Controls.Add(this.panelTitleCancellazione);
            this.Controls.Add(this.panelCancellazioneContent);
            this.Name = "FormVisualizzazione";
            this.Text = "FormVisualizzazione";
            this.panelTitleCancellazione.ResumeLayout(false);
            this.panelTitleCancellazione.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCancellazioneContent;
        private System.Windows.Forms.Panel panelTitleCancellazione;
        private System.Windows.Forms.Label TitleVisualizza;
    }
}