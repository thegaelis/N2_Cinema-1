﻿namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class GenreUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel40 = new System.Windows.Forms.Panel();
            this.btnShowGenre = new System.Windows.Forms.Button();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnInsertGenre = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvGenre = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtGenreDesc = new System.Windows.Forms.TextBox();
            this.lblGenreDesc = new System.Windows.Forms.Label();
            this.panel38 = new System.Windows.Forms.Panel();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.panel39 = new System.Windows.Forms.Panel();
            this.txtGenreID = new System.Windows.Forms.TextBox();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.panel40.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel39.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.btnShowGenre);
            this.panel40.Controls.Add(this.btnUpdateGenre);
            this.panel40.Controls.Add(this.btnDeleteGenre);
            this.panel40.Controls.Add(this.btnInsertGenre);
            this.panel40.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel40.Location = new System.Drawing.Point(0, 0);
            this.panel40.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(1742, 80);
            this.panel40.TabIndex = 10;
            // 
            // btnShowGenre
            // 
            this.btnShowGenre.BackgroundImage = global::GUI.Properties.Resources.history___xemlai;
            this.btnShowGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowGenre.Location = new System.Drawing.Point(369, 5);
            this.btnShowGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowGenre.Name = "btnShowGenre";
            this.btnShowGenre.Size = new System.Drawing.Size(112, 71);
            this.btnShowGenre.TabIndex = 3;
            this.btnShowGenre.UseVisualStyleBackColor = true;
            this.btnShowGenre.Click += new System.EventHandler(this.btnShowGenre_Click);
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.BackgroundImage = global::GUI.Properties.Resources.update;
            this.btnUpdateGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateGenre.Location = new System.Drawing.Point(248, 5);
            this.btnUpdateGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(112, 71);
            this.btnUpdateGenre.TabIndex = 2;
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.BackgroundImage = global::GUI.Properties.Resources.delete;
            this.btnDeleteGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteGenre.Location = new System.Drawing.Point(126, 5);
            this.btnDeleteGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(112, 71);
            this.btnDeleteGenre.TabIndex = 1;
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnInsertGenre
            // 
            this.btnInsertGenre.BackgroundImage = global::GUI.Properties.Resources.add;
            this.btnInsertGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertGenre.Location = new System.Drawing.Point(4, 5);
            this.btnInsertGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertGenre.Name = "btnInsertGenre";
            this.btnInsertGenre.Size = new System.Drawing.Size(112, 71);
            this.btnInsertGenre.TabIndex = 0;
            this.btnInsertGenre.UseVisualStyleBackColor = true;
            this.btnInsertGenre.Click += new System.EventHandler(this.btnInsertGenre_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvGenre);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1742, 718);
            this.panel1.TabIndex = 11;
            // 
            // dtgvGenre
            // 
            this.dtgvGenre.AllowUserToAddRows = false;
            this.dtgvGenre.AllowUserToDeleteRows = false;
            this.dtgvGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvGenre.Location = new System.Drawing.Point(0, 0);
            this.dtgvGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvGenre.Name = "dtgvGenre";
            this.dtgvGenre.ReadOnly = true;
            this.dtgvGenre.RowHeadersWidth = 62;
            this.dtgvGenre.Size = new System.Drawing.Size(1141, 718);
            this.dtgvGenre.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel38);
            this.panel2.Controls.Add(this.panel39);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1141, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 718);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtGenreDesc);
            this.panel5.Controls.Add(this.lblGenreDesc);
            this.panel5.Location = new System.Drawing.Point(4, 164);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(592, 228);
            this.panel5.TabIndex = 5;
            // 
            // txtGenreDesc
            // 
            this.txtGenreDesc.Location = new System.Drawing.Point(99, 12);
            this.txtGenreDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGenreDesc.Multiline = true;
            this.txtGenreDesc.Name = "txtGenreDesc";
            this.txtGenreDesc.Size = new System.Drawing.Size(458, 194);
            this.txtGenreDesc.TabIndex = 1;
            // 
            // lblGenreDesc
            // 
            this.lblGenreDesc.AutoSize = true;
            this.lblGenreDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreDesc.Location = new System.Drawing.Point(4, 14);
            this.lblGenreDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreDesc.Name = "lblGenreDesc";
            this.lblGenreDesc.Size = new System.Drawing.Size(91, 29);
            this.lblGenreDesc.TabIndex = 0;
            this.lblGenreDesc.Text = "Mô tả :";
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.txtGenreName);
            this.panel38.Controls.Add(this.lblGenreName);
            this.panel38.Location = new System.Drawing.Point(4, 86);
            this.panel38.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(592, 68);
            this.panel38.TabIndex = 4;
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(188, 12);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(370, 26);
            this.txtGenreName.TabIndex = 1;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreName.Location = new System.Drawing.Point(4, 14);
            this.lblGenreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(162, 29);
            this.lblGenreName.TabIndex = 0;
            this.lblGenreName.Text = "Tên thể loại :";
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.txtGenreID);
            this.panel39.Controls.Add(this.lblGenreID);
            this.panel39.Location = new System.Drawing.Point(4, 10);
            this.panel39.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(592, 68);
            this.panel39.TabIndex = 3;
            // 
            // txtGenreID
            // 
            this.txtGenreID.Location = new System.Drawing.Point(188, 12);
            this.txtGenreID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGenreID.Name = "txtGenreID";
            this.txtGenreID.Size = new System.Drawing.Size(370, 26);
            this.txtGenreID.TabIndex = 1;
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreID.Location = new System.Drawing.Point(4, 14);
            this.lblGenreID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(153, 29);
            this.lblGenreID.TabIndex = 0;
            this.lblGenreID.Text = "Mã thể loại :";
            // 
            // GenreUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel40);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GenreUC";
            this.Size = new System.Drawing.Size(1742, 798);
            this.panel40.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Button btnShowGenre;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnInsertGenre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtGenreDesc;
        private System.Windows.Forms.Label lblGenreDesc;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label lblGenreName;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.TextBox txtGenreID;
        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.DataGridView dtgvGenre;
    }
}
