﻿namespace GrobesProjekt
{
    partial class Allergy
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 5;
            label1.Text = "Was möchtest du essen?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 67);
            label2.Name = "label2";
            label2.Size = new Size(672, 25);
            label2.TabIndex = 6;
            label2.Text = "Geben sie ihre Allergien an, wenn sie keine haben dan drücken sie den knopf 'keine'.";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(522, 117);
            button1.Name = "button1";
            button1.Size = new Size(173, 130);
            button1.TabIndex = 7;
            button1.Text = "keine";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 31);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Allergy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Allergy";
            Text = "Allergy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
    }
}