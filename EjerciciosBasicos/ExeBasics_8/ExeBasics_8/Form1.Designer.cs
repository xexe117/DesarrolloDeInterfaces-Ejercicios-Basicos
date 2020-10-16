namespace ExeBasics_8
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
            this.Class1 = new System.Windows.Forms.Button();
            this.Class2 = new System.Windows.Forms.Button();
            this.ClearBut = new System.Windows.Forms.Button();
            this.StudentsBox = new System.Windows.Forms.ListBox();
            this.redactBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Class1
            // 
            this.Class1.Location = new System.Drawing.Point(65, 254);
            this.Class1.Name = "Class1";
            this.Class1.Size = new System.Drawing.Size(111, 23);
            this.Class1.TabIndex = 0;
            this.Class1.Text = "Classrom1";
            this.Class1.UseVisualStyleBackColor = true;
            this.Class1.Click += new System.EventHandler(this.Class1_Click);
            // 
            // Class2
            // 
            this.Class2.Location = new System.Drawing.Point(65, 301);
            this.Class2.Name = "Class2";
            this.Class2.Size = new System.Drawing.Size(111, 23);
            this.Class2.TabIndex = 1;
            this.Class2.Text = "Classrom 2\r\n";
            this.Class2.UseVisualStyleBackColor = true;
            this.Class2.Click += new System.EventHandler(this.Class2_Click);
            // 
            // ClearBut
            // 
            this.ClearBut.Location = new System.Drawing.Point(65, 360);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(111, 23);
            this.ClearBut.TabIndex = 2;
            this.ClearBut.Text = "Clear List";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // StudentsBox
            // 
            this.StudentsBox.FormattingEnabled = true;
            this.StudentsBox.ItemHeight = 16;
            this.StudentsBox.Items.AddRange(new object[] {
            "Juan",
            "Maria",
            "Pepa"});
            this.StudentsBox.Location = new System.Drawing.Point(56, 44);
            this.StudentsBox.Name = "StudentsBox";
            this.StudentsBox.Size = new System.Drawing.Size(120, 164);
            this.StudentsBox.TabIndex = 3;
            this.StudentsBox.SelectedIndexChanged += new System.EventHandler(this.StudentsBox_SelectedIndexChanged);
            // 
            // redactBox
            // 
            this.redactBox.Location = new System.Drawing.Point(261, 55);
            this.redactBox.Name = "redactBox";
            this.redactBox.Size = new System.Drawing.Size(227, 22);
            this.redactBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.redactBox);
            this.Controls.Add(this.StudentsBox);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.Class2);
            this.Controls.Add(this.Class1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Class1;
        private System.Windows.Forms.Button Class2;
        private System.Windows.Forms.Button ClearBut;
        private System.Windows.Forms.ListBox StudentsBox;
        private System.Windows.Forms.TextBox redactBox;
    }
}

