namespace HarcosokApplication
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
            this.harcosNeveTextBox = new System.Windows.Forms.TextBox();
            this.btnHarcosLetrehozas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kepessegLeirasaTextBox = new System.Windows.Forms.TextBox();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcos létrehozása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // harcosNeveTextBox
            // 
            this.harcosNeveTextBox.Location = new System.Drawing.Point(59, 54);
            this.harcosNeveTextBox.Name = "harcosNeveTextBox";
            this.harcosNeveTextBox.Size = new System.Drawing.Size(166, 20);
            this.harcosNeveTextBox.TabIndex = 2;
            // 
            // btnHarcosLetrehozas
            // 
            this.btnHarcosLetrehozas.Location = new System.Drawing.Point(245, 51);
            this.btnHarcosLetrehozas.Name = "btnHarcosLetrehozas";
            this.btnHarcosLetrehozas.Size = new System.Drawing.Size(75, 23);
            this.btnHarcosLetrehozas.TabIndex = 3;
            this.btnHarcosLetrehozas.Text = "Létrehozás";
            this.btnHarcosLetrehozas.UseVisualStyleBackColor = true;
            this.btnHarcosLetrehozas.Click += new System.EventHandler(this.btnHarcosLetrehozas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Képesség hozzáadása";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Használó:";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(86, 136);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(178, 21);
            this.hasznaloComboBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Név:";
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(86, 189);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(178, 20);
            this.kepessegNeveTextBox.TabIndex = 8;
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(23, 215);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaad.TabIndex = 9;
            this.btnHozzaad.Text = "Hozzáad";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(320, 136);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(280, 73);
            this.leirasTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Leírás:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Harcosok:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Képességei:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Képesség leírása";
            // 
            // kepessegLeirasaTextBox
            // 
            this.kepessegLeirasaTextBox.Location = new System.Drawing.Point(457, 308);
            this.kepessegLeirasaTextBox.Multiline = true;
            this.kepessegLeirasaTextBox.Name = "kepessegLeirasaTextBox";
            this.kepessegLeirasaTextBox.Size = new System.Drawing.Size(254, 100);
            this.kepessegLeirasaTextBox.TabIndex = 15;
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(259, 489);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(100, 23);
            this.btnTorles.TabIndex = 16;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(591, 414);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(120, 23);
            this.btnModosit.TabIndex = 17;
            this.btnModosit.Text = "Módosít";
            this.btnModosit.UseVisualStyleBackColor = true;
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.Location = new System.Drawing.Point(259, 308);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(171, 173);
            this.kepessegekListBox.TabIndex = 18;
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Location = new System.Drawing.Point(23, 308);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(202, 173);
            this.harcosokListBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 524);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.kepessegLeirasaTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.kepessegNeveTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hasznaloComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHarcosLetrehozas);
            this.Controls.Add(this.harcosNeveTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox harcosNeveTextBox;
        private System.Windows.Forms.Button btnHarcosLetrehozas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kepessegLeirasaTextBox;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.ListBox harcosokListBox;
    }
}

