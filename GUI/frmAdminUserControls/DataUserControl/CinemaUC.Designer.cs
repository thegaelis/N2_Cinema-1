﻿namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class CinemaUC
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
            this.panel33 = new System.Windows.Forms.Panel();
            this.btnShowCinema = new System.Windows.Forms.Button();
            this.btnUpdateCinema = new System.Windows.Forms.Button();
            this.btnDeleteCinema = new System.Windows.Forms.Button();
            this.btnInsertCinema = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboCinemaScreenType = new System.Windows.Forms.ComboBox();
            this.lblScreenType = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtSeatsPerRow = new System.Windows.Forms.TextBox();
            this.lblSeatsPerRow = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtNumberOfRows = new System.Windows.Forms.TextBox();
            this.lblNumberOfRows = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtCinemaStatus = new System.Windows.Forms.TextBox();
            this.lblCinemaStatus = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCinemaSeats = new System.Windows.Forms.TextBox();
            this.lblCinemaSeats = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.txtCinemaName = new System.Windows.Forms.TextBox();
            this.lblCinemaName = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.txtCinemaID = new System.Windows.Forms.TextBox();
            this.lblCinemaID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvCinema = new System.Windows.Forms.DataGridView();
            this.panel33.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinema)).BeginInit();
            this.SuspendLayout();
            // 
            // panel33
            // 
            this.panel33.Controls.Add(this.btnShowCinema);
            this.panel33.Controls.Add(this.btnUpdateCinema);
            this.panel33.Controls.Add(this.btnDeleteCinema);
            this.panel33.Controls.Add(this.btnInsertCinema);
            this.panel33.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel33.Location = new System.Drawing.Point(0, 0);
            this.panel33.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(1632, 80);
            this.panel33.TabIndex = 10;
            // 
            // btnShowCinema
            // 
            this.btnShowCinema.BackgroundImage = global::GUI.Properties.Resources.history___xemlai;
            this.btnShowCinema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowCinema.Location = new System.Drawing.Point(369, 5);
            this.btnShowCinema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowCinema.Name = "btnShowCinema";
            this.btnShowCinema.Size = new System.Drawing.Size(112, 71);
            this.btnShowCinema.TabIndex = 3;
            this.btnShowCinema.UseVisualStyleBackColor = true;
            this.btnShowCinema.Click += new System.EventHandler(this.btnDeleteCinema_Click);
            // 
            // btnUpdateCinema
            // 
            this.btnUpdateCinema.BackgroundImage = global::GUI.Properties.Resources.update;
            this.btnUpdateCinema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCinema.Location = new System.Drawing.Point(248, 5);
            this.btnUpdateCinema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateCinema.Name = "btnUpdateCinema";
            this.btnUpdateCinema.Size = new System.Drawing.Size(112, 71);
            this.btnUpdateCinema.TabIndex = 2;
            this.btnUpdateCinema.UseVisualStyleBackColor = true;
            this.btnUpdateCinema.Click += new System.EventHandler(this.btnUpdateCinema_Click);
            // 
            // btnDeleteCinema
            // 
            this.btnDeleteCinema.BackgroundImage = global::GUI.Properties.Resources.delete;
            this.btnDeleteCinema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCinema.Location = new System.Drawing.Point(126, 5);
            this.btnDeleteCinema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCinema.Name = "btnDeleteCinema";
            this.btnDeleteCinema.Size = new System.Drawing.Size(112, 71);
            this.btnDeleteCinema.TabIndex = 1;
            this.btnDeleteCinema.UseVisualStyleBackColor = true;
            this.btnDeleteCinema.Click += new System.EventHandler(this.btnDeleteCinema_Click);
            // 
            // btnInsertCinema
            // 
            this.btnInsertCinema.BackgroundImage = global::GUI.Properties.Resources.add;
            this.btnInsertCinema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertCinema.Location = new System.Drawing.Point(4, 5);
            this.btnInsertCinema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertCinema.Name = "btnInsertCinema";
            this.btnInsertCinema.Size = new System.Drawing.Size(112, 71);
            this.btnInsertCinema.TabIndex = 0;
            this.btnInsertCinema.UseVisualStyleBackColor = true;
            this.btnInsertCinema.Click += new System.EventHandler(this.btnInsertCinema_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel31);
            this.panel2.Controls.Add(this.panel32);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1132, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 718);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cboCinemaScreenType);
            this.panel6.Controls.Add(this.lblScreenType);
            this.panel6.Location = new System.Drawing.Point(19, 159);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(464, 68);
            this.panel6.TabIndex = 4;
            // 
            // cboCinemaScreenType
            // 
            this.cboCinemaScreenType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCinemaScreenType.FormattingEnabled = true;
            this.cboCinemaScreenType.Location = new System.Drawing.Point(198, 14);
            this.cboCinemaScreenType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCinemaScreenType.Name = "cboCinemaScreenType";
            this.cboCinemaScreenType.Size = new System.Drawing.Size(240, 28);
            this.cboCinemaScreenType.TabIndex = 1;
            // 
            // lblScreenType
            // 
            this.lblScreenType.AutoSize = true;
            this.lblScreenType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScreenType.Location = new System.Drawing.Point(4, 14);
            this.lblScreenType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScreenType.Name = "lblScreenType";
            this.lblScreenType.Size = new System.Drawing.Size(128, 29);
            this.lblScreenType.TabIndex = 0;
            this.lblScreenType.Text = "Màn hình:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtSeatsPerRow);
            this.panel15.Controls.Add(this.lblSeatsPerRow);
            this.panel15.Location = new System.Drawing.Point(19, 469);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(464, 68);
            this.panel15.TabIndex = 5;
            // 
            // txtSeatsPerRow
            // 
            this.txtSeatsPerRow.Location = new System.Drawing.Point(198, 14);
            this.txtSeatsPerRow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSeatsPerRow.Name = "txtSeatsPerRow";
            this.txtSeatsPerRow.Size = new System.Drawing.Size(240, 26);
            this.txtSeatsPerRow.TabIndex = 1;
            // 
            // lblSeatsPerRow
            // 
            this.lblSeatsPerRow.AutoSize = true;
            this.lblSeatsPerRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSeatsPerRow.Location = new System.Drawing.Point(4, 14);
            this.lblSeatsPerRow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeatsPerRow.Name = "lblSeatsPerRow";
            this.lblSeatsPerRow.Size = new System.Drawing.Size(182, 29);
            this.lblSeatsPerRow.TabIndex = 0;
            this.lblSeatsPerRow.Text = "Ghế mỗi hàng:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtNumberOfRows);
            this.panel12.Controls.Add(this.lblNumberOfRows);
            this.panel12.Location = new System.Drawing.Point(19, 391);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(464, 68);
            this.panel12.TabIndex = 6;
            // 
            // txtNumberOfRows
            // 
            this.txtNumberOfRows.Location = new System.Drawing.Point(198, 18);
            this.txtNumberOfRows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberOfRows.Name = "txtNumberOfRows";
            this.txtNumberOfRows.Size = new System.Drawing.Size(240, 26);
            this.txtNumberOfRows.TabIndex = 1;
            // 
            // lblNumberOfRows
            // 
            this.lblNumberOfRows.AutoSize = true;
            this.lblNumberOfRows.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumberOfRows.Location = new System.Drawing.Point(4, 14);
            this.lblNumberOfRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfRows.Name = "lblNumberOfRows";
            this.lblNumberOfRows.Size = new System.Drawing.Size(166, 29);
            this.lblNumberOfRows.TabIndex = 0;
            this.lblNumberOfRows.Text = "Số hàng ghế:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtCinemaStatus);
            this.panel9.Controls.Add(this.lblCinemaStatus);
            this.panel9.Location = new System.Drawing.Point(19, 314);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(464, 68);
            this.panel9.TabIndex = 7;
            // 
            // txtCinemaStatus
            // 
            this.txtCinemaStatus.Location = new System.Drawing.Point(198, 18);
            this.txtCinemaStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCinemaStatus.Name = "txtCinemaStatus";
            this.txtCinemaStatus.Size = new System.Drawing.Size(240, 26);
            this.txtCinemaStatus.TabIndex = 1;
            // 
            // lblCinemaStatus
            // 
            this.lblCinemaStatus.AutoSize = true;
            this.lblCinemaStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaStatus.Location = new System.Drawing.Point(4, 14);
            this.lblCinemaStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinemaStatus.Name = "lblCinemaStatus";
            this.lblCinemaStatus.Size = new System.Drawing.Size(139, 29);
            this.lblCinemaStatus.TabIndex = 0;
            this.lblCinemaStatus.Text = "Tình trạng:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtCinemaSeats);
            this.panel8.Controls.Add(this.lblCinemaSeats);
            this.panel8.Location = new System.Drawing.Point(19, 238);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(464, 68);
            this.panel8.TabIndex = 8;
            // 
            // txtCinemaSeats
            // 
            this.txtCinemaSeats.Location = new System.Drawing.Point(198, 18);
            this.txtCinemaSeats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCinemaSeats.Name = "txtCinemaSeats";
            this.txtCinemaSeats.Size = new System.Drawing.Size(240, 26);
            this.txtCinemaSeats.TabIndex = 1;
            // 
            // lblCinemaSeats
            // 
            this.lblCinemaSeats.AutoSize = true;
            this.lblCinemaSeats.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaSeats.Location = new System.Drawing.Point(4, 14);
            this.lblCinemaSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinemaSeats.Name = "lblCinemaSeats";
            this.lblCinemaSeats.Size = new System.Drawing.Size(160, 29);
            this.lblCinemaSeats.TabIndex = 0;
            this.lblCinemaSeats.Text = "Số chỗ ngồi:";
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.txtCinemaName);
            this.panel31.Controls.Add(this.lblCinemaName);
            this.panel31.Location = new System.Drawing.Point(19, 81);
            this.panel31.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(464, 68);
            this.panel31.TabIndex = 9;
            // 
            // txtCinemaName
            // 
            this.txtCinemaName.Location = new System.Drawing.Point(198, 18);
            this.txtCinemaName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCinemaName.Name = "txtCinemaName";
            this.txtCinemaName.Size = new System.Drawing.Size(240, 26);
            this.txtCinemaName.TabIndex = 1;
            // 
            // lblCinemaName
            // 
            this.lblCinemaName.AutoSize = true;
            this.lblCinemaName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaName.Location = new System.Drawing.Point(4, 14);
            this.lblCinemaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinemaName.Name = "lblCinemaName";
            this.lblCinemaName.Size = new System.Drawing.Size(145, 29);
            this.lblCinemaName.TabIndex = 0;
            this.lblCinemaName.Text = "Tên phòng:";
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.txtCinemaID);
            this.panel32.Controls.Add(this.lblCinemaID);
            this.panel32.Location = new System.Drawing.Point(19, 5);
            this.panel32.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(464, 68);
            this.panel32.TabIndex = 3;
            // 
            // txtCinemaID
            // 
            this.txtCinemaID.Location = new System.Drawing.Point(198, 20);
            this.txtCinemaID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCinemaID.Name = "txtCinemaID";
            this.txtCinemaID.Size = new System.Drawing.Size(242, 26);
            this.txtCinemaID.TabIndex = 1;
            this.txtCinemaID.TextChanged += new System.EventHandler(this.txtCinemaID_TextChanged);
            // 
            // lblCinemaID
            // 
            this.lblCinemaID.AutoSize = true;
            this.lblCinemaID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaID.Location = new System.Drawing.Point(4, 18);
            this.lblCinemaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinemaID.Name = "lblCinemaID";
            this.lblCinemaID.Size = new System.Drawing.Size(136, 29);
            this.lblCinemaID.TabIndex = 0;
            this.lblCinemaID.Text = "Mã phòng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvCinema);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1632, 718);
            this.panel1.TabIndex = 11;
            // 
            // dtgvCinema
            // 
            this.dtgvCinema.AllowUserToAddRows = false;
            this.dtgvCinema.AllowUserToDeleteRows = false;
            this.dtgvCinema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCinema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCinema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCinema.Location = new System.Drawing.Point(0, 0);
            this.dtgvCinema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvCinema.Name = "dtgvCinema";
            this.dtgvCinema.ReadOnly = true;
            this.dtgvCinema.RowHeadersWidth = 62;
            this.dtgvCinema.Size = new System.Drawing.Size(1132, 718);
            this.dtgvCinema.TabIndex = 1;
            // 
            // CinemaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel33);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CinemaUC";
            this.Size = new System.Drawing.Size(1632, 798);
            this.panel33.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Button btnShowCinema;
        private System.Windows.Forms.Button btnUpdateCinema;
        private System.Windows.Forms.Button btnDeleteCinema;
        private System.Windows.Forms.Button btnInsertCinema;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cboCinemaScreenType;
        private System.Windows.Forms.Label lblScreenType;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtSeatsPerRow;
        private System.Windows.Forms.Label lblSeatsPerRow;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtNumberOfRows;
        private System.Windows.Forms.Label lblNumberOfRows;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtCinemaStatus;
        private System.Windows.Forms.Label lblCinemaStatus;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCinemaSeats;
        private System.Windows.Forms.Label lblCinemaSeats;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.TextBox txtCinemaName;
        private System.Windows.Forms.Label lblCinemaName;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.TextBox txtCinemaID;
        private System.Windows.Forms.Label lblCinemaID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvCinema;
    }
}
