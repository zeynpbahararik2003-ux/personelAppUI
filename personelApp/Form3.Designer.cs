namespace personelApp
{
    partial class Form3
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
            dgvPersoneller = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKalanIzin = new TextBox();
            txtKullanilanIzin = new TextBox();
            txtAdSoyad = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnYenile = new Button();
            txtMaas = new TextBox();
            textBox4 = new TextBox();
            MAAŞ = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).BeginInit();
            SuspendLayout();
            // 
            // dgvPersoneller
            // 
            dgvPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersoneller.Location = new Point(-5, 12);
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.RowHeadersWidth = 51;
            dgvPersoneller.Size = new Size(736, 322);
            dgvPersoneller.TabIndex = 0;
            dgvPersoneller.CellClick += dgvPersoneller_CellClick;
            dgvPersoneller.CellContentClick += dgvPersoneller_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(775, 73);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(775, 135);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Kullanılan izin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(775, 200);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Kalan İzin:";
            // 
            // txtKalanIzin
            // 
            txtKalanIzin.Location = new Point(936, 200);
            txtKalanIzin.Name = "txtKalanIzin";
            txtKalanIzin.Size = new Size(125, 27);
            txtKalanIzin.TabIndex = 4;
            // 
            // txtKullanilanIzin
            // 
            txtKullanilanIzin.Location = new Point(936, 132);
            txtKullanilanIzin.Name = "txtKullanilanIzin";
            txtKullanilanIzin.Size = new Size(125, 27);
            txtKullanilanIzin.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(936, 66);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 6;
            txtAdSoyad.TextChanged += textBox3_TextChanged;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(61, 459);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(142, 29);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(353, 459);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(140, 29);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(638, 459);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(122, 29);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(892, 459);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(131, 29);
            btnYenile.TabIndex = 10;
            btnYenile.Text = "YENİLE";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(936, 262);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(125, 27);
            txtMaas.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(936, 351);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            // 
            // MAAŞ
            // 
            MAAŞ.AutoSize = true;
            MAAŞ.Location = new Point(775, 269);
            MAAŞ.Name = "MAAŞ";
            MAAŞ.Size = new Size(50, 20);
            MAAŞ.TabIndex = 13;
            MAAŞ.Text = "MAAŞ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(775, 358);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 14;
            label5.Text = "UNVAN";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 528);
            Controls.Add(label5);
            Controls.Add(MAAŞ);
            Controls.Add(textBox4);
            Controls.Add(txtMaas);
            Controls.Add(btnYenile);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtKullanilanIzin);
            Controls.Add(txtKalanIzin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPersoneller);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersoneller;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKalanIzin;
        private TextBox txtKullanilanIzin;
        private TextBox txtAdSoyad;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnYenile;
        private TextBox txtMaas;
        private TextBox textBox4;
        private Label MAAŞ;
        private Label label5;
    }
}