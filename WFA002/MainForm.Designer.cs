namespace WFA002
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
            pnlMain = new Panel();
            cbxLotto = new ComboBox();
            btnSorsolas = new Button();
            lblSzamok = new Label();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.Control;
            pnlMain.BackgroundImage = Properties.Resources.cat;
            pnlMain.BackgroundImageLayout = ImageLayout.Zoom;
            pnlMain.Controls.Add(lblSzamok);
            pnlMain.Location = new Point(12, 205);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(375, 218);
            pnlMain.TabIndex = 0;
            // 
            // cbxLotto
            // 
            cbxLotto.FormattingEnabled = true;
            cbxLotto.Items.AddRange(new object[] { "5-ös lottó", "6-os lottó", "7-es lottó" });
            cbxLotto.Location = new Point(93, 48);
            cbxLotto.MaxDropDownItems = 3;
            cbxLotto.Name = "cbxLotto";
            cbxLotto.Size = new Size(213, 33);
            cbxLotto.TabIndex = 1;
            cbxLotto.Text = "válassz...";
            // 
            // btnSorsolas
            // 
            btnSorsolas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSorsolas.Location = new Point(93, 115);
            btnSorsolas.Name = "btnSorsolas";
            btnSorsolas.Size = new Size(213, 53);
            btnSorsolas.TabIndex = 2;
            btnSorsolas.Text = "Sorsolás";
            btnSorsolas.UseVisualStyleBackColor = true;
            // 
            // lblSzamok
            // 
            lblSzamok.BackColor = Color.Transparent;
            lblSzamok.Font = new Font("Segoe UI", 20F);
            lblSzamok.Location = new Point(3, 0);
            lblSzamok.Name = "lblSzamok";
            lblSzamok.Size = new Size(372, 218);
            lblSzamok.TabIndex = 0;
            lblSzamok.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 435);
            Controls.Add(btnSorsolas);
            Controls.Add(cbxLotto);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Lottósorsolás";
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private ComboBox cbxLotto;
        private Button btnSorsolas;
        private Label lblSzamok;
    }
}
