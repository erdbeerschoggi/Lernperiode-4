namespace GrobesProjekt
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 6;
            label1.Text = "Was möchtest du essen?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 70);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 7;
            label2.Text = "Wähle eine Option!";
            // 
            // button1
            // 
            button1.Location = new Point(47, 183);
            button1.Name = "button1";
            button1.Size = new Size(184, 165);
            button1.TabIndex = 8;
            button1.Text = "Frühstück";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(294, 183);
            button2.Name = "button2";
            button2.Size = new Size(184, 165);
            button2.TabIndex = 9;
            button2.Text = "Mittagessen";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(547, 183);
            button3.Name = "button3";
            button3.Size = new Size(184, 165);
            button3.TabIndex = 10;
            button3.Text = "Abendessen";
            button3.UseVisualStyleBackColor = true;
            // 
            // Zeit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Zeit";
            Text = "Zeit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}