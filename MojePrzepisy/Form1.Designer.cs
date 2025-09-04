namespace MojePrzepisy
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
            label1 = new Label();
            txtTytul = new TextBox();
            label2 = new Label();
            cmbKategoria = new ComboBox();
            label3 = new Label();
            txtSkladniki = new TextBox();
            label4 = new Label();
            txtInstrukcje = new TextBox();
            chkUlubiony = new CheckBox();
            btnNowy = new Button();
            btnZapisz = new Button();
            btnUsun = new Button();
            label5 = new Label();
            txtSzukaj = new TextBox();
            lstPrzepisy = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 21);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Tytuł:";
            // 
            // txtTytul
            // 
            txtTytul.BackColor = SystemColors.ActiveCaption;
            txtTytul.ForeColor = SystemColors.ControlLightLight;
            txtTytul.Location = new Point(165, 13);
            txtTytul.Name = "txtTytul";
            txtTytul.Size = new Size(350, 23);
            txtTytul.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 51);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Kategoria:";
            // 
            // cmbKategoria
            // 
            cmbKategoria.BackColor = SystemColors.InactiveCaption;
            cmbKategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoria.ForeColor = SystemColors.ControlLightLight;
            cmbKategoria.FormattingEnabled = true;
            cmbKategoria.Location = new Point(203, 51);
            cmbKategoria.Name = "cmbKategoria";
            cmbKategoria.Size = new Size(200, 23);
            cmbKategoria.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 141);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Składniki:";
            // 
            // txtSkladniki
            // 
            txtSkladniki.Location = new Point(124, 172);
            txtSkladniki.Multiline = true;
            txtSkladniki.Name = "txtSkladniki";
            txtSkladniki.ScrollBars = ScrollBars.Vertical;
            txtSkladniki.Size = new Size(350, 100);
            txtSkladniki.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 287);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 6;
            label4.Text = "Instrukcje:";
            // 
            // txtInstrukcje
            // 
            txtInstrukcje.Location = new Point(124, 315);
            txtInstrukcje.Multiline = true;
            txtInstrukcje.Name = "txtInstrukcje";
            txtInstrukcje.ScrollBars = ScrollBars.Vertical;
            txtInstrukcje.Size = new Size(350, 140);
            txtInstrukcje.TabIndex = 7;
            // 
            // chkUlubiony
            // 
            chkUlubiony.AutoSize = true;
            chkUlubiony.Location = new Point(123, 478);
            chkUlubiony.Name = "chkUlubiony";
            chkUlubiony.Size = new Size(74, 19);
            chkUlubiony.TabIndex = 8;
            chkUlubiony.Text = "Ulubione";
            chkUlubiony.UseVisualStyleBackColor = true;
            // 
            // btnNowy
            // 
            btnNowy.Location = new Point(124, 524);
            btnNowy.Name = "btnNowy";
            btnNowy.Size = new Size(75, 23);
            btnNowy.TabIndex = 9;
            btnNowy.Text = "Nowy (Ctrl+N";
            btnNowy.UseVisualStyleBackColor = true;
            btnNowy.Click += btnNowy_Click;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(123, 553);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(75, 23);
            btnZapisz.TabIndex = 10;
            btnZapisz.Text = "Zapisz (Ctrl+S)";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(123, 582);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(75, 23);
            btnUsun.TabIndex = 11;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(630, 21);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 12;
            label5.Text = "Szukaj:";
            // 
            // txtSzukaj
            // 
            txtSzukaj.Location = new Point(689, 18);
            txtSzukaj.Name = "txtSzukaj";
            txtSzukaj.Size = new Size(200, 23);
            txtSzukaj.TabIndex = 13;
            // 
            // lstPrzepisy
            // 
            lstPrzepisy.FormattingEnabled = true;
            lstPrzepisy.ItemHeight = 15;
            lstPrzepisy.Location = new Point(633, 65);
            lstPrzepisy.Name = "lstPrzepisy";
            lstPrzepisy.Size = new Size(260, 409);
            lstPrzepisy.TabIndex = 14;
            lstPrzepisy.SelectedIndexChanged += lstPrzepisy_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1084, 661);
            Controls.Add(lstPrzepisy);
            Controls.Add(txtSzukaj);
            Controls.Add(label5);
            Controls.Add(btnUsun);
            Controls.Add(btnZapisz);
            Controls.Add(btnNowy);
            Controls.Add(chkUlubiony);
            Controls.Add(txtInstrukcje);
            Controls.Add(label4);
            Controls.Add(txtSkladniki);
            Controls.Add(label3);
            Controls.Add(cmbKategoria);
            Controls.Add(label2);
            Controls.Add(txtTytul);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Moje Przepisy";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTytul;
        private Label label2;
        private ComboBox cmbKategoria;
        private Label label3;
        private TextBox txtSkladniki;
        private Label label4;
        private TextBox txtInstrukcje;
        private CheckBox chkUlubiony;
        private Button btnNowy;
        private Button btnZapisz;
        private Button btnUsun;
        private Label label5;
        private TextBox txtSzukaj;
        private ListBox lstPrzepisy;
    }
}
