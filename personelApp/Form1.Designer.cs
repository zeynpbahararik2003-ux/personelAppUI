namespace personelApp
{
    partial class Form1
    {
        
       
       
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
            lblTc = new Label();
            label2 = new Label();
            txtTc = new TextBox();
            txtPassword = new TextBox();
            btnAdmin = new Button();
            btnPersonel = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTc.ForeColor = Color.Purple;
            lblTc.Location = new Point(92, 101);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(46, 28);
            lblTc.TabIndex = 0;
            lblTc.Text = "T.C.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(92, 237);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "ŞİFRE";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(363, 94);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(125, 27);
            txtTc.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(363, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.Purple;
            btnAdmin.Location = new Point(582, 317);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(94, 29);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "ADMİN";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnPersonel
            // 
            btnPersonel.Font = new Font("Segoe UI Symbol", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPersonel.ForeColor = Color.Purple;
            btnPersonel.Location = new Point(582, 382);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(94, 29);
            btnPersonel.TabIndex = 5;
            btnPersonel.Text = "PERSONEL";
            btnPersonel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(274, 24);
            label3.Name = "label3";
            label3.Size = new Size(142, 39);
            label3.TabIndex = 6;
            label3.Text = "PERSONET";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnPersonel);
            Controls.Add(btnAdmin);
            Controls.Add(txtPassword);
            Controls.Add(txtTc);
            Controls.Add(label2);
            Controls.Add(lblTc);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTc;
        private Label label2;
        private TextBox txtTc;
        private TextBox txtPassword;
        private Button btnAdmin;
        private Button btnPersonel;
        private Label label3;
    }
}
