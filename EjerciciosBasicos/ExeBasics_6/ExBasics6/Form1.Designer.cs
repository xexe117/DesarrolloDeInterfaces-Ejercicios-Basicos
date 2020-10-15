namespace ExBasics6
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
            this.Red = new System.Windows.Forms.RadioButton();
            this.Okbuttom = new System.Windows.Forms.Button();
            this.ColortextBox = new System.Windows.Forms.TextBox();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.White = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(85, 55);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(55, 21);
            this.Red.TabIndex = 0;
            this.Red.TabStop = true;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            // 
            // Okbuttom
            // 
            this.Okbuttom.Location = new System.Drawing.Point(85, 242);
            this.Okbuttom.Name = "Okbuttom";
            this.Okbuttom.Size = new System.Drawing.Size(75, 23);
            this.Okbuttom.TabIndex = 1;
            this.Okbuttom.Text = "OK";
            this.Okbuttom.UseVisualStyleBackColor = true;
            this.Okbuttom.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // ColortextBox
            // 
            this.ColortextBox.Location = new System.Drawing.Point(85, 319);
            this.ColortextBox.Name = "ColortextBox";
            this.ColortextBox.Size = new System.Drawing.Size(282, 22);
            this.ColortextBox.TabIndex = 2;
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(85, 115);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(57, 21);
            this.Blue.TabIndex = 3;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            // 
            // White
            // 
            this.White.AutoSize = true;
            this.White.Location = new System.Drawing.Point(85, 175);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(65, 21);
            this.White.TabIndex = 4;
            this.White.TabStop = true;
            this.White.Text = "White";
            this.White.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.White);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.ColortextBox);
            this.Controls.Add(this.Okbuttom);
            this.Controls.Add(this.Red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.Button Okbuttom;
        private System.Windows.Forms.TextBox ColortextBox;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton White;
    }
}

