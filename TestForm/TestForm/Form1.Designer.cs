﻿namespace PYS.Application.Security.TestForm
{
    partial class Form1
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
            this.TxtCleantext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtEncryptText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtDecryptText = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCleantext
            // 
            this.TxtCleantext.Location = new System.Drawing.Point(33, 46);
            this.TxtCleantext.Name = "TxtCleantext";
            this.TxtCleantext.Size = new System.Drawing.Size(250, 20);
            this.TxtCleantext.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtEncryptText
            // 
            this.TxtEncryptText.Location = new System.Drawing.Point(431, 45);
            this.TxtEncryptText.Name = "TxtEncryptText";
            this.TxtEncryptText.Size = new System.Drawing.Size(250, 20);
            this.TxtEncryptText.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtDecryptText
            // 
            this.TxtDecryptText.Location = new System.Drawing.Point(431, 88);
            this.TxtDecryptText.Name = "TxtDecryptText";
            this.TxtDecryptText.Size = new System.Drawing.Size(250, 20);
            this.TxtDecryptText.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 239);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(579, 278);
            this.textBox1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(605, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 70);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TxtDecryptText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtEncryptText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtCleantext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCleantext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtEncryptText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtDecryptText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}

