namespace EssensGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            buttonF1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 0;
            label1.Text = "Was möchtest du essen?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 72);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 1;
            label2.Text = "Wähle eine Option!";
            // 
            // button1
            // 
            button1.Location = new Point(105, 178);
            button1.Name = "button1";
            button1.Size = new Size(230, 208);
            button1.TabIndex = 2;
            button1.Text = "Auswährts essen";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonF1
            // 
            buttonF1.Location = new Point(458, 178);
            buttonF1.Name = "buttonF1";
            buttonF1.Size = new Size(230, 208);
            buttonF1.TabIndex = 3;
            buttonF1.Text = "Zuhause essen";
            buttonF1.UseVisualStyleBackColor = true;
            buttonF1.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonF1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button buttonF1;
    }
}
