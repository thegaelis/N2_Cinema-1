﻿namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class FormatMovieUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowFormat = new System.Windows.Forms.Button();
            this.btnUpdateFormat = new System.Windows.Forms.Button();
            this.btnDeleteFormat = new System.Windows.Forms.Button();
            this.btnInsertFormat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvFormat = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboFormat_ScreenID = new System.Windows.Forms.ComboBox();
            this.lblFormat_ScreenName = new System.Windows.Forms.Label();
            this.cboFormat_MovieID = new System.Windows.Forms.ComboBox();
            this.lblFormat_ScreenID = new System.Windows.Forms.Label();
            this.lblFormat_MovieName = new System.Windows.Forms.Label();
            this.lblFormat_MovieID = new System.Windows.Forms.Label();
            this.txtFormat_ScreenName = new System.Windows.Forms.TextBox();
            this.lblFormatID = new System.Windows.Forms.Label();
            this.txtFormat_MovieName = new System.Windows.Forms.TextBox();
            this.txtFormatID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFormat)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowFormat);
            this.panel1.Controls.Add(this.btnUpdateFormat);
            this.panel1.Controls.Add(this.btnDeleteFormat);
            this.panel1.Controls.Add(this.btnInsertFormat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1742, 80);
            this.panel1.TabIndex = 0;
            // 
            // btnShowFormat
            // 
            this.btnShowFormat.BackgroundImage = global::GUI.Properties.Resources.history___xemlai;
            this.btnShowFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowFormat.Location = new System.Drawing.Point(369, 5);
            this.btnShowFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowFormat.Name = "btnShowFormat";
            this.btnShowFormat.Size = new System.Drawing.Size(112, 71);
            this.btnShowFormat.TabIndex = 11;
            this.btnShowFormat.UseVisualStyleBackColor = true;
            this.btnShowFormat.Click += new System.EventHandler(this.btnShowFormat_Click);
            // 
            // btnUpdateFormat
            // 
            this.btnUpdateFormat.BackgroundImage = global::GUI.Properties.Resources.update;
            this.btnUpdateFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateFormat.Location = new System.Drawing.Point(248, 5);
            this.btnUpdateFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateFormat.Name = "btnUpdateFormat";
            this.btnUpdateFormat.Size = new System.Drawing.Size(112, 71);
            this.btnUpdateFormat.TabIndex = 10;
            this.btnUpdateFormat.UseVisualStyleBackColor = true;
            this.btnUpdateFormat.Click += new System.EventHandler(this.btnUpdateFormat_Click);
            // 
            // btnDeleteFormat
            // 
            this.btnDeleteFormat.BackgroundImage = global::GUI.Properties.Resources.delete;
            this.btnDeleteFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteFormat.Location = new System.Drawing.Point(126, 5);
            this.btnDeleteFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteFormat.Name = "btnDeleteFormat";
            this.btnDeleteFormat.Size = new System.Drawing.Size(112, 71);
            this.btnDeleteFormat.TabIndex = 9;
            this.btnDeleteFormat.UseVisualStyleBackColor = true;
            this.btnDeleteFormat.Click += new System.EventHandler(this.btnDeleteFormat_Click);
            // 
            // btnInsertFormat
            // 
            this.btnInsertFormat.BackgroundImage = global::GUI.Properties.Resources.add;
            this.btnInsertFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertFormat.Location = new System.Drawing.Point(4, 5);
            this.btnInsertFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertFormat.Name = "btnInsertFormat";
            this.btnInsertFormat.Size = new System.Drawing.Size(112, 71);
            this.btnInsertFormat.TabIndex = 8;
            this.btnInsertFormat.UseVisualStyleBackColor = true;
            this.btnInsertFormat.Click += new System.EventHandler(this.btnInsertFormat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvFormat);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1742, 718);
            this.panel2.TabIndex = 1;
            // 
            // dtgvFormat
            // 
            this.dtgvFormat.AllowUserToAddRows = false;
            this.dtgvFormat.AllowUserToDeleteRows = false;
            this.dtgvFormat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFormat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvFormat.Location = new System.Drawing.Point(0, 0);
            this.dtgvFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvFormat.Name = "dtgvFormat";
            this.dtgvFormat.ReadOnly = true;
            this.dtgvFormat.RowHeadersWidth = 62;
            this.dtgvFormat.Size = new System.Drawing.Size(1236, 718);
            this.dtgvFormat.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboFormat_ScreenID);
            this.panel3.Controls.Add(this.lblFormat_ScreenName);
            this.panel3.Controls.Add(this.cboFormat_MovieID);
            this.panel3.Controls.Add(this.lblFormat_ScreenID);
            this.panel3.Controls.Add(this.lblFormat_MovieName);
            this.panel3.Controls.Add(this.lblFormat_MovieID);
            this.panel3.Controls.Add(this.txtFormat_ScreenName);
            this.panel3.Controls.Add(this.lblFormatID);
            this.panel3.Controls.Add(this.txtFormat_MovieName);
            this.panel3.Controls.Add(this.txtFormatID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1236, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 718);
            this.panel3.TabIndex = 0;
            // 
            // cboFormat_ScreenID
            // 
            this.cboFormat_ScreenID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormat_ScreenID.FormattingEnabled = true;
            this.cboFormat_ScreenID.Location = new System.Drawing.Point(191, 215);
            this.cboFormat_ScreenID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboFormat_ScreenID.Name = "cboFormat_ScreenID";
            this.cboFormat_ScreenID.Size = new System.Drawing.Size(280, 28);
            this.cboFormat_ScreenID.TabIndex = 20;
            this.cboFormat_ScreenID.SelectedIndexChanged += new System.EventHandler(this.cboFormat_ScreenID_SelectedValueChanged);
            // 
            // lblFormat_ScreenName
            // 
            this.lblFormat_ScreenName.AutoSize = true;
            this.lblFormat_ScreenName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat_ScreenName.Location = new System.Drawing.Point(14, 258);
            this.lblFormat_ScreenName.Name = "lblFormat_ScreenName";
            this.lblFormat_ScreenName.Size = new System.Drawing.Size(161, 26);
            this.lblFormat_ScreenName.TabIndex = 15;
            this.lblFormat_ScreenName.Text = "Tên màn hình:";
            // 
            // cboFormat_MovieID
            // 
            this.cboFormat_MovieID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormat_MovieID.FormattingEnabled = true;
            this.cboFormat_MovieID.Location = new System.Drawing.Point(191, 98);
            this.cboFormat_MovieID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboFormat_MovieID.Name = "cboFormat_MovieID";
            this.cboFormat_MovieID.Size = new System.Drawing.Size(280, 28);
            this.cboFormat_MovieID.TabIndex = 21;
            this.cboFormat_MovieID.SelectedIndexChanged += new System.EventHandler(this.cboFormat_MovieID_SelectedValueChanged);
            // 
            // lblFormat_ScreenID
            // 
            this.lblFormat_ScreenID.AutoSize = true;
            this.lblFormat_ScreenID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat_ScreenID.Location = new System.Drawing.Point(14, 216);
            this.lblFormat_ScreenID.Name = "lblFormat_ScreenID";
            this.lblFormat_ScreenID.Size = new System.Drawing.Size(157, 26);
            this.lblFormat_ScreenID.TabIndex = 16;
            this.lblFormat_ScreenID.Text = "Mã màn hình:";
            // 
            // lblFormat_MovieName
            // 
            this.lblFormat_MovieName.AutoSize = true;
            this.lblFormat_MovieName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat_MovieName.Location = new System.Drawing.Point(14, 140);
            this.lblFormat_MovieName.Name = "lblFormat_MovieName";
            this.lblFormat_MovieName.Size = new System.Drawing.Size(117, 26);
            this.lblFormat_MovieName.TabIndex = 17;
            this.lblFormat_MovieName.Text = "Tên phim:";
            // 
            // lblFormat_MovieID
            // 
            this.lblFormat_MovieID.AutoSize = true;
            this.lblFormat_MovieID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat_MovieID.Location = new System.Drawing.Point(14, 99);
            this.lblFormat_MovieID.Name = "lblFormat_MovieID";
            this.lblFormat_MovieID.Size = new System.Drawing.Size(113, 26);
            this.lblFormat_MovieID.TabIndex = 18;
            this.lblFormat_MovieID.Text = "Mã phim:";
            // 
            // txtFormat_ScreenName
            // 
            this.txtFormat_ScreenName.Location = new System.Drawing.Point(191, 261);
            this.txtFormat_ScreenName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFormat_ScreenName.Name = "txtFormat_ScreenName";
            this.txtFormat_ScreenName.ReadOnly = true;
            this.txtFormat_ScreenName.Size = new System.Drawing.Size(280, 26);
            this.txtFormat_ScreenName.TabIndex = 12;
            // 
            // lblFormatID
            // 
            this.lblFormatID.AutoSize = true;
            this.lblFormatID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatID.Location = new System.Drawing.Point(14, 21);
            this.lblFormatID.Name = "lblFormatID";
            this.lblFormatID.Size = new System.Drawing.Size(163, 26);
            this.lblFormatID.TabIndex = 19;
            this.lblFormatID.Text = "Mã định dạng:";
            // 
            // txtFormat_MovieName
            // 
            this.txtFormat_MovieName.Location = new System.Drawing.Point(191, 139);
            this.txtFormat_MovieName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFormat_MovieName.Name = "txtFormat_MovieName";
            this.txtFormat_MovieName.ReadOnly = true;
            this.txtFormat_MovieName.Size = new System.Drawing.Size(280, 26);
            this.txtFormat_MovieName.TabIndex = 13;
            // 
            // txtFormatID
            // 
            this.txtFormatID.Location = new System.Drawing.Point(191, 20);
            this.txtFormatID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFormatID.Name = "txtFormatID";
            this.txtFormatID.Size = new System.Drawing.Size(280, 26);
            this.txtFormatID.TabIndex = 14;
            this.txtFormatID.TextChanged += new System.EventHandler(this.txtFormatID_TextChanged);
            // 
            // FormatMovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormatMovieUC";
            this.Size = new System.Drawing.Size(1742, 798);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFormat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowFormat;
        private System.Windows.Forms.Button btnUpdateFormat;
        private System.Windows.Forms.Button btnDeleteFormat;
        private System.Windows.Forms.Button btnInsertFormat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboFormat_ScreenID;
        private System.Windows.Forms.Label lblFormat_ScreenName;
        private System.Windows.Forms.ComboBox cboFormat_MovieID;
        private System.Windows.Forms.Label lblFormat_ScreenID;
        private System.Windows.Forms.Label lblFormat_MovieName;
        private System.Windows.Forms.Label lblFormat_MovieID;
        private System.Windows.Forms.TextBox txtFormat_ScreenName;
        private System.Windows.Forms.Label lblFormatID;
        private System.Windows.Forms.TextBox txtFormat_MovieName;
        private System.Windows.Forms.TextBox txtFormatID;
        private System.Windows.Forms.DataGridView dtgvFormat;
    }
}
