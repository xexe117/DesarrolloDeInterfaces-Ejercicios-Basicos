namespace ExeBasics_9
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
            this.NumComboBox = new System.Windows.Forms.ComboBox();
            this.EvenButt = new System.Windows.Forms.Button();
            this.OddButt = new System.Windows.Forms.Button();
            this.ReplicaText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumComboBox
            // 
            this.NumComboBox.FormattingEnabled = true;
            this.NumComboBox.Location = new System.Drawing.Point(40, 37);
            this.NumComboBox.Name = "NumComboBox";
            this.NumComboBox.Size = new System.Drawing.Size(121, 24);
            this.NumComboBox.TabIndex = 0;
            this.NumComboBox.SelectedIndexChanged += new System.EventHandler(this.NumComboBox_SelectedIndexChanged);
            // 
            // EvenButt
            // 
            this.EvenButt.Location = new System.Drawing.Point(323, 46);
            this.EvenButt.Name = "EvenButt";
            this.EvenButt.Size = new System.Drawing.Size(88, 23);
            this.EvenButt.TabIndex = 1;
            this.EvenButt.Text = "Even (par)";
            this.EvenButt.UseVisualStyleBackColor = true;
            this.EvenButt.Click += new System.EventHandler(this.EvenButt_Click);
            // 
            // OddButt
            // 
            this.OddButt.Location = new System.Drawing.Point(535, 46);
            this.OddButt.Name = "OddButt";
            this.OddButt.Size = new System.Drawing.Size(103, 23);
            this.OddButt.TabIndex = 2;
            this.OddButt.Text = "Odd (impar)";
            this.OddButt.UseVisualStyleBackColor = true;
            this.OddButt.Click += new System.EventHandler(this.OddButt_Click);
            // 
            // ReplicaText
            // 
            this.ReplicaText.Location = new System.Drawing.Point(40, 365);
            this.ReplicaText.Name = "ReplicaText";
            this.ReplicaText.Size = new System.Drawing.Size(666, 22);
            this.ReplicaText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReplicaText);
            this.Controls.Add(this.OddButt);
            this.Controls.Add(this.EvenButt);
            this.Controls.Add(this.NumComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NumComboBox;
        private System.Windows.Forms.Button EvenButt;
        private System.Windows.Forms.Button OddButt;
        private System.Windows.Forms.TextBox ReplicaText;
    }
}

