namespace GUI
{
    partial class ResetByOTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetByOTP));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.sendOTP = new System.Windows.Forms.Button();
            this.btnResetPw = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(194, 48);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(175, 26);
            this.txtUsername.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(194, 98);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã xác nhận:";
            // 
            // txtOTP
            // 
            this.txtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.Location = new System.Drawing.Point(194, 198);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOTP.Multiline = true;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(175, 26);
            this.txtOTP.TabIndex = 7;
            // 
            // sendOTP
            // 
            this.sendOTP.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sendOTP.BackgroundImage = global::GUI.Properties.Resources.sendOTP_button;
            this.sendOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendOTP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.sendOTP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.sendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendOTP.ForeColor = System.Drawing.SystemColors.Control;
            this.sendOTP.Location = new System.Drawing.Point(332, 126);
            this.sendOTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendOTP.Name = "sendOTP";
            this.sendOTP.Size = new System.Drawing.Size(36, 31);
            this.sendOTP.TabIndex = 8;
            this.sendOTP.UseVisualStyleBackColor = false;
            this.sendOTP.Click += new System.EventHandler(this.sendOTP_Click);
            // 
            // btnResetPw
            // 
            this.btnResetPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPw.Location = new System.Drawing.Point(215, 257);
            this.btnResetPw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetPw.Name = "btnResetPw";
            this.btnResetPw.Size = new System.Drawing.Size(133, 43);
            this.btnResetPw.TabIndex = 9;
            this.btnResetPw.Text = "Đặt lại mật khẩu";
            this.btnResetPw.UseVisualStyleBackColor = true;
            this.btnResetPw.Click += new System.EventHandler(this.btnResetPw_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quay lại";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ResetByOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.layout_OTP___Pass;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 315);
            this.Controls.Add(this.sendOTP);
            this.Controls.Add(this.btnResetPw);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ResetByOTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetByOTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button sendOTP;
        private System.Windows.Forms.Button btnResetPw;
        private System.Windows.Forms.Label label4;
    }
}