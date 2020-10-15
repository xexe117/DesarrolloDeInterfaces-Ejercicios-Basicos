namespace ExBasics7
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
            this.ColorcomboBox = new System.Windows.Forms.ComboBox();
            this.ColortextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ColorcomboBox
            // 
            this.ColorcomboBox.FormattingEnabled = true;
            this.ColorcomboBox.Items.AddRange(new object[] {
            "Yellow",
            "Green",
            "Red",
            "Blue",
            "Purple"});
            this.ColorcomboBox.Location = new System.Drawing.Point(170, 210);
            this.ColorcomboBox.Name = "ColorcomboBox";
            this.ColorcomboBox.Size = new System.Drawing.Size(121, 24);
            this.ColorcomboBox.TabIndex = 0;
            this.ColorcomboBox.SelectedIndexChanged += new System.EventHandler(this.ColorcomboBox_SelectedIndexChanged);
            // 
            // ColortextBox
            // 
            this.ColortextBox.Location = new System.Drawing.Point(170, 308);
            this.ColortextBox.Name = "ColortextBox";
            this.ColortextBox.Size = new System.Drawing.Size(331, 22);
            this.ColortextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ColortextBox);
            this.Controls.Add(this.ColorcomboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ColorcomboBox;
        private System.Windows.Forms.TextBox ColortextBox;
    }
}

