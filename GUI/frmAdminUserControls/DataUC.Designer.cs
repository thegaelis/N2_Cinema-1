﻿namespace GUI.frmAdminUserControls
{
    partial class DataUC
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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnTicketsUC = new System.Windows.Forms.Button();
            this.btnShowTimesUC = new System.Windows.Forms.Button();
            this.btnFormatMovieUC = new System.Windows.Forms.Button();
            this.btnMovieUC = new System.Windows.Forms.Button();
            this.btnGenreUC = new System.Windows.Forms.Button();
            this.btnCinemaUC = new System.Windows.Forms.Button();
            this.btnScreenTypeUC = new System.Windows.Forms.Button();
            this.pnData = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnTicketsUC);
            this.panel1.Controls.Add(this.btnShowTimesUC);
            this.panel1.Controls.Add(this.btnFormatMovieUC);
            this.panel1.Controls.Add(this.btnMovieUC);
            this.panel1.Controls.Add(this.btnGenreUC);
            this.panel1.Controls.Add(this.btnCinemaUC);
            this.panel1.Controls.Add(this.btnScreenTypeUC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 534);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(19)))), ((int)(((byte)(18)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 60);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 53);
            this.SidePanel.TabIndex = 5;
            // 
            // btnTicketsUC
            // 
            this.btnTicketsUC.FlatAppearance.BorderSize = 0;
            this.btnTicketsUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketsUC.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketsUC.ForeColor = System.Drawing.Color.White;
            this.btnTicketsUC.Image = global::GUI.Properties.Resources.ticket;
            this.btnTicketsUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicketsUC.Location = new System.Drawing.Point(11, 382);
            this.btnTicketsUC.Name = "btnTicketsUC";
            this.btnTicketsUC.Size = new System.Drawing.Size(197, 53);
            this.btnTicketsUC.TabIndex = 6;
            this.btnTicketsUC.Text = "     Vé";
            this.btnTicketsUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTicketsUC.UseVisualStyleBackColor = true;
            this.btnTicketsUC.Click += new System.EventHandler(this.btnTicketsUC_Click);
            // 
            // btnShowTimesUC
            // 
            this.btnShowTimesUC.FlatAppearance.BorderSize = 0;
            this.btnShowTimesUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTimesUC.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTimesUC.ForeColor = System.Drawing.Color.White;
            this.btnShowTimesUC.Image = global::GUI.Properties.Resources.typeScreen;
            this.btnShowTimesUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTimesUC.Location = new System.Drawing.Point(11, 328);
            this.btnShowTimesUC.Name = "btnShowTimesUC";
            this.btnShowTimesUC.Size = new System.Drawing.Size(197, 53);
            this.btnShowTimesUC.TabIndex = 7;
            this.btnShowTimesUC.Text = "     Lịch Chiếu";
            this.btnShowTimesUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowTimesUC.UseVisualStyleBackColor = true;
            this.btnShowTimesUC.Click += new System.EventHandler(this.btnShowTimesUC_Click);
            // 
            // btnFormatMovieUC
            // 
            this.btnFormatMovieUC.FlatAppearance.BorderSize = 0;
            this.btnFormatMovieUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatMovieUC.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormatMovieUC.ForeColor = System.Drawing.Color.White;
            this.btnFormatMovieUC.Image = global::GUI.Properties.Resources.typefilm;
            this.btnFormatMovieUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormatMovieUC.Location = new System.Drawing.Point(11, 274);
            this.btnFormatMovieUC.Name = "btnFormatMovieUC";
            this.btnFormatMovieUC.Size = new System.Drawing.Size(197, 53);
            this.btnFormatMovieUC.TabIndex = 8;
            this.btnFormatMovieUC.Text = "     Định Dạng";
            this.btnFormatMovieUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormatMovieUC.UseVisualStyleBackColor = true;
            this.btnFormatMovieUC.Click += new System.EventHandler(this.btnFormatMovieUC_Click);
            // 
            // btnMovieUC
            // 
            this.btnMovieUC.FlatAppearance.BorderSize = 0;
            this.btnMovieUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovieUC.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieUC.ForeColor = System.Drawing.Color.White;
            this.btnMovieUC.Image = global::GUI.Properties.Resources.film;
            this.btnMovieUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovieUC.Location = new System.Drawing.Point(11, 220);
            this.btnMovieUC.Name = "btnMovieUC";
            this.btnMovieUC.Size = new System.Drawing.Size(197, 53);
            this.btnMovieUC.TabIndex = 9;
            this.btnMovieUC.Text = "     Phim";
            this.btnMovieUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovieUC.UseVisualStyleBackColor = true;
            this.btnMovieUC.Click += new System.EventHandler(this.btnMovieUC_Click);
            // 
            // btnGenreUC
            // 
            this.btnGenreUC.FlatAppearance.BorderSize = 0;
            this.btnGenreUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenreUC.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenreUC.ForeColor = System.Drawing.Color.White;
            this.btnGenreUC.Image = global::GUI.Properties.Resources.typefilm;
            this.btnGenreUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenreUC.Location = new System.Drawing.Point(11, 166);
            this.btnGenreUC.Name = "btnGenreUC";
            this.btnGenreUC.Size = new System.Drawing.Size(197, 53);
            this.btnGenreUC.TabIndex = 10;
            this.btnGenreUC.Text = "     Thể Loại";
            this.btnGenreUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenreUC.UseVisualStyleBackColor = true;
            this.btnGenreUC.Click += new System.EventHandler(this.btnGenreUC_Click);
            // 
            // btnCinemaUC
            // 
            this.btnCinemaUC.FlatAppearance.BorderSize = 0;
            this.btnCinemaUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinemaUC.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinemaUC.ForeColor = System.Drawing.Color.White;
            this.btnCinemaUC.Image = global::GUI.Properties.Resources.cine_room;
            this.btnCinemaUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCinemaUC.Location = new System.Drawing.Point(11, 112);
            this.btnCinemaUC.Name = "btnCinemaUC";
            this.btnCinemaUC.Size = new System.Drawing.Size(197, 53);
            this.btnCinemaUC.TabIndex = 11;
            this.btnCinemaUC.Text = "     Phòng Chiếu";
            this.btnCinemaUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCinemaUC.UseVisualStyleBackColor = true;
            this.btnCinemaUC.Click += new System.EventHandler(this.btnCinemaUC_Click);
            // 
            // btnScreenTypeUC
            // 
            this.btnScreenTypeUC.FlatAppearance.BorderSize = 0;
            this.btnScreenTypeUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenTypeUC.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenTypeUC.ForeColor = System.Drawing.Color.White;
            this.btnScreenTypeUC.Image = global::GUI.Properties.Resources.quality;
            this.btnScreenTypeUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreenTypeUC.Location = new System.Drawing.Point(11, 58);
            this.btnScreenTypeUC.Name = "btnScreenTypeUC";
            this.btnScreenTypeUC.Size = new System.Drawing.Size(197, 53);
            this.btnScreenTypeUC.TabIndex = 12;
            this.btnScreenTypeUC.Text = "     Loại màn hình";
            this.btnScreenTypeUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScreenTypeUC.UseVisualStyleBackColor = true;
            this.btnScreenTypeUC.Click += new System.EventHandler(this.btnScreenTypeUC_Click);
            // 
            // pnData
            // 
            this.pnData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnData.Location = new System.Drawing.Point(209, 14);
            this.pnData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(1164, 520);
            this.pnData.TabIndex = 1;
            // 
            // DataUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DataUC";
            this.Size = new System.Drawing.Size(1373, 534);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnTicketsUC;
        private System.Windows.Forms.Button btnShowTimesUC;
        private System.Windows.Forms.Button btnFormatMovieUC;
        private System.Windows.Forms.Button btnMovieUC;
        private System.Windows.Forms.Button btnGenreUC;
        private System.Windows.Forms.Button btnCinemaUC;
        private System.Windows.Forms.Button btnScreenTypeUC;
        private System.Windows.Forms.Panel pnData;
    }
}
