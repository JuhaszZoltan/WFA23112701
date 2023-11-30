namespace WFA005
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
            gbxTerep = new GroupBox();
            rbEmelkedo = new RadioButton();
            rbSik = new RadioButton();
            gbxSportag = new GroupBox();
            rbKerekparozas = new RadioButton();
            rbGyaloglas = new RadioButton();
            rbKocogas = new RadioButton();
            lblUI01 = new Label();
            tbxPerc = new TextBox();
            btnSzamol = new Button();
            lblUI02 = new Label();
            lblUI04 = new Label();
            lblUI03 = new Label();
            tbxKJ = new TextBox();
            gbxTerep.SuspendLayout();
            gbxSportag.SuspendLayout();
            SuspendLayout();
            // 
            // gbxTerep
            // 
            gbxTerep.Controls.Add(rbEmelkedo);
            gbxTerep.Controls.Add(rbSik);
            gbxTerep.Location = new Point(12, 12);
            gbxTerep.Name = "gbxTerep";
            gbxTerep.Size = new Size(154, 169);
            gbxTerep.TabIndex = 0;
            gbxTerep.TabStop = false;
            gbxTerep.Text = "Terep";
            // 
            // rbEmelkedo
            // 
            rbEmelkedo.AutoSize = true;
            rbEmelkedo.Location = new Point(26, 108);
            rbEmelkedo.Name = "rbEmelkedo";
            rbEmelkedo.Size = new Size(112, 29);
            rbEmelkedo.TabIndex = 2;
            rbEmelkedo.Text = "emelkedő";
            rbEmelkedo.UseVisualStyleBackColor = true;
            // 
            // rbSik
            // 
            rbSik.AutoSize = true;
            rbSik.Checked = true;
            rbSik.Location = new Point(26, 44);
            rbSik.Name = "rbSik";
            rbSik.Size = new Size(52, 29);
            rbSik.TabIndex = 1;
            rbSik.TabStop = true;
            rbSik.Text = "sík";
            rbSik.UseVisualStyleBackColor = true;
            // 
            // gbxSportag
            // 
            gbxSportag.Controls.Add(rbKocogas);
            gbxSportag.Controls.Add(rbKerekparozas);
            gbxSportag.Controls.Add(rbGyaloglas);
            gbxSportag.Location = new Point(184, 12);
            gbxSportag.Name = "gbxSportag";
            gbxSportag.Size = new Size(175, 233);
            gbxSportag.TabIndex = 0;
            gbxSportag.TabStop = false;
            gbxSportag.Text = "Sportág";
            // 
            // rbKerekparozas
            // 
            rbKerekparozas.AutoSize = true;
            rbKerekparozas.Location = new Point(25, 108);
            rbKerekparozas.Name = "rbKerekparozas";
            rbKerekparozas.Size = new Size(141, 29);
            rbKerekparozas.TabIndex = 4;
            rbKerekparozas.Text = "kerékpározás";
            rbKerekparozas.UseVisualStyleBackColor = true;
            // 
            // rbGyaloglas
            // 
            rbGyaloglas.AutoSize = true;
            rbGyaloglas.Checked = true;
            rbGyaloglas.Location = new Point(25, 44);
            rbGyaloglas.Name = "rbGyaloglas";
            rbGyaloglas.Size = new Size(110, 29);
            rbGyaloglas.TabIndex = 3;
            rbGyaloglas.TabStop = true;
            rbGyaloglas.Text = "gyaloglás";
            rbGyaloglas.UseVisualStyleBackColor = true;
            // 
            // rbKocogas
            // 
            rbKocogas.AutoSize = true;
            rbKocogas.Location = new Point(25, 172);
            rbKocogas.Name = "rbKocogas";
            rbKocogas.Size = new Size(99, 29);
            rbKocogas.TabIndex = 5;
            rbKocogas.Text = "kocogás";
            rbKocogas.UseVisualStyleBackColor = true;
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(23, 272);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(94, 25);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "időtartam";
            // 
            // tbxPerc
            // 
            tbxPerc.Location = new Point(123, 269);
            tbxPerc.Name = "tbxPerc";
            tbxPerc.Size = new Size(157, 32);
            tbxPerc.TabIndex = 6;
            // 
            // btnSzamol
            // 
            btnSzamol.Location = new Point(12, 330);
            btnSzamol.Name = "btnSzamol";
            btnSzamol.Size = new Size(347, 41);
            btnSzamol.TabIndex = 7;
            btnSzamol.Text = "Számol";
            btnSzamol.UseVisualStyleBackColor = true;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(286, 272);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(49, 25);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "perc";
            // 
            // lblUI04
            // 
            lblUI04.AutoSize = true;
            lblUI04.Location = new Point(288, 391);
            lblUI04.Name = "lblUI04";
            lblUI04.Size = new Size(31, 25);
            lblUI04.TabIndex = 0;
            lblUI04.Text = "KJ";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(41, 391);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(76, 25);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "energia";
            // 
            // tbxKJ
            // 
            tbxKJ.Location = new Point(123, 388);
            tbxKJ.Name = "tbxKJ";
            tbxKJ.Size = new Size(157, 32);
            tbxKJ.TabIndex = 0;
            tbxKJ.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 443);
            Controls.Add(btnSzamol);
            Controls.Add(tbxKJ);
            Controls.Add(tbxPerc);
            Controls.Add(lblUI03);
            Controls.Add(lblUI04);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Controls.Add(gbxSportag);
            Controls.Add(gbxTerep);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Sportolás";
            gbxTerep.ResumeLayout(false);
            gbxTerep.PerformLayout();
            gbxSportag.ResumeLayout(false);
            gbxSportag.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxTerep;
        private RadioButton rbEmelkedo;
        private RadioButton rbSik;
        private GroupBox gbxSportag;
        private RadioButton rbKerekparozas;
        private RadioButton rbGyaloglas;
        private RadioButton rbKocogas;
        private Label lblUI01;
        private TextBox tbxPerc;
        private Button btnSzamol;
        private Label lblUI02;
        private Label lblUI04;
        private Label lblUI03;
        private TextBox tbxKJ;
    }
}
