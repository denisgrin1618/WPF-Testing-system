﻿namespace TestingSystem
{
    partial class Settings
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
            this.button2 = new System.Windows.Forms.Button();
            this.DatabaseList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 21);
            this.button2.TabIndex = 11;
            this.button2.Text = "Проверка соединения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DatabaseList
            // 
            this.DatabaseList.FormattingEnabled = true;
            this.DatabaseList.Location = new System.Drawing.Point(232, 40);
            this.DatabaseList.Name = "DatabaseList";
            this.DatabaseList.Size = new System.Drawing.Size(209, 21);
            this.DatabaseList.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выберите или введите имя базы данных:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя сервера:";
            // 
            // ServerName
            // 
            this.ServerName.FormattingEnabled = true;
            this.ServerName.Location = new System.Drawing.Point(232, 12);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(208, 21);
            this.ServerName.TabIndex = 12;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 71);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DatabaseList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox DatabaseList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ServerName;
    }
}