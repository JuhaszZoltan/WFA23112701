namespace WFA003
{
    partial class MainForm
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
            lblUI01 = new Label();
            tbxNev = new TextBox();
            cbxNyel = new ComboBox();
            gbxAdatok = new GroupBox();
            tbxSzulEv = new TextBox();
            lblUI02 = new Label();
            lblUI03 = new Label();
            lblUI04 = new Label();
            cbxSzint = new ComboBox();
            btnAdatbevitel = new Button();
            btnKiiras = new Button();
            gbxAdatok.SuspendLayout();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(70, 55);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(49, 25);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Név:";
            // 
            // tbxNev
            // 
            tbxNev.Location = new Point(134, 52);
            tbxNev.Name = "tbxNev";
            tbxNev.Size = new Size(218, 32);
            tbxNev.TabIndex = 1;
            // 
            // cbxNyel
            // 
            cbxNyel.FormattingEnabled = true;
            cbxNyel.Items.AddRange(new object[] { "angol", "francia", "német" });
            cbxNyel.Location = new Point(134, 204);
            cbxNyel.Name = "cbxNyel";
            cbxNyel.Size = new Size(158, 33);
            cbxNyel.TabIndex = 3;
            cbxNyel.Text = "válassz...";
            // 
            // gbxAdatok
            // 
            gbxAdatok.Controls.Add(btnAdatbevitel);
            gbxAdatok.Controls.Add(lblUI02);
            gbxAdatok.Controls.Add(lblUI04);
            gbxAdatok.Controls.Add(cbxSzint);
            gbxAdatok.Controls.Add(lblUI03);
            gbxAdatok.Controls.Add(cbxNyel);
            gbxAdatok.Controls.Add(tbxNev);
            gbxAdatok.Controls.Add(tbxSzulEv);
            gbxAdatok.Controls.Add(lblUI01);
            gbxAdatok.Location = new Point(12, 12);
            gbxAdatok.Name = "gbxAdatok";
            gbxAdatok.Size = new Size(358, 424);
            gbxAdatok.TabIndex = 4;
            gbxAdatok.TabStop = false;
            gbxAdatok.Text = "Adatok";
            // 
            // tbxSzulEv
            // 
            tbxSzulEv.Location = new Point(134, 128);
            tbxSzulEv.Name = "tbxSzulEv";
            tbxSzulEv.Size = new Size(120, 32);
            tbxSzulEv.TabIndex = 1;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(6, 131);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(113, 25);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "Születési év:";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(56, 207);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(63, 25);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "Nyelv:";
            // 
            // lblUI04
            // 
            lblUI04.AutoSize = true;
            lblUI04.Location = new Point(63, 284);
            lblUI04.Name = "lblUI04";
            lblUI04.Size = new Size(56, 25);
            lblUI04.TabIndex = 0;
            lblUI04.Text = "Szint:";
            // 
            // cbxSzint
            // 
            cbxSzint.FormattingEnabled = true;
            cbxSzint.Items.AddRange(new object[] { "kezdő", "középhaladó", "haladó" });
            cbxSzint.Location = new Point(134, 281);
            cbxSzint.Name = "cbxSzint";
            cbxSzint.Size = new Size(158, 33);
            cbxSzint.TabIndex = 3;
            cbxSzint.Text = "válassz...";
            // 
            // btnAdatbevitel
            // 
            btnAdatbevitel.Location = new Point(87, 348);
            btnAdatbevitel.Name = "btnAdatbevitel";
            btnAdatbevitel.Size = new Size(184, 44);
            btnAdatbevitel.TabIndex = 4;
            btnAdatbevitel.Text = "Adatbevitel";
            btnAdatbevitel.UseVisualStyleBackColor = true;
            // 
            // btnKiiras
            // 
            btnKiiras.Location = new Point(99, 466);
            btnKiiras.Name = "btnKiiras";
            btnKiiras.Size = new Size(184, 53);
            btnKiiras.TabIndex = 5;
            btnKiiras.Text = "Válogatás, kiírás";
            btnKiiras.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 545);
            Controls.Add(btnKiiras);
            Controls.Add(gbxAdatok);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "MainForm";
            Text = "Nyelvtanfolyam - jelentkezés";
            gbxAdatok.ResumeLayout(false);
            gbxAdatok.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxNev;
        private ComboBox cbxNyel;
        private GroupBox gbxAdatok;
        private Label lblUI02;
        private ComboBox cbxSzint;
        private TextBox tbxSzulEv;
        private Label lblUI03;
        private Label lblUI04;
        private Button btnAdatbevitel;
        private Button btnKiiras;
    }
}
