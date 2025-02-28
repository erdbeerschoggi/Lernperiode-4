namespace EssensGenerator
{
    partial class Zeit
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
            buttonZ2 = new Button();
            buttonZ1 = new Button();
            buttonZ3 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonZ2
            // 
            buttonZ2.Location = new Point(50, 199);
            buttonZ2.Name = "buttonZ2";
            buttonZ2.Size = new Size(208, 178);
            buttonZ2.TabIndex = 6;
            buttonZ2.Text = "Frühstück";
            buttonZ2.UseVisualStyleBackColor = true;
            buttonZ2.Click += button2_Click;
            // 
            // buttonZ1
            // 
            buttonZ1.Location = new Point(292, 199);
            buttonZ1.Name = "buttonZ1";
            buttonZ1.Size = new Size(208, 178);
            buttonZ1.TabIndex = 7;
            buttonZ1.Text = "Mittagessen";
            buttonZ1.UseVisualStyleBackColor = true;
            buttonZ1.Click += button1_Click;
            // 
            // buttonZ3
            // 
            buttonZ3.Location = new Point(535, 199);
            buttonZ3.Name = "buttonZ3";
            buttonZ3.Size = new Size(208, 178);
            buttonZ3.TabIndex = 8;
            buttonZ3.Text = "Abendessen";
            buttonZ3.UseVisualStyleBackColor = true;
            buttonZ3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 9;
            label1.Text = "Was möchtest du essen?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 59);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 10;
            label2.Text = "Wähle eine Option!";
            // 
            // Zeit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonZ3);
            Controls.Add(buttonZ1);
            Controls.Add(buttonZ2);
            Name = "Zeit";
            Text = "Zeit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonZ2;
        private Button buttonZ1;
        private Button buttonZ3;
        private Label label1;
        private Label label2;
    }
}