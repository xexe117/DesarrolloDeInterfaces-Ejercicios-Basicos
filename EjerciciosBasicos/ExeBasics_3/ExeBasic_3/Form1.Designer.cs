namespace ExeBasic_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OpBox1 = new System.Windows.Forms.TextBox();
            this.OpBox2 = new System.Windows.Forms.TextBox();
            this.OpBox3 = new System.Windows.Forms.TextBox();
            this.SumButt = new System.Windows.Forms.Button();
            this.ResButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operand2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OpBox1
            // 
            this.OpBox1.Location = new System.Drawing.Point(332, 95);
            this.OpBox1.Name = "OpBox1";
            this.OpBox1.Size = new System.Drawing.Size(100, 22);
            this.OpBox1.TabIndex = 3;
            this.OpBox1.Tag = "un";
            this.OpBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OpBox2
            // 
            this.OpBox2.Location = new System.Drawing.Point(332, 168);
            this.OpBox2.Name = "OpBox2";
            this.OpBox2.Size = new System.Drawing.Size(100, 22);
            this.OpBox2.TabIndex = 4;
            this.OpBox2.Tag = "dos";
            this.OpBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // OpBox3
            // 
            this.OpBox3.Location = new System.Drawing.Point(332, 235);
            this.OpBox3.Name = "OpBox3";
            this.OpBox3.Size = new System.Drawing.Size(100, 22);
            this.OpBox3.TabIndex = 5;
            this.OpBox3.Tag = "resul";
            this.OpBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SumButt
            // 
            this.SumButt.Location = new System.Drawing.Point(204, 202);
            this.SumButt.Name = "SumButt";
            this.SumButt.Size = new System.Drawing.Size(75, 23);
            this.SumButt.TabIndex = 6;
            this.SumButt.Text = "+";
            this.SumButt.UseVisualStyleBackColor = true;
            this.SumButt.Click += new System.EventHandler(this.SumButt_Click);
            // 
            // ResButt
            // 
            this.ResButt.Location = new System.Drawing.Point(453, 202);
            this.ResButt.Name = "ResButt";
            this.ResButt.Size = new System.Drawing.Size(75, 23);
            this.ResButt.TabIndex = 7;
            this.ResButt.Text = "Resta";
            this.ResButt.UseVisualStyleBackColor = true;
            this.ResButt.Click += new System.EventHandler(this.ResButt2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResButt);
            this.Controls.Add(this.SumButt);
            this.Controls.Add(this.OpBox3);
            this.Controls.Add(this.OpBox2);
            this.Controls.Add(this.OpBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OpBox1;
        private System.Windows.Forms.TextBox OpBox2;
        private System.Windows.Forms.TextBox OpBox3;
        private System.Windows.Forms.Button SumButt;
        private System.Windows.Forms.Button ResButt;
    }
}

