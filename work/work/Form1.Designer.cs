﻿
namespace work
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
            this.firstbox = new System.Windows.Forms.TextBox();
            this.secondbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultlab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstbox
            // 
            this.firstbox.Location = new System.Drawing.Point(61, 98);
            this.firstbox.Name = "firstbox";
            this.firstbox.Size = new System.Drawing.Size(100, 20);
            this.firstbox.TabIndex = 0;
            this.firstbox.Text = "0";
            // 
            // secondbox
            // 
            this.secondbox.Location = new System.Drawing.Point(281, 98);
            this.secondbox.Name = "secondbox";
            this.secondbox.Size = new System.Drawing.Size(100, 20);
            this.secondbox.TabIndex = 2;
            this.secondbox.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "คำนวณ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.butcal);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "root",
            "pow"});
            this.comboBox1.Location = new System.Drawing.Point(187, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "จำนวนที่ 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "จำนวนที่ 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ผลลัพธ์";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // resultlab
            // 
            this.resultlab.AutoSize = true;
            this.resultlab.Location = new System.Drawing.Point(135, 183);
            this.resultlab.Name = "resultlab";
            this.resultlab.Size = new System.Drawing.Size(10, 13);
            this.resultlab.TabIndex = 8;
            this.resultlab.Text = "-";
            this.resultlab.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.resultlab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondbox);
            this.Controls.Add(this.firstbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstbox;
        private System.Windows.Forms.TextBox secondbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultlab;
    }
}

