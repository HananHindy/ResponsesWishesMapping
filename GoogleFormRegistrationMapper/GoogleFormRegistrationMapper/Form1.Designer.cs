﻿namespace GoogleFormRegistrationMapper
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnl_choices = new System.Windows.Forms.Panel();
            this.btn_generate = new System.Windows.Forms.Button();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_choice3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_choice2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_choice1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnl_choices.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(347, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(376, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(439, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnl_choices
            // 
            this.pnl_choices.Controls.Add(this.btn_generate);
            this.pnl_choices.Controls.Add(this.txt_max);
            this.pnl_choices.Controls.Add(this.label5);
            this.pnl_choices.Controls.Add(this.cmb_choice3);
            this.pnl_choices.Controls.Add(this.label4);
            this.pnl_choices.Controls.Add(this.cmb_choice2);
            this.pnl_choices.Controls.Add(this.label3);
            this.pnl_choices.Controls.Add(this.cmb_choice1);
            this.pnl_choices.Controls.Add(this.label2);
            this.pnl_choices.Controls.Add(this.cmb_id);
            this.pnl_choices.Controls.Add(this.label1);
            this.pnl_choices.Location = new System.Drawing.Point(12, 92);
            this.pnl_choices.Name = "pnl_choices";
            this.pnl_choices.Size = new System.Drawing.Size(439, 182);
            this.pnl_choices.TabIndex = 3;
            this.pnl_choices.Visible = false;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(14, 146);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(412, 23);
            this.btn_generate.TabIndex = 4;
            this.btn_generate.Text = "Generate Excel Sheet with Choices";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(146, 120);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(201, 20);
            this.txt_max.TabIndex = 5;
            this.txt_max.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max Per Track: ";
            // 
            // cmb_choice3
            // 
            this.cmb_choice3.FormattingEnabled = true;
            this.cmb_choice3.Location = new System.Drawing.Point(146, 93);
            this.cmb_choice3.Name = "cmb_choice3";
            this.cmb_choice3.Size = new System.Drawing.Size(201, 21);
            this.cmb_choice3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Choice 3:";
            // 
            // cmb_choice2
            // 
            this.cmb_choice2.FormattingEnabled = true;
            this.cmb_choice2.Location = new System.Drawing.Point(146, 66);
            this.cmb_choice2.Name = "cmb_choice2";
            this.cmb_choice2.Size = new System.Drawing.Size(201, 21);
            this.cmb_choice2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choice 2:";
            // 
            // cmb_choice1
            // 
            this.cmb_choice1.FormattingEnabled = true;
            this.cmb_choice1.Location = new System.Drawing.Point(146, 39);
            this.cmb_choice1.Name = "cmb_choice1";
            this.cmb_choice1.Size = new System.Drawing.Size(201, 21);
            this.cmb_choice1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choice 1:";
            // 
            // cmb_id
            // 
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(146, 12);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(201, 21);
            this.cmb_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Column: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblResult.Location = new System.Drawing.Point(12, 277);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(27, 20);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "fff";
            this.lblResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 304);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pnl_choices);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Name = "Form1";
            this.Text = "Google Sheet Registration Mapper";
            this.pnl_choices.ResumeLayout(false);
            this.pnl_choices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnl_choices;
        private System.Windows.Forms.ComboBox cmb_choice3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_choice2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_choice1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResult;
    }
}

