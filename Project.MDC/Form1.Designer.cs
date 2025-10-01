namespace Project.MDC
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            PBPERSONAGEM = new PictureBox();
            CBUNI = new ComboBox();
            CBPERSONAGEM = new ComboBox();
            label3 = new Label();
            lblcharacter = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBPERSONAGEM).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.marvel_e_dc;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 206);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 246);
            label1.Name = "label1";
            label1.Size = new Size(159, 35);
            label1.TabIndex = 1;
            label1.Text = "Universe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 309);
            label2.Name = "label2";
            label2.Size = new Size(186, 35);
            label2.TabIndex = 2;
            label2.Text = "Character:";
            // 
            // PBPERSONAGEM
            // 
            PBPERSONAGEM.Location = new Point(535, 51);
            PBPERSONAGEM.Name = "PBPERSONAGEM";
            PBPERSONAGEM.Size = new Size(492, 589);
            PBPERSONAGEM.TabIndex = 5;
            PBPERSONAGEM.TabStop = false;
            PBPERSONAGEM.Click += PBPERSONAGEM_Click;
            // 
            // CBUNI
            // 
            CBUNI.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBUNI.FormattingEnabled = true;
            CBUNI.Items.AddRange(new object[] { "MARVEL", "DC" });
            CBUNI.Location = new Point(198, 244);
            CBUNI.Name = "CBUNI";
            CBUNI.Size = new Size(208, 37);
            CBUNI.TabIndex = 6;
            CBUNI.SelectedIndexChanged += CBUNI_SelectedIndexChanged;
            // 
            // CBPERSONAGEM
            // 
            CBPERSONAGEM.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBPERSONAGEM.FormattingEnabled = true;
            CBPERSONAGEM.Location = new Point(221, 307);
            CBPERSONAGEM.Name = "CBPERSONAGEM";
            CBPERSONAGEM.Size = new Size(217, 37);
            CBPERSONAGEM.TabIndex = 7;
            CBPERSONAGEM.SelectedIndexChanged += CBPERSONAGEM_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 407);
            label3.Name = "label3";
            label3.Size = new Size(0, 29);
            label3.TabIndex = 8;
            // 
            // lblcharacter
            // 
            lblcharacter.BackColor = Color.Black;
            lblcharacter.Font = new Font("BankGothic Md BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcharacter.ForeColor = Color.White;
            lblcharacter.Location = new Point(29, 369);
            lblcharacter.Name = "lblcharacter";
            lblcharacter.Size = new Size(409, 319);
            lblcharacter.TabIndex = 9;
            lblcharacter.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaa\r\naaaaaaaaaaaaaaaaaaaaaaaaaa\r\naaaaaaaaaaaaaaaaaaaaaaaaaa\r\naaaaaaaaaaaaaaaaaaaaaaaaaa\r\n";
            lblcharacter.Visible = false;
            lblcharacter.Click += lblcharacter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1096, 728);
            Controls.Add(lblcharacter);
            Controls.Add(label3);
            Controls.Add(CBPERSONAGEM);
            Controls.Add(CBUNI);
            Controls.Add(PBPERSONAGEM);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBPERSONAGEM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox PBPERSONAGEM;
        private ComboBox CBUNI;
        private ComboBox CBPERSONAGEM;
        private Label label3;
        private Label lblcharacter;
    }
}
