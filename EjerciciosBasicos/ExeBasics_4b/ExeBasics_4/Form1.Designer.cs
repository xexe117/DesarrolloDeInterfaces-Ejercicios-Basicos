namespace ExeBasics_4
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
            this.NumBox1 = new System.Windows.Forms.TextBox();
            this.NumBox2 = new System.Windows.Forms.TextBox();
            this.ResutBox = new System.Windows.Forms.TextBox();
            this.OperationBox4 = new System.Windows.Forms.TextBox();
            this.Calculbutt = new System.Windows.Forms.Button();
            this.Restbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NumBox1
            // 
            this.NumBox1.Location = new System.Drawing.Point(113, 124);
            this.NumBox1.Name = "NumBox1";
            this.NumBox1.Size = new System.Drawing.Size(100, 22);
            this.NumBox1.TabIndex = 0;
            // 
            // NumBox2
            // 
            this.NumBox2.Location = new System.Drawing.Point(113, 184);
            this.NumBox2.Name = "NumBox2";
            this.NumBox2.Size = new System.Drawing.Size(100, 22);
            this.NumBox2.TabIndex = 1;
            // 
            // ResutBox
            // 
            this.ResutBox.Location = new System.Drawing.Point(464, 159);
            this.ResutBox.Name = "ResutBox";
            this.ResutBox.Size = new System.Drawing.Size(100, 22);
            this.ResutBox.TabIndex = 2;
            // 
            // OperationBox4
            // 
            this.OperationBox4.Location = new System.Drawing.Point(331, 243);
            this.OperationBox4.Name = "OperationBox4";
            this.OperationBox4.Size = new System.Drawing.Size(29, 22);
            this.OperationBox4.TabIndex = 3;
            // 
            // Calculbutt
            // 
            this.Calculbutt.Location = new System.Drawing.Point(181, 243);
            this.Calculbutt.Name = "Calculbutt";
            this.Calculbutt.Size = new System.Drawing.Size(75, 23);
            this.Calculbutt.TabIndex = 6;
            this.Calculbutt.Text = "Calcul";
            this.Calculbutt.UseVisualStyleBackColor = true;
            this.Calculbutt.Click += new System.EventHandler(this.Calculbutt_Click);
            // 
            // Restbutton
            // 
            this.Restbutton.Location = new System.Drawing.Point(423, 243);
            this.Restbutton.Name = "Restbutton";
            this.Restbutton.Size = new System.Drawing.Size(75, 23);
            this.Restbutton.TabIndex = 7;
            this.Restbutton.Text = "Reset";
            this.Restbutton.UseVisualStyleBackColor = true;
            this.Restbutton.Click += new System.EventHandler(this.Restbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecciona la operacion a realizar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Operación selecionada";
            // 
            // SelectlistBox
            // 
            this.SelectlistBox.FormattingEnabled = true;
            this.SelectlistBox.ItemHeight = 16;
            this.SelectlistBox.Items.AddRange(new object[] {
            "+",
            "-"});
            this.SelectlistBox.Location = new System.Drawing.Point(339, 106);
            this.SelectlistBox.Name = "SelectlistBox";
            this.SelectlistBox.Size = new System.Drawing.Size(21, 52);
            this.SelectlistBox.TabIndex = 10;
            this.SelectlistBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectlistBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Restbutton);
            this.Controls.Add(this.Calculbutt);
            this.Controls.Add(this.OperationBox4);
            this.Controls.Add(this.ResutBox);
            this.Controls.Add(this.NumBox2);
            this.Controls.Add(this.NumBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumBox1;
        private System.Windows.Forms.TextBox NumBox2;
        private System.Windows.Forms.TextBox ResutBox;
        private System.Windows.Forms.TextBox OperationBox4;
        private System.Windows.Forms.Button Calculbutt;
        private System.Windows.Forms.Button Restbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox SelectlistBox;
    }
}

