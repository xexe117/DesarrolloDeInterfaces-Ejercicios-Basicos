namespace ExeBasics5
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
            this.Mause = new System.Windows.Forms.CheckBox();
            this.Cat = new System.Windows.Forms.CheckBox();
            this.Dog = new System.Windows.Forms.CheckBox();
            this.Okbutton = new System.Windows.Forms.Button();
            this.AnimaltextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Mause
            // 
            this.Mause.AutoSize = true;
            this.Mause.Location = new System.Drawing.Point(137, 80);
            this.Mause.Name = "Mause";
            this.Mause.Size = new System.Drawing.Size(72, 21);
            this.Mause.TabIndex = 0;
            this.Mause.Text = "Mause";
            this.Mause.UseVisualStyleBackColor = true;
            // 
            // Cat
            // 
            this.Cat.AutoSize = true;
            this.Cat.Location = new System.Drawing.Point(137, 135);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(51, 21);
            this.Cat.TabIndex = 1;
            this.Cat.Text = "Cat";
            this.Cat.UseVisualStyleBackColor = true;
            // 
            // Dog
            // 
            this.Dog.AutoSize = true;
            this.Dog.Location = new System.Drawing.Point(137, 195);
            this.Dog.Name = "Dog";
            this.Dog.Size = new System.Drawing.Size(56, 21);
            this.Dog.TabIndex = 2;
            this.Dog.Text = "Dog";
            this.Dog.UseVisualStyleBackColor = true;
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(137, 265);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 23);
            this.Okbutton.TabIndex = 3;
            this.Okbutton.Text = "Ok";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // AnimaltextBox
            // 
            this.AnimaltextBox.Location = new System.Drawing.Point(137, 329);
            this.AnimaltextBox.Name = "AnimaltextBox";
            this.AnimaltextBox.Size = new System.Drawing.Size(477, 22);
            this.AnimaltextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnimaltextBox);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.Dog);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.Mause);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Mause;
        private System.Windows.Forms.CheckBox Cat;
        private System.Windows.Forms.CheckBox Dog;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.TextBox AnimaltextBox;
    }
}

