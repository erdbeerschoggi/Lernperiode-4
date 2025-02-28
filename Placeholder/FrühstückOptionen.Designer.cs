namespace EssensGenerator
{
    partial class FrühstückOptionen
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
            buttonFO1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(392, 25);
            label1.TabIndex = 11;
            label1.Text = "Hoffentlich sind sie mit den Optionen zufrieden!";
            // 
            // buttonFO1
            // 
            buttonFO1.Location = new Point(449, 32);
            buttonFO1.Name = "buttonFO1";
            buttonFO1.Size = new Size(297, 34);
            buttonFO1.TabIndex = 14;
            buttonFO1.Text = "Generiere neue Optionen";
            buttonFO1.UseVisualStyleBackColor = true;
            // 
            // FrühstückOptionen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFO1);
            Controls.Add(label1);
            Name = "FrühstückOptionen";
            Text = "FrühstückOptionen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonFO1;
    }
}