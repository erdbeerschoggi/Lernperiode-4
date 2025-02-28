namespace EssensGenerator
{
    partial class Option
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
            buttonO1 = new Button();
            buttonO2 = new Button();
            buttonO3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 2;
            label1.Text = "Was möchtest du essen?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 68);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 3;
            label2.Text = "Wähle eine Option!";
            // 
            // buttonO1
            // 
            buttonO1.Location = new Point(53, 198);
            buttonO1.Name = "buttonO1";
            buttonO1.Size = new Size(208, 178);
            buttonO1.TabIndex = 4;
            buttonO1.Text = "Fleisch";
            buttonO1.UseVisualStyleBackColor = true;
            buttonO1.Click += button1_Click;
            // 
            // buttonO2
            // 
            buttonO2.Location = new Point(296, 198);
            buttonO2.Name = "buttonO2";
            buttonO2.Size = new Size(208, 178);
            buttonO2.TabIndex = 5;
            buttonO2.Text = "Vegi";
            buttonO2.UseVisualStyleBackColor = true;
            buttonO2.Click += button2_Click;
            // 
            // buttonO3
            // 
            buttonO3.Location = new Point(545, 198);
            buttonO3.Name = "buttonO3";
            buttonO3.Size = new Size(208, 178);
            buttonO3.TabIndex = 6;
            buttonO3.Text = "Vegan";
            buttonO3.UseVisualStyleBackColor = true;
            buttonO3.Click += button3_Click;
            // 
            // Option
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonO3);
            Controls.Add(buttonO2);
            Controls.Add(buttonO1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Option";
            Text = "Option";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonO1;
        private Button buttonO2;
        private Button buttonO3;
    }
}