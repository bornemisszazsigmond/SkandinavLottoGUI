namespace SkandinavLottoGUI
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
            this.labelKerem = new System.Windows.Forms.Label();
            this.textBoxSzamok = new System.Windows.Forms.TextBox();
            this.checkBoxNemMegfeleloSzamok = new System.Windows.Forms.CheckBox();
            this.checkBoxTippekSzama = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonJatek = new System.Windows.Forms.Button();
            this.checkBoxAzonosSzamok = new System.Windows.Forms.CheckBox();
            this.labelNemJoSzam = new System.Windows.Forms.Label();
            this.labelSzamDb = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxKezi = new System.Windows.Forms.TextBox();
            this.textBoxGepi = new System.Windows.Forms.TextBox();
            this.labelKezi = new System.Windows.Forms.Label();
            this.labelGepi = new System.Windows.Forms.Label();
            this.labelGepiTalaltDb = new System.Windows.Forms.Label();
            this.labelKeziTalaltDb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKerem
            // 
            this.labelKerem.AutoSize = true;
            this.labelKerem.Location = new System.Drawing.Point(30, 33);
            this.labelKerem.Name = "labelKerem";
            this.labelKerem.Size = new System.Drawing.Size(165, 13);
            this.labelKerem.TabIndex = 0;
            this.labelKerem.Text = "Kérem a megjátszandó számokat:";
            // 
            // textBoxSzamok
            // 
            this.textBoxSzamok.Location = new System.Drawing.Point(201, 30);
            this.textBoxSzamok.Name = "textBoxSzamok";
            this.textBoxSzamok.Size = new System.Drawing.Size(177, 20);
            this.textBoxSzamok.TabIndex = 1;
            this.textBoxSzamok.TextChanged += new System.EventHandler(this.textBoxSzamok_TextChanged);
            // 
            // checkBoxNemMegfeleloSzamok
            // 
            this.checkBoxNemMegfeleloSzamok.AutoSize = true;
            this.checkBoxNemMegfeleloSzamok.Enabled = false;
            this.checkBoxNemMegfeleloSzamok.Location = new System.Drawing.Point(33, 76);
            this.checkBoxNemMegfeleloSzamok.Name = "checkBoxNemMegfeleloSzamok";
            this.checkBoxNemMegfeleloSzamok.Size = new System.Drawing.Size(135, 17);
            this.checkBoxNemMegfeleloSzamok.TabIndex = 2;
            this.checkBoxNemMegfeleloSzamok.Text = "Nem megfelelő számok";
            this.checkBoxNemMegfeleloSzamok.UseVisualStyleBackColor = true;
            // 
            // checkBoxTippekSzama
            // 
            this.checkBoxTippekSzama.AutoSize = true;
            this.checkBoxTippekSzama.Enabled = false;
            this.checkBoxTippekSzama.Location = new System.Drawing.Point(33, 99);
            this.checkBoxTippekSzama.Name = "checkBoxTippekSzama";
            this.checkBoxTippekSzama.Size = new System.Drawing.Size(92, 17);
            this.checkBoxTippekSzama.TabIndex = 3;
            this.checkBoxTippekSzama.Text = "Tippek száma";
            this.checkBoxTippekSzama.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonJatek);
            this.groupBox1.Controls.Add(this.checkBoxAzonosSzamok);
            this.groupBox1.Controls.Add(this.labelNemJoSzam);
            this.groupBox1.Controls.Add(this.labelSzamDb);
            this.groupBox1.Controls.Add(this.checkBoxTippekSzama);
            this.groupBox1.Controls.Add(this.checkBoxNemMegfeleloSzamok);
            this.groupBox1.Controls.Add(this.textBoxSzamok);
            this.groupBox1.Controls.Add(this.labelKerem);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 157);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Játékos számai";
            // 
            // buttonJatek
            // 
            this.buttonJatek.Enabled = false;
            this.buttonJatek.Location = new System.Drawing.Point(296, 114);
            this.buttonJatek.Name = "buttonJatek";
            this.buttonJatek.Size = new System.Drawing.Size(82, 25);
            this.buttonJatek.TabIndex = 8;
            this.buttonJatek.Text = "Játék";
            this.buttonJatek.UseVisualStyleBackColor = true;
            this.buttonJatek.Click += new System.EventHandler(this.buttonJatek_Click);
            // 
            // checkBoxAzonosSzamok
            // 
            this.checkBoxAzonosSzamok.AutoSize = true;
            this.checkBoxAzonosSzamok.Enabled = false;
            this.checkBoxAzonosSzamok.Location = new System.Drawing.Point(33, 122);
            this.checkBoxAzonosSzamok.Name = "checkBoxAzonosSzamok";
            this.checkBoxAzonosSzamok.Size = new System.Drawing.Size(100, 17);
            this.checkBoxAzonosSzamok.TabIndex = 7;
            this.checkBoxAzonosSzamok.Text = "Azonos számok";
            this.checkBoxAzonosSzamok.UseVisualStyleBackColor = true;
            // 
            // labelNemJoSzam
            // 
            this.labelNemJoSzam.AutoSize = true;
            this.labelNemJoSzam.Location = new System.Drawing.Point(174, 77);
            this.labelNemJoSzam.Name = "labelNemJoSzam";
            this.labelNemJoSzam.Size = new System.Drawing.Size(0, 13);
            this.labelNemJoSzam.TabIndex = 6;
            // 
            // labelSzamDb
            // 
            this.labelSzamDb.AutoSize = true;
            this.labelSzamDb.Location = new System.Drawing.Point(131, 100);
            this.labelSzamDb.Name = "labelSzamDb";
            this.labelSzamDb.Size = new System.Drawing.Size(0, 13);
            this.labelSzamDb.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelKeziTalaltDb);
            this.groupBox2.Controls.Add(this.labelGepiTalaltDb);
            this.groupBox2.Controls.Add(this.textBoxKezi);
            this.groupBox2.Controls.Add(this.textBoxGepi);
            this.groupBox2.Controls.Add(this.labelKezi);
            this.groupBox2.Controls.Add(this.labelGepi);
            this.groupBox2.Location = new System.Drawing.Point(27, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorsolás";
            // 
            // textBoxKezi
            // 
            this.textBoxKezi.Location = new System.Drawing.Point(137, 59);
            this.textBoxKezi.Name = "textBoxKezi";
            this.textBoxKezi.Size = new System.Drawing.Size(177, 20);
            this.textBoxKezi.TabIndex = 3;
            this.textBoxKezi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGepi
            // 
            this.textBoxGepi.Location = new System.Drawing.Point(137, 26);
            this.textBoxGepi.Name = "textBoxGepi";
            this.textBoxGepi.Size = new System.Drawing.Size(177, 20);
            this.textBoxGepi.TabIndex = 2;
            this.textBoxGepi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelKezi
            // 
            this.labelKezi.Location = new System.Drawing.Point(95, 62);
            this.labelKezi.Name = "labelKezi";
            this.labelKezi.Size = new System.Drawing.Size(38, 13);
            this.labelKezi.TabIndex = 1;
            this.labelKezi.Text = "Kézi:";
            this.labelKezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGepi
            // 
            this.labelGepi.Location = new System.Drawing.Point(99, 29);
            this.labelGepi.Name = "labelGepi";
            this.labelGepi.Size = new System.Drawing.Size(34, 13);
            this.labelGepi.TabIndex = 0;
            this.labelGepi.Text = "Gépi:";
            this.labelGepi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGepiTalaltDb
            // 
            this.labelGepiTalaltDb.AutoSize = true;
            this.labelGepiTalaltDb.Location = new System.Drawing.Point(329, 29);
            this.labelGepiTalaltDb.Name = "labelGepiTalaltDb";
            this.labelGepiTalaltDb.Size = new System.Drawing.Size(0, 13);
            this.labelGepiTalaltDb.TabIndex = 6;
            // 
            // labelKeziTalaltDb
            // 
            this.labelKeziTalaltDb.AutoSize = true;
            this.labelKeziTalaltDb.Location = new System.Drawing.Point(329, 62);
            this.labelKeziTalaltDb.Name = "labelKeziTalaltDb";
            this.labelKeziTalaltDb.Size = new System.Drawing.Size(0, 13);
            this.labelKeziTalaltDb.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 307);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Skandináv lottó";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelKerem;
        private System.Windows.Forms.TextBox textBoxSzamok;
        private System.Windows.Forms.CheckBox checkBoxNemMegfeleloSzamok;
        private System.Windows.Forms.CheckBox checkBoxTippekSzama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSzamDb;
        private System.Windows.Forms.Label labelNemJoSzam;
        private System.Windows.Forms.CheckBox checkBoxAzonosSzamok;
        private System.Windows.Forms.Button buttonJatek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxKezi;
        private System.Windows.Forms.TextBox textBoxGepi;
        private System.Windows.Forms.Label labelKezi;
        private System.Windows.Forms.Label labelGepi;
        private System.Windows.Forms.Label labelGepiTalaltDb;
        private System.Windows.Forms.Label labelKeziTalaltDb;
    }
}

