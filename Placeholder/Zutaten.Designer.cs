namespace EssensGenerator
{
    partial class Zutaten
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
            textBox1 = new TextBox();
            buttonZU1 = new Button();
            buttonZU2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 10;
            label1.Text = "Was möchtest du essen?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 67);
            label2.Name = "label2";
            label2.Size = new Size(419, 25);
            label2.TabIndex = 11;
            label2.Text = "Geben sie Zutaten, mit den sie kochen möchten, an.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(508, 31);
            textBox1.TabIndex = 12;
            // 
            // buttonZU1
            // 
            buttonZU1.Location = new Point(426, 186);
            buttonZU1.Name = "buttonZU1";
            buttonZU1.Size = new Size(112, 34);
            buttonZU1.TabIndex = 13;
            buttonZU1.Text = "Ok";
            buttonZU1.UseVisualStyleBackColor = true;
            buttonZU1.Click += button1_Click;
            // 
            // buttonZU2
            // 
            buttonZU2.Location = new Point(597, 139);
            buttonZU2.Name = "buttonZU2";
            buttonZU2.Size = new Size(159, 128);
            buttonZU2.TabIndex = 14;
            buttonZU2.Text = " Egal";
            buttonZU2.UseVisualStyleBackColor = true;
            buttonZU2.Click += button2_Click;
            // 
            // Zutaten
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonZU2);
            Controls.Add(buttonZU1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Zutaten";
            Text = "Zutaten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button buttonZU1;
        private Button buttonZU2;
    }
}