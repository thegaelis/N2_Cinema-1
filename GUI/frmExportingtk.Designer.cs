namespace GUI
{
    partial class frmExportingtk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportingtk));
            this.rptExportingtk = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptExportingtk
            // 
            this.rptExportingtk.AutoScroll = true;
            this.rptExportingtk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptExportingtk.Location = new System.Drawing.Point(0, 0);
            this.rptExportingtk.Name = "rptExportingtk";
            this.rptExportingtk.ServerReport.BearerToken = null;
            this.rptExportingtk.Size = new System.Drawing.Size(714, 653);
            this.rptExportingtk.TabIndex = 0;
            // 
            // frmExportingtk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 653);
            this.Controls.Add(this.rptExportingtk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExportingtk";
            this.Text = "Xuất vé";
            this.Load += new System.EventHandler(this.frmExportingtk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptExportingtk;
    }
}