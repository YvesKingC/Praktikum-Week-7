namespace Praktikum_Week_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxKalimatInput = new System.Windows.Forms.TextBox();
            this.txtBoxHuruf1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxHuruf2 = new System.Windows.Forms.TextBox();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Kalimat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Huruf";
            // 
            // txtBoxKalimatInput
            // 
            this.txtBoxKalimatInput.Location = new System.Drawing.Point(150, 39);
            this.txtBoxKalimatInput.Name = "txtBoxKalimatInput";
            this.txtBoxKalimatInput.Size = new System.Drawing.Size(385, 23);
            this.txtBoxKalimatInput.TabIndex = 2;
            // 
            // txtBoxHuruf1
            // 
            this.txtBoxHuruf1.Location = new System.Drawing.Point(150, 107);
            this.txtBoxHuruf1.Name = "txtBoxHuruf1";
            this.txtBoxHuruf1.Size = new System.Drawing.Size(152, 23);
            this.txtBoxHuruf1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Menjadi";
            // 
            // txtBoxHuruf2
            // 
            this.txtBoxHuruf2.Location = new System.Drawing.Point(396, 107);
            this.txtBoxHuruf2.Name = "txtBoxHuruf2";
            this.txtBoxHuruf2.Size = new System.Drawing.Size(139, 23);
            this.txtBoxHuruf2.TabIndex = 5;
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(325, 191);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(210, 23);
            this.btnKonversi.TabIndex = 6;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasil";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(180, 272);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(39, 15);
            this.lblHasil.TabIndex = 8;
            this.lblHasil.Text = "[........]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.txtBoxHuruf2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxHuruf1);
            this.Controls.Add(this.txtBoxKalimatInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoxKalimatInput;
        private TextBox txtBoxHuruf1;
        private Label label3;
        private TextBox txtBoxHuruf2;
        private Button btnKonversi;
        private Label label4;
        private Label lblHasil;
    }
}