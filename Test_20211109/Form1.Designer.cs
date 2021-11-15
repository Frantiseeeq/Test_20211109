namespace Test_20211109
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
            this.btn_Vklad = new System.Windows.Forms.Button();
            this.btn_Vyber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Castka = new System.Windows.Forms.TextBox();
            this.btn_Platba = new System.Windows.Forms.Button();
            this.lbl_Stav = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Jmeno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Limit1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Limit2 = new System.Windows.Forms.Label();
            this.btn_Limit1 = new System.Windows.Forms.Button();
            this.btn_Limit2 = new System.Windows.Forms.Button();
            this.txtBox_Limity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osobní účet";
            // 
            // btn_Vklad
            // 
            this.btn_Vklad.Location = new System.Drawing.Point(319, 168);
            this.btn_Vklad.Name = "btn_Vklad";
            this.btn_Vklad.Size = new System.Drawing.Size(100, 51);
            this.btn_Vklad.TabIndex = 1;
            this.btn_Vklad.Text = "Vložit";
            this.btn_Vklad.UseVisualStyleBackColor = true;
            this.btn_Vklad.Click += new System.EventHandler(this.btn_Vklad_Click);
            // 
            // btn_Vyber
            // 
            this.btn_Vyber.Location = new System.Drawing.Point(319, 270);
            this.btn_Vyber.Name = "btn_Vyber";
            this.btn_Vyber.Size = new System.Drawing.Size(100, 51);
            this.btn_Vyber.TabIndex = 2;
            this.btn_Vyber.Text = "Výběr";
            this.btn_Vyber.UseVisualStyleBackColor = true;
            this.btn_Vyber.Click += new System.EventHandler(this.btn_Vyber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Částka";
            // 
            // txtBox_Castka
            // 
            this.txtBox_Castka.Location = new System.Drawing.Point(319, 97);
            this.txtBox_Castka.Name = "txtBox_Castka";
            this.txtBox_Castka.Size = new System.Drawing.Size(100, 23);
            this.txtBox_Castka.TabIndex = 4;
            // 
            // btn_Platba
            // 
            this.btn_Platba.Location = new System.Drawing.Point(319, 359);
            this.btn_Platba.Name = "btn_Platba";
            this.btn_Platba.Size = new System.Drawing.Size(100, 51);
            this.btn_Platba.TabIndex = 5;
            this.btn_Platba.Text = "Platba";
            this.btn_Platba.UseVisualStyleBackColor = true;
            this.btn_Platba.Click += new System.EventHandler(this.btn_Platba_Click);
            // 
            // lbl_Stav
            // 
            this.lbl_Stav.AutoSize = true;
            this.lbl_Stav.Location = new System.Drawing.Point(79, 332);
            this.lbl_Stav.Name = "lbl_Stav";
            this.lbl_Stav.Size = new System.Drawing.Size(13, 15);
            this.lbl_Stav.TabIndex = 6;
            this.lbl_Stav.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stav";
            // 
            // lbl_Jmeno
            // 
            this.lbl_Jmeno.AccessibleDescription = "";
            this.lbl_Jmeno.AutoSize = true;
            this.lbl_Jmeno.Location = new System.Drawing.Point(79, 306);
            this.lbl_Jmeno.Name = "lbl_Jmeno";
            this.lbl_Jmeno.Size = new System.Drawing.Size(13, 15);
            this.lbl_Jmeno.TabIndex = 8;
            this.lbl_Jmeno.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jméno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maximální výběr";
            // 
            // lbl_Limit1
            // 
            this.lbl_Limit1.AutoSize = true;
            this.lbl_Limit1.Location = new System.Drawing.Point(124, 359);
            this.lbl_Limit1.Name = "lbl_Limit1";
            this.lbl_Limit1.Size = new System.Drawing.Size(38, 15);
            this.lbl_Limit1.TabIndex = 11;
            this.lbl_Limit1.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Maximální platba";
            // 
            // lbl_Limit2
            // 
            this.lbl_Limit2.AutoSize = true;
            this.lbl_Limit2.Location = new System.Drawing.Point(124, 390);
            this.lbl_Limit2.Name = "lbl_Limit2";
            this.lbl_Limit2.Size = new System.Drawing.Size(38, 15);
            this.lbl_Limit2.TabIndex = 13;
            this.lbl_Limit2.Text = "label7";
            // 
            // btn_Limit1
            // 
            this.btn_Limit1.Location = new System.Drawing.Point(559, 182);
            this.btn_Limit1.Name = "btn_Limit1";
            this.btn_Limit1.Size = new System.Drawing.Size(144, 23);
            this.btn_Limit1.TabIndex = 16;
            this.btn_Limit1.Text = "Maximální výběr";
            this.btn_Limit1.UseVisualStyleBackColor = true;
            this.btn_Limit1.Click += new System.EventHandler(this.btn_Limit1_Click);
            // 
            // btn_Limit2
            // 
            this.btn_Limit2.Location = new System.Drawing.Point(559, 229);
            this.btn_Limit2.Name = "btn_Limit2";
            this.btn_Limit2.Size = new System.Drawing.Size(144, 23);
            this.btn_Limit2.TabIndex = 17;
            this.btn_Limit2.Text = "Maximální Platba";
            this.btn_Limit2.UseVisualStyleBackColor = true;
            this.btn_Limit2.Click += new System.EventHandler(this.btn_Limit2_Click);
            // 
            // txtBox_Limity
            // 
            this.txtBox_Limity.Location = new System.Drawing.Point(603, 97);
            this.txtBox_Limity.Name = "txtBox_Limity";
            this.txtBox_Limity.Size = new System.Drawing.Size(100, 23);
            this.txtBox_Limity.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Limit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBox_Limity);
            this.Controls.Add(this.btn_Limit2);
            this.Controls.Add(this.btn_Limit1);
            this.Controls.Add(this.lbl_Limit2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Limit1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Jmeno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Stav);
            this.Controls.Add(this.btn_Platba);
            this.Controls.Add(this.txtBox_Castka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Vyber);
            this.Controls.Add(this.btn_Vklad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Vklad;
        private System.Windows.Forms.Button btn_Vyber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Castka;
        private System.Windows.Forms.Button btn_Platba;
        private System.Windows.Forms.Label lbl_Stav;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Jmeno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Limit1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Limit2;
        private System.Windows.Forms.Button btn_Limit1;
        private System.Windows.Forms.Button btn_Limit2;
        private System.Windows.Forms.TextBox txtBox_Limity;
        private System.Windows.Forms.Label label7;
    }
}

