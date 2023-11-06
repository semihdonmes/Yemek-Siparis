namespace SemihDonmezProje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnKayit = new Button();
            btnGiris = new Button();
            btnMenu = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.Controls.Add(btnKayit);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 454);
            panel1.TabIndex = 0;
            // 
            // btnKayit
            // 
            btnKayit.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayit.Location = new Point(73, 279);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(132, 43);
            btnKayit.TabIndex = 1;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(73, 214);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(132, 43);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(73, 150);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(132, 43);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Tüm Menüler";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(283, 23);
            label1.TabIndex = 0;
            label1.Text = "Yemekkasası'na Hoşgeldiniz";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(294, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(508, 459);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGiris;
        private Button btnMenu;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnKayit;
        private PictureBox pictureBox2;
    }
}