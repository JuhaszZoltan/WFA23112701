namespace WFA004
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
            gbfAfaKulcsok = new GroupBox();
            rbA27 = new RadioButton();
            rbA18 = new RadioButton();
            rbA05 = new RadioButton();
            rbA00 = new RadioButton();
            lblUI01 = new Label();
            tbxNettoAr = new TextBox();
            lblUI04 = new Label();
            lblUI02 = new Label();
            lblUI05 = new Label();
            tbxAfaErtek = new TextBox();
            lblUI03 = new Label();
            lblUI06 = new Label();
            tbxBruttoAr = new TextBox();
            btnSzamol = new Button();
            gbfAfaKulcsok.SuspendLayout();
            SuspendLayout();
            // 
            // gbfAfaKulcsok
            // 
            gbfAfaKulcsok.Controls.Add(rbA00);
            gbfAfaKulcsok.Controls.Add(rbA05);
            gbfAfaKulcsok.Controls.Add(rbA18);
            gbfAfaKulcsok.Controls.Add(rbA27);
            gbfAfaKulcsok.Location = new Point(12, 12);
            gbfAfaKulcsok.Name = "gbfAfaKulcsok";
            gbfAfaKulcsok.Size = new Size(374, 92);
            gbfAfaKulcsok.TabIndex = 0;
            gbfAfaKulcsok.TabStop = false;
            gbfAfaKulcsok.Text = "Áfa kulcs";
            // 
            // rbA27
            // 
            rbA27.AutoSize = true;
            rbA27.Checked = true;
            rbA27.Location = new Point(24, 40);
            rbA27.Name = "rbA27";
            rbA27.Size = new Size(66, 29);
            rbA27.TabIndex = 0;
            rbA27.TabStop = true;
            rbA27.Text = "27%";
            rbA27.UseVisualStyleBackColor = true;
            // 
            // rbA18
            // 
            rbA18.AutoSize = true;
            rbA18.Location = new Point(115, 40);
            rbA18.Name = "rbA18";
            rbA18.Size = new Size(66, 29);
            rbA18.TabIndex = 0;
            rbA18.Text = "18%";
            rbA18.UseVisualStyleBackColor = true;
            // 
            // rbA05
            // 
            rbA05.AutoSize = true;
            rbA05.Location = new Point(208, 40);
            rbA05.Name = "rbA05";
            rbA05.Size = new Size(56, 29);
            rbA05.TabIndex = 0;
            rbA05.Text = "5%";
            rbA05.UseVisualStyleBackColor = true;
            // 
            // rbA00
            // 
            rbA00.AutoSize = true;
            rbA00.Location = new Point(296, 40);
            rbA00.Name = "rbA00";
            rbA00.Size = new Size(56, 29);
            rbA00.TabIndex = 0;
            rbA00.Text = "0%";
            rbA00.UseVisualStyleBackColor = true;
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(20, 159);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(82, 25);
            lblUI01.TabIndex = 1;
            lblUI01.Text = "nettó ár:";
            // 
            // tbxNettoAr
            // 
            tbxNettoAr.Location = new Point(108, 156);
            tbxNettoAr.Name = "tbxNettoAr";
            tbxNettoAr.Size = new Size(222, 32);
            tbxNettoAr.TabIndex = 2;
            // 
            // lblUI04
            // 
            lblUI04.AutoSize = true;
            lblUI04.Location = new Point(336, 159);
            lblUI04.Name = "lblUI04";
            lblUI04.Size = new Size(27, 25);
            lblUI04.TabIndex = 1;
            lblUI04.Text = "Ft";
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(13, 257);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(89, 25);
            lblUI02.TabIndex = 1;
            lblUI02.Text = "áfa érték:";
            // 
            // lblUI05
            // 
            lblUI05.AutoSize = true;
            lblUI05.Location = new Point(336, 257);
            lblUI05.Name = "lblUI05";
            lblUI05.Size = new Size(27, 25);
            lblUI05.TabIndex = 1;
            lblUI05.Text = "Ft";
            // 
            // tbxAfaErtek
            // 
            tbxAfaErtek.Location = new Point(108, 254);
            tbxAfaErtek.Name = "tbxAfaErtek";
            tbxAfaErtek.Size = new Size(222, 32);
            tbxAfaErtek.TabIndex = 2;
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(12, 355);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(90, 25);
            lblUI03.TabIndex = 1;
            lblUI03.Text = "bruttó ár:";
            // 
            // lblUI06
            // 
            lblUI06.AutoSize = true;
            lblUI06.Location = new Point(336, 355);
            lblUI06.Name = "lblUI06";
            lblUI06.Size = new Size(27, 25);
            lblUI06.TabIndex = 1;
            lblUI06.Text = "Ft";
            // 
            // tbxBruttoAr
            // 
            tbxBruttoAr.Location = new Point(108, 352);
            tbxBruttoAr.Name = "tbxBruttoAr";
            tbxBruttoAr.Size = new Size(222, 32);
            tbxBruttoAr.TabIndex = 2;
            // 
            // btnSzamol
            // 
            btnSzamol.Location = new Point(12, 432);
            btnSzamol.Name = "btnSzamol";
            btnSzamol.Size = new Size(374, 48);
            btnSzamol.TabIndex = 3;
            btnSzamol.Text = "Számol";
            btnSzamol.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 492);
            Controls.Add(btnSzamol);
            Controls.Add(tbxBruttoAr);
            Controls.Add(lblUI06);
            Controls.Add(tbxAfaErtek);
            Controls.Add(lblUI05);
            Controls.Add(lblUI03);
            Controls.Add(tbxNettoAr);
            Controls.Add(lblUI02);
            Controls.Add(lblUI04);
            Controls.Add(lblUI01);
            Controls.Add(gbfAfaKulcsok);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Áfás számla";
            gbfAfaKulcsok.ResumeLayout(false);
            gbfAfaKulcsok.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbfAfaKulcsok;
        private RadioButton rbA00;
        private RadioButton rbA05;
        private RadioButton rbA18;
        private RadioButton rbA27;
        private Label lblUI01;
        private TextBox tbxNettoAr;
        private Label lblUI04;
        private Label lblUI02;
        private Label lblUI05;
        private TextBox tbxAfaErtek;
        private Label lblUI03;
        private Label lblUI06;
        private TextBox tbxBruttoAr;
        private Button btnSzamol;
    }
}
