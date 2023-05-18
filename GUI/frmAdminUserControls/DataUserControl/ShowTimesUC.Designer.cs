﻿namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class ShowTimesUC
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
            this.components = new System.ComponentModel.Container();
            this.panel54 = new System.Windows.Forms.Panel();
            this.txtSearchShowtime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvShowtime = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtmShowtimeTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmShowtimeDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFormatID_Showtime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCinemaID_Showtime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScreenTypeName_Showtime = new System.Windows.Forms.TextBox();
            this.txtMovieName_Showtime = new System.Windows.Forms.TextBox();
            this.txtTicketPrice_Showtime = new System.Windows.Forms.TextBox();
            this.txtShowtimeID = new System.Windows.Forms.TextBox();
            this.toolTipCinema = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearchShowtime = new System.Windows.Forms.Button();
            this.btnShowShowtime = new System.Windows.Forms.Button();
            this.btnUpdateShowtime = new System.Windows.Forms.Button();
            this.btnDeleteShowtime = new System.Windows.Forms.Button();
            this.btnInsertShowtime = new System.Windows.Forms.Button();
            this.panel54.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowtime)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel54
            // 
            this.panel54.Controls.Add(this.btnSearchShowtime);
            this.panel54.Controls.Add(this.txtSearchShowtime);
            this.panel54.Controls.Add(this.btnShowShowtime);
            this.panel54.Controls.Add(this.btnUpdateShowtime);
            this.panel54.Controls.Add(this.btnDeleteShowtime);
            this.panel54.Controls.Add(this.btnInsertShowtime);
            this.panel54.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel54.Location = new System.Drawing.Point(0, 0);
            this.panel54.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(1742, 80);
            this.panel54.TabIndex = 10;
            // 
            // txtSearchShowtime
            // 
            this.txtSearchShowtime.Location = new System.Drawing.Point(705, 37);
            this.txtSearchShowtime.Multiline = true;
            this.txtSearchShowtime.Name = "txtSearchShowtime";
            this.txtSearchShowtime.Size = new System.Drawing.Size(376, 33);
            this.txtSearchShowtime.TabIndex = 6;
            this.txtSearchShowtime.Text = "Tìm theo tên phim...";
            this.txtSearchShowtime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchShowtime_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvShowtime);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1742, 717);
            this.panel1.TabIndex = 11;
            // 
            // dtgvShowtime
            // 
            this.dtgvShowtime.AllowUserToAddRows = false;
            this.dtgvShowtime.AllowUserToDeleteRows = false;
            this.dtgvShowtime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShowtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowtime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvShowtime.Location = new System.Drawing.Point(0, 0);
            this.dtgvShowtime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvShowtime.Name = "dtgvShowtime";
            this.dtgvShowtime.ReadOnly = true;
            this.dtgvShowtime.RowHeadersWidth = 62;
            this.dtgvShowtime.Size = new System.Drawing.Size(1268, 717);
            this.dtgvShowtime.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.cboFormatID_Showtime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboCinemaID_Showtime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtScreenTypeName_Showtime);
            this.panel2.Controls.Add(this.txtMovieName_Showtime);
            this.panel2.Controls.Add(this.txtTicketPrice_Showtime);
            this.panel2.Controls.Add(this.txtShowtimeID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1268, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 717);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtmShowtimeTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtmShowtimeDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 123);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian chiếu";
            // 
            // dtmShowtimeTime
            // 
            this.dtmShowtimeTime.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmShowtimeTime.Location = new System.Drawing.Point(165, 69);
            this.dtmShowtimeTime.Name = "dtmShowtimeTime";
            this.dtmShowtimeTime.ShowUpDown = true;
            this.dtmShowtimeTime.Size = new System.Drawing.Size(242, 35);
            this.dtmShowtimeTime.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giờ:";
            // 
            // dtmShowtimeDate
            // 
            this.dtmShowtimeDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmShowtimeDate.Location = new System.Drawing.Point(165, 25);
            this.dtmShowtimeDate.Name = "dtmShowtimeDate";
            this.dtmShowtimeDate.Size = new System.Drawing.Size(242, 35);
            this.dtmShowtimeDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày:";
            // 
            // cboFormatID_Showtime
            // 
            this.cboFormatID_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormatID_Showtime.FormattingEnabled = true;
            this.cboFormatID_Showtime.Location = new System.Drawing.Point(182, 89);
            this.cboFormatID_Showtime.Name = "cboFormatID_Showtime";
            this.cboFormatID_Showtime.Size = new System.Drawing.Size(242, 28);
            this.cboFormatID_Showtime.TabIndex = 26;
            this.cboFormatID_Showtime.SelectedIndexChanged += new System.EventHandler(this.cboFormatID_Showtime_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã định dạng:";
            // 
            // cboCinemaID_Showtime
            // 
            this.cboCinemaID_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCinemaID_Showtime.FormattingEnabled = true;
            this.cboCinemaID_Showtime.Location = new System.Drawing.Point(182, 242);
            this.cboCinemaID_Showtime.Name = "cboCinemaID_Showtime";
            this.cboCinemaID_Showtime.Size = new System.Drawing.Size(242, 28);
            this.cboCinemaID_Showtime.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phòng chiếu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Giá vé:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Màn hình:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã lịch chiếu:";
            // 
            // txtScreenTypeName_Showtime
            // 
            this.txtScreenTypeName_Showtime.Location = new System.Drawing.Point(182, 171);
            this.txtScreenTypeName_Showtime.Name = "txtScreenTypeName_Showtime";
            this.txtScreenTypeName_Showtime.ReadOnly = true;
            this.txtScreenTypeName_Showtime.Size = new System.Drawing.Size(242, 26);
            this.txtScreenTypeName_Showtime.TabIndex = 16;
            // 
            // txtMovieName_Showtime
            // 
            this.txtMovieName_Showtime.Location = new System.Drawing.Point(182, 131);
            this.txtMovieName_Showtime.Name = "txtMovieName_Showtime";
            this.txtMovieName_Showtime.ReadOnly = true;
            this.txtMovieName_Showtime.Size = new System.Drawing.Size(242, 26);
            this.txtMovieName_Showtime.TabIndex = 17;
            // 
            // txtTicketPrice_Showtime
            // 
            this.txtTicketPrice_Showtime.Location = new System.Drawing.Point(182, 466);
            this.txtTicketPrice_Showtime.Name = "txtTicketPrice_Showtime";
            this.txtTicketPrice_Showtime.Size = new System.Drawing.Size(242, 26);
            this.txtTicketPrice_Showtime.TabIndex = 18;
            // 
            // txtShowtimeID
            // 
            this.txtShowtimeID.Location = new System.Drawing.Point(182, 17);
            this.txtShowtimeID.Name = "txtShowtimeID";
            this.txtShowtimeID.Size = new System.Drawing.Size(242, 26);
            this.txtShowtimeID.TabIndex = 19;
            this.txtShowtimeID.TextChanged += new System.EventHandler(this.txtShowtimeID_TextChanged);
            // 
            // toolTipCinema
            // 
            this.toolTipCinema.AutoPopDelay = 5000;
            this.toolTipCinema.InitialDelay = 100;
            this.toolTipCinema.ReshowDelay = 100;
            // 
            // btnSearchShowtime
            // 
            this.btnSearchShowtime.BackgroundImage = global::GUI.Properties.Resources.search;
            this.btnSearchShowtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchShowtime.Location = new System.Drawing.Point(1088, 37);
            this.btnSearchShowtime.Name = "btnSearchShowtime";
            this.btnSearchShowtime.Size = new System.Drawing.Size(30, 34);
            this.btnSearchShowtime.TabIndex = 7;
            this.btnSearchShowtime.UseVisualStyleBackColor = true;
            this.btnSearchShowtime.Click += new System.EventHandler(this.btnSearchShowtime_Click);
            // 
            // btnShowShowtime
            // 
            this.btnShowShowtime.BackgroundImage = global::GUI.Properties.Resources.history___xemlai;
            this.btnShowShowtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowShowtime.Location = new System.Drawing.Point(369, 5);
            this.btnShowShowtime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowShowtime.Name = "btnShowShowtime";
            this.btnShowShowtime.Size = new System.Drawing.Size(112, 71);
            this.btnShowShowtime.TabIndex = 3;
            this.btnShowShowtime.UseVisualStyleBackColor = true;
            this.btnShowShowtime.Click += new System.EventHandler(this.btnShowShowtime_Click);
            // 
            // btnUpdateShowtime
            // 
            this.btnUpdateShowtime.BackgroundImage = global::GUI.Properties.Resources.update;
            this.btnUpdateShowtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateShowtime.Location = new System.Drawing.Point(248, 5);
            this.btnUpdateShowtime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateShowtime.Name = "btnUpdateShowtime";
            this.btnUpdateShowtime.Size = new System.Drawing.Size(112, 71);
            this.btnUpdateShowtime.TabIndex = 2;
            this.btnUpdateShowtime.UseVisualStyleBackColor = true;
            this.btnUpdateShowtime.Click += new System.EventHandler(this.btnUpdateShowtime_Click);
            // 
            // btnDeleteShowtime
            // 
            this.btnDeleteShowtime.BackgroundImage = global::GUI.Properties.Resources.delete;
            this.btnDeleteShowtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteShowtime.Location = new System.Drawing.Point(126, 5);
            this.btnDeleteShowtime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteShowtime.Name = "btnDeleteShowtime";
            this.btnDeleteShowtime.Size = new System.Drawing.Size(112, 71);
            this.btnDeleteShowtime.TabIndex = 1;
            this.btnDeleteShowtime.UseVisualStyleBackColor = true;
            this.btnDeleteShowtime.Click += new System.EventHandler(this.btnDeleteShowtime_Click);
            // 
            // btnInsertShowtime
            // 
            this.btnInsertShowtime.BackgroundImage = global::GUI.Properties.Resources.add;
            this.btnInsertShowtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertShowtime.Location = new System.Drawing.Point(4, 5);
            this.btnInsertShowtime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertShowtime.Name = "btnInsertShowtime";
            this.btnInsertShowtime.Size = new System.Drawing.Size(112, 71);
            this.btnInsertShowtime.TabIndex = 0;
            this.btnInsertShowtime.UseVisualStyleBackColor = true;
            this.btnInsertShowtime.Click += new System.EventHandler(this.btnInsertShowtime_Click);
            // 
            // ShowTimesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel54);
            this.Name = "ShowTimesUC";
            this.Size = new System.Drawing.Size(1742, 797);
            this.panel54.ResumeLayout(false);
            this.panel54.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowtime)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel54;
        private System.Windows.Forms.Button btnSearchShowtime;
        private System.Windows.Forms.TextBox txtSearchShowtime;
        private System.Windows.Forms.Button btnShowShowtime;
        private System.Windows.Forms.Button btnUpdateShowtime;
        private System.Windows.Forms.Button btnDeleteShowtime;
        private System.Windows.Forms.Button btnInsertShowtime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtmShowtimeTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtmShowtimeDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFormatID_Showtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCinemaID_Showtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScreenTypeName_Showtime;
        private System.Windows.Forms.TextBox txtMovieName_Showtime;
        private System.Windows.Forms.TextBox txtTicketPrice_Showtime;
        private System.Windows.Forms.TextBox txtShowtimeID;
        private System.Windows.Forms.DataGridView dtgvShowtime;
		private System.Windows.Forms.ToolTip toolTipCinema;
	}
}
