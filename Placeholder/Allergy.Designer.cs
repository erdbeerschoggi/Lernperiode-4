namespace EssensGenerator
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
            buttonA1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "Was möchtest du essen?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(689, 25);
            label2.TabIndex = 2;
            label2.Text = "Geben sie ihre Allergien an, wenn sie keine haben dann drücken sie den Knopf \"keine\".";
            // 
            // buttonA1
            // 
            buttonA1.Location = new Point(531, 131);
            buttonA1.Name = "buttonA1";
            buttonA1.Size = new Size(181, 146);
            buttonA1.TabIndex = 3;
            buttonA1.Text = "keine";
            buttonA1.UseVisualStyleBackColor = true;
            buttonA1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(472, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(399, 187);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Ok";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Allergy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(buttonA1);
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
        private Button buttonA1;
        private TextBox textBox1;
        private Button button2;
    }
}