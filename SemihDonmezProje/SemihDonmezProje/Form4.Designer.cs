namespace SemihDonmezProje
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            btnKayitOl = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            textBox4 = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnKayitOl
            // 
            btnKayitOl.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(83, 367);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(97, 35);
            btnKayitOl.TabIndex = 4;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 44);
            label1.Name = "label1";
            label1.Size = new Size(283, 23);
            label1.TabIndex = 5;
            label1.Text = "Yemekkasası'na Hoşgeldiniz";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 317);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 293);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 6;
            label4.Text = "Şifre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(110, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 158);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 7;
            label3.Text = "Eposta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(89, 107);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 8;
            label2.Text = "KAYIT OL";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnKayitOl);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 453);
            panel1.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(46, 249);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 225);
            label6.Name = "label6";
            label6.Size = new Size(137, 21);
            label6.TabIndex = 7;
            label6.Text = "Eposta Yeniden";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(516, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(83, 408);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKayitOl;
        private Label label1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private TextBox textBox4;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
    }
}