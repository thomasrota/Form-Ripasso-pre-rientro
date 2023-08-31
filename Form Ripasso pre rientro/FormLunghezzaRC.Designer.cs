namespace Form_Ripasso_pre_rientro
{
    partial class FormLunghezzaRC
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
            this.panelTitleLunghezzaRC = new System.Windows.Forms.Panel();
            this.TitleLunghezzaRC = new System.Windows.Forms.Label();
            this.panelContentLunghezzaRC = new System.Windows.Forms.Panel();
            this.listViewLunghezzaRC = new System.Windows.Forms.ListView();
            this.panelTitleLunghezzaRC.SuspendLayout();
            this.panelContentLunghezzaRC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleLunghezzaRC
            // 
            this.panelTitleLunghezzaRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(142)))));
            this.panelTitleLunghezzaRC.Controls.Add(this.TitleLunghezzaRC);
            this.panelTitleLunghezzaRC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleLunghezzaRC.Location = new System.Drawing.Point(0, 0);
            this.panelTitleLunghezzaRC.Name = "panelTitleLunghezzaRC";
            this.panelTitleLunghezzaRC.Size = new System.Drawing.Size(539, 42);
            this.panelTitleLunghezzaRC.TabIndex = 2;
            // 
            // TitleLunghezzaRC
            // 
            this.TitleLunghezzaRC.AutoSize = true;
            this.TitleLunghezzaRC.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLunghezzaRC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLunghezzaRC.Location = new System.Drawing.Point(154, 10);
            this.TitleLunghezzaRC.Name = "TitleLunghezzaRC";
            this.TitleLunghezzaRC.Size = new System.Drawing.Size(260, 23);
            this.TitleLunghezzaRC.TabIndex = 0;
            this.TitleLunghezzaRC.Text = "Lunghezza record / campi";
            // 
            // panelContentLunghezzaRC
            // 
            this.panelContentLunghezzaRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(181)))), ((int)(((byte)(159)))));
            this.panelContentLunghezzaRC.Controls.Add(this.listViewLunghezzaRC);
            this.panelContentLunghezzaRC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContentLunghezzaRC.Location = new System.Drawing.Point(0, 0);
            this.panelContentLunghezzaRC.Name = "panelContentLunghezzaRC";
            this.panelContentLunghezzaRC.Size = new System.Drawing.Size(539, 405);
            this.panelContentLunghezzaRC.TabIndex = 3;
            // 
            // listViewLunghezzaRC
            // 
            this.listViewLunghezzaRC.HideSelection = false;
            this.listViewLunghezzaRC.Location = new System.Drawing.Point(118, 25);
            this.listViewLunghezzaRC.Name = "listViewLunghezzaRC";
            this.listViewLunghezzaRC.Size = new System.Drawing.Size(329, 220);
            this.listViewLunghezzaRC.TabIndex = 0;
            this.listViewLunghezzaRC.UseCompatibleStateImageBehavior = false;
            // 
            // FormLunghezzaRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 405);
            this.Controls.Add(this.panelTitleLunghezzaRC);
            this.Controls.Add(this.panelContentLunghezzaRC);
            this.Name = "FormLunghezzaRC";
            this.Text = "FormLunghezzaRC";
            this.panelTitleLunghezzaRC.ResumeLayout(false);
            this.panelTitleLunghezzaRC.PerformLayout();
            this.panelContentLunghezzaRC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleLunghezzaRC;
        private System.Windows.Forms.Label TitleLunghezzaRC;
        private System.Windows.Forms.Panel panelContentLunghezzaRC;
        private System.Windows.Forms.ListView listViewLunghezzaRC;
    }
}