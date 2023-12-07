namespace WFA006
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
            gbxAdasVetel = new GroupBox();
            rbEladas = new RadioButton();
            rbVetel = new RadioButton();
            lblUI01 = new Label();
            cbxValuta = new ComboBox();
            lblUI02 = new Label();
            lblArfolyam = new Label();
            lblUI04 = new Label();
            lblAdasVetelOsszege = new Label();
            lblUI03 = new Label();
            tbxValuta = new TextBox();
            lblPenznem = new Label();
            lblFuzetendo = new Label();
            lblUI05 = new Label();
            btnOK = new Button();
            gbxAdasVetel.SuspendLayout();
            SuspendLayout();
            // 
            // gbxAdasVetel
            // 
            gbxAdasVetel.Controls.Add(rbEladas);
            gbxAdasVetel.Controls.Add(rbVetel);
            gbxAdasVetel.Location = new Point(12, 12);
            gbxAdasVetel.Name = "gbxAdasVetel";
            gbxAdasVetel.Size = new Size(422, 88);
            gbxAdasVetel.TabIndex = 0;
            gbxAdasVetel.TabStop = false;
            // 
            // rbEladas
            // 
            rbEladas.AutoSize = true;
            rbEladas.Location = new Point(233, 35);
            rbEladas.Name = "rbEladas";
            rbEladas.Size = new Size(92, 34);
            rbEladas.TabIndex = 1;
            rbEladas.Text = "eladás";
            rbEladas.UseVisualStyleBackColor = true;
            // 
            // rbVetel
            // 
            rbVetel.AutoSize = true;
            rbVetel.Checked = true;
            rbVetel.Location = new Point(68, 35);
            rbVetel.Name = "rbVetel";
            rbVetel.Size = new Size(78, 34);
            rbVetel.TabIndex = 0;
            rbVetel.TabStop = true;
            rbVetel.Text = "vétel";
            rbVetel.UseVisualStyleBackColor = true;
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(114, 114);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(75, 30);
            lblUI01.TabIndex = 1;
            lblUI01.Text = "valuta:";
            // 
            // cbxValuta
            // 
            cbxValuta.FormattingEnabled = true;
            cbxValuta.Location = new Point(195, 114);
            cbxValuta.Name = "cbxValuta";
            cbxValuta.Size = new Size(176, 38);
            cbxValuta.TabIndex = 2;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(86, 174);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(103, 30);
            lblUI02.TabIndex = 1;
            lblUI02.Text = "árfolyam:";
            // 
            // lblArfolyam
            // 
            lblArfolyam.BackColor = Color.White;
            lblArfolyam.BorderStyle = BorderStyle.FixedSingle;
            lblArfolyam.Location = new Point(195, 170);
            lblArfolyam.Name = "lblArfolyam";
            lblArfolyam.Size = new Size(176, 38);
            lblArfolyam.TabIndex = 0;
            lblArfolyam.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUI04
            // 
            lblUI04.AutoSize = true;
            lblUI04.Location = new Point(377, 174);
            lblUI04.Name = "lblUI04";
            lblUI04.Size = new Size(31, 30);
            lblUI04.TabIndex = 1;
            lblUI04.Text = "Ft";
            // 
            // lblAdasVetelOsszege
            // 
            lblAdasVetelOsszege.Location = new Point(12, 231);
            lblAdasVetelOsszege.Name = "lblAdasVetelOsszege";
            lblAdasVetelOsszege.Size = new Size(177, 36);
            lblAdasVetelOsszege.TabIndex = 1;
            lblAdasVetelOsszege.Text = "vásárlás összege:";
            lblAdasVetelOsszege.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(80, 294);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(109, 30);
            lblUI03.TabIndex = 1;
            lblUI03.Text = "fizetendő:";
            // 
            // tbxValuta
            // 
            tbxValuta.Location = new Point(195, 231);
            tbxValuta.Name = "tbxValuta";
            tbxValuta.Size = new Size(176, 36);
            tbxValuta.TabIndex = 3;
            // 
            // lblPenznem
            // 
            lblPenznem.AutoSize = true;
            lblPenznem.Location = new Point(377, 234);
            lblPenznem.Name = "lblPenznem";
            lblPenznem.Size = new Size(28, 30);
            lblPenznem.TabIndex = 1;
            lblPenznem.Text = "...";
            // 
            // lblFuzetendo
            // 
            lblFuzetendo.BackColor = Color.White;
            lblFuzetendo.BorderStyle = BorderStyle.FixedSingle;
            lblFuzetendo.Location = new Point(195, 290);
            lblFuzetendo.Name = "lblFuzetendo";
            lblFuzetendo.Size = new Size(176, 38);
            lblFuzetendo.TabIndex = 0;
            lblFuzetendo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUI05
            // 
            lblUI05.AutoSize = true;
            lblUI05.Location = new Point(377, 294);
            lblUI05.Name = "lblUI05";
            lblUI05.Size = new Size(31, 30);
            lblUI05.TabIndex = 1;
            lblUI05.Text = "Ft";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(86, 361);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(285, 45);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 436);
            Controls.Add(btnOK);
            Controls.Add(tbxValuta);
            Controls.Add(lblFuzetendo);
            Controls.Add(lblArfolyam);
            Controls.Add(cbxValuta);
            Controls.Add(lblUI03);
            Controls.Add(lblAdasVetelOsszege);
            Controls.Add(lblUI02);
            Controls.Add(lblPenznem);
            Controls.Add(lblUI05);
            Controls.Add(lblUI04);
            Controls.Add(lblUI01);
            Controls.Add(gbxAdasVetel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Valutaváltó";
            gbxAdasVetel.ResumeLayout(false);
            gbxAdasVetel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxAdasVetel;
        private RadioButton rbEladas;
        private RadioButton rbVetel;
        private Label lblUI01;
        private ComboBox cbxValuta;
        private Label lblUI02;
        private Label lblArfolyam;
        private Label lblUI04;
        private Label lblAdasVetelOsszege;
        private Label lblUI03;
        private TextBox tbxValuta;
        private Label lblPenznem;
        private Label lblFuzetendo;
        private Label lblUI05;
        private Button btnOK;
    }
}
