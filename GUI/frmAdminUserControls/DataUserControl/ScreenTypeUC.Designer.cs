﻿namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class ScreenTypeUC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.txtScreenTypeName = new System.Windows.Forms.TextBox();
            this.lblScreenTypeName = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.txtScreenTypeID = new System.Windows.Forms.TextBox();
            this.lblScreenTypeID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvScreenType = new System.Windows.Forms.DataGridView();
            this.btnShowScreenType = new System.Windows.Forms.Button();
            this.btnUpdateScreenType = new System.Windows.Forms.Button();
            this.btnDeleteScreenType = new System.Windows.Forms.Button();
            this.btnInsertScreenType = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScreenType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnShowScreenType);
            this.panel1.Controls.Add(this.btnUpdateScreenType);
            this.panel1.Controls.Add(this.btnDeleteScreenType);
            this.panel1.Controls.Add(this.btnInsertScreenType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 91);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1387, 707);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.panel20);
            this.panel4.Controls.Add(this.panel21);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(876, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(511, 707);
            this.panel4.TabIndex = 1;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.txtScreenTypeName);
            this.panel20.Controls.Add(this.lblScreenTypeName);
            this.panel20.Location = new System.Drawing.Point(27, 81);
            this.panel20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(440, 68);
            this.panel20.TabIndex = 4;
            // 
            // txtScreenTypeName
            // 
            this.txtScreenTypeName.Location = new System.Drawing.Point(214, 18);
            this.txtScreenTypeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScreenTypeName.Name = "txtScreenTypeName";
            this.txtScreenTypeName.Size = new System.Drawing.Size(216, 26);
            this.txtScreenTypeName.TabIndex = 1;
            // 
            // lblScreenTypeName
            // 
            this.lblScreenTypeName.AutoSize = true;
            this.lblScreenTypeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScreenTypeName.Location = new System.Drawing.Point(4, 14);
            this.lblScreenTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScreenTypeName.Name = "lblScreenTypeName";
            this.lblScreenTypeName.Size = new System.Drawing.Size(178, 29);
            this.lblScreenTypeName.TabIndex = 0;
            this.lblScreenTypeName.Text = "Tên màn hình:";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.txtScreenTypeID);
            this.panel21.Controls.Add(this.lblScreenTypeID);
            this.panel21.Location = new System.Drawing.Point(27, 5);
            this.panel21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(440, 68);
            this.panel21.TabIndex = 3;
            // 
            // txtScreenTypeID
            // 
            this.txtScreenTypeID.Location = new System.Drawing.Point(214, 18);
            this.txtScreenTypeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScreenTypeID.Name = "txtScreenTypeID";
            this.txtScreenTypeID.Size = new System.Drawing.Size(216, 26);
            this.txtScreenTypeID.TabIndex = 1;
            // 
            // lblScreenTypeID
            // 
            this.lblScreenTypeID.AutoSize = true;
            this.lblScreenTypeID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScreenTypeID.Location = new System.Drawing.Point(4, 14);
            this.lblScreenTypeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScreenTypeID.Name = "lblScreenTypeID";
            this.lblScreenTypeID.Size = new System.Drawing.Size(218, 29);
            this.lblScreenTypeID.TabIndex = 0;
            this.lblScreenTypeID.Text = "Mã loại màn hình:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvScreenType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 707);
            this.panel3.TabIndex = 0;
            // 
            // dtgvScreenType
            // 
            this.dtgvScreenType.AllowUserToAddRows = false;
            this.dtgvScreenType.AllowUserToDeleteRows = false;
            this.dtgvScreenType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvScreenType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvScreenType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvScreenType.Location = new System.Drawing.Point(0, 0);
            this.dtgvScreenType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvScreenType.Name = "dtgvScreenType";
            this.dtgvScreenType.ReadOnly = true;
            this.dtgvScreenType.RowHeadersWidth = 62;
            this.dtgvScreenType.Size = new System.Drawing.Size(876, 707);
            this.dtgvScreenType.TabIndex = 1;
            // 
            // btnShowScreenType
            // 
            this.btnShowScreenType.BackgroundImage = global::GUI.Properties.Resources.history___xemlai;
            this.btnShowScreenType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowScreenType.Location = new System.Drawing.Point(374, 5);
            this.btnShowScreenType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowScreenType.Name = "btnShowScreenType";
            this.btnShowScreenType.Size = new System.Drawing.Size(112, 71);
            this.btnShowScreenType.TabIndex = 7;
            this.btnShowScreenType.UseVisualStyleBackColor = true;
            this.btnShowScreenType.Click += new System.EventHandler(this.btnShowScreenType_Click);
            // 
            // btnUpdateScreenType
            // 
            this.btnUpdateScreenType.BackgroundImage = global::GUI.Properties.Resources.update;
            this.btnUpdateScreenType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateScreenType.Location = new System.Drawing.Point(252, 5);
            this.btnUpdateScreenType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateScreenType.Name = "btnUpdateScreenType";
            this.btnUpdateScreenType.Size = new System.Drawing.Size(112, 71);
            this.btnUpdateScreenType.TabIndex = 6;
            this.btnUpdateScreenType.UseVisualStyleBackColor = true;
            this.btnUpdateScreenType.Click += new System.EventHandler(this.btnUpdateScreenType_Click);
            // 
            // btnDeleteScreenType
            // 
            this.btnDeleteScreenType.BackgroundImage = global::GUI.Properties.Resources.delete;
            this.btnDeleteScreenType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteScreenType.Location = new System.Drawing.Point(130, 5);
            this.btnDeleteScreenType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteScreenType.Name = "btnDeleteScreenType";
            this.btnDeleteScreenType.Size = new System.Drawing.Size(112, 71);
            this.btnDeleteScreenType.TabIndex = 5;
            this.btnDeleteScreenType.UseVisualStyleBackColor = true;
            this.btnDeleteScreenType.Click += new System.EventHandler(this.btnDeleteScreenType_Click);
            // 
            // btnInsertScreenType
            // 
            this.btnInsertScreenType.BackgroundImage = global::GUI.Properties.Resources.add;
            this.btnInsertScreenType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertScreenType.Location = new System.Drawing.Point(9, 5);
            this.btnInsertScreenType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertScreenType.Name = "btnInsertScreenType";
            this.btnInsertScreenType.Size = new System.Drawing.Size(112, 71);
            this.btnInsertScreenType.TabIndex = 4;
            this.btnInsertScreenType.UseVisualStyleBackColor = true;
            this.btnInsertScreenType.Click += new System.EventHandler(this.btnInsertScreenType_Click);
            // 
            // ScreenTypeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ScreenTypeUC";
            this.Size = new System.Drawing.Size(1387, 798);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScreenType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowScreenType;
        private System.Windows.Forms.Button btnUpdateScreenType;
        private System.Windows.Forms.Button btnDeleteScreenType;
        private System.Windows.Forms.Button btnInsertScreenType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvScreenType;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox txtScreenTypeName;
        private System.Windows.Forms.Label lblScreenTypeName;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox txtScreenTypeID;
        private System.Windows.Forms.Label lblScreenTypeID;
    }
}
