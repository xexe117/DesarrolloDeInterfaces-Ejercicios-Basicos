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
            this.PrimertextBox = new System.Windows.Forms.TextBox();
            this.SegontextBox = new System.Windows.Forms.TextBox();
            this.ResultattextBox = new System.Windows.Forms.TextBox();
            this.Operacio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Subs = new System.Windows.Forms.Button();
            this.Calcul = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrimertextBox
            // 
            this.PrimertextBox.Location = new System.Drawing.Point(113, 124);
            this.PrimertextBox.Name = "PrimertextBox";
            this.PrimertextBox.Size = new System.Drawing.Size(100, 22);
            this.PrimertextBox.TabIndex = 0;
            // 
            // SegontextBox
            // 
            this.SegontextBox.Location = new System.Drawing.Point(113, 184);
            this.SegontextBox.Name = "SegontextBox";
            this.SegontextBox.Size = new System.Drawing.Size(100, 22);
            this.SegontextBox.TabIndex = 1;
            // 
            // ResultattextBox
            // 
            this.ResultattextBox.Location = new System.Drawing.Point(464, 159);
            this.ResultattextBox.Name = "ResultattextBox";
            this.ResultattextBox.Size = new System.Drawing.Size(100, 22);
            this.ResultattextBox.TabIndex = 2;
            // 
            // Operacio
            // 
            this.Operacio.Location = new System.Drawing.Point(331, 243);
            this.Operacio.Name = "Operacio";
            this.Operacio.Size = new System.Drawing.Size(29, 22);
            this.Operacio.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Subs
            // 
            this.Subs.Location = new System.Drawing.Point(307, 159);
            this.Subs.Name = "Subs";
            this.Subs.Size = new System.Drawing.Size(75, 23);
            this.Subs.TabIndex = 5;
            this.Subs.Text = "Substract";
            this.Subs.UseVisualStyleBackColor = true;
            this.Subs.Click += new System.EventHandler(this.Subs_Click);
            // 
            // Calcul
            // 
            this.Calcul.Location = new System.Drawing.Point(181, 243);
            this.Calcul.Name = "Calcul";
            this.Calcul.Size = new System.Drawing.Size(75, 23);
            this.Calcul.TabIndex = 6;
            this.Calcul.Text = "Calculate";
            this.Calcul.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Calcul.UseVisualStyleBackColor = true;
            this.Calcul.Click += new System.EventHandler(this.Calul_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.Location = new System.Drawing.Point(423, 243);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(75, 23);
            this.Resetbutton.TabIndex = 7;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Reset_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Calcul);
            this.Controls.Add(this.Subs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Operacio);
            this.Controls.Add(this.ResultattextBox);
            this.Controls.Add(this.SegontextBox);
            this.Controls.Add(this.PrimertextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PrimertextBox;
        private System.Windows.Forms.TextBox SegontextBox;
        private System.Windows.Forms.TextBox ResultattextBox;
        private System.Windows.Forms.TextBox Operacio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Subs;
        private System.Windows.Forms.Button Calcul;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

