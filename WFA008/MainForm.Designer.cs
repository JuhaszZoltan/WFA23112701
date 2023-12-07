namespace WFA008
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
            grbItalok = new GroupBox();
            rdbTea = new RadioButton();
            rdbKakao = new RadioButton();
            rdbKave = new RadioButton();
            grbHozzavalok = new GroupBox();
            chbTej = new CheckBox();
            chbCitrom = new CheckBox();
            chbCukor = new CheckBox();
            lblUI01 = new Label();
            lblAr = new Label();
            btnElkeszit = new Button();
            grbItalok.SuspendLayout();
            grbHozzavalok.SuspendLayout();
            SuspendLayout();
            // 
            // grbItalok
            // 
            grbItalok.Controls.Add(rdbTea);
            grbItalok.Controls.Add(rdbKakao);
            grbItalok.Controls.Add(rdbKave);
            grbItalok.Location = new Point(12, 86);
            grbItalok.Name = "grbItalok";
            grbItalok.Size = new Size(176, 238);
            grbItalok.TabIndex = 0;
            grbItalok.TabStop = false;
            grbItalok.Text = "italok";
            // 
            // rdbTea
            // 
            rdbTea.AutoSize = true;
            rdbTea.Location = new Point(21, 177);
            rdbTea.Name = "rdbTea";
            rdbTea.Size = new Size(61, 34);
            rdbTea.TabIndex = 0;
            rdbTea.TabStop = true;
            rdbTea.Text = "tea";
            rdbTea.UseVisualStyleBackColor = true;
            // 
            // rdbKakao
            // 
            rdbKakao.AutoSize = true;
            rdbKakao.Location = new Point(21, 112);
            rdbKakao.Name = "rdbKakao";
            rdbKakao.Size = new Size(88, 34);
            rdbKakao.TabIndex = 0;
            rdbKakao.TabStop = true;
            rdbKakao.Text = "kakaó";
            rdbKakao.UseVisualStyleBackColor = true;
            // 
            // rdbKave
            // 
            rdbKave.AutoSize = true;
            rdbKave.Checked = true;
            rdbKave.Location = new Point(21, 47);
            rdbKave.Name = "rdbKave";
            rdbKave.Size = new Size(76, 34);
            rdbKave.TabIndex = 0;
            rdbKave.TabStop = true;
            rdbKave.Text = "kávé";
            rdbKave.UseVisualStyleBackColor = true;
            // 
            // grbHozzavalok
            // 
            grbHozzavalok.Controls.Add(chbTej);
            grbHozzavalok.Controls.Add(chbCitrom);
            grbHozzavalok.Controls.Add(chbCukor);
            grbHozzavalok.Location = new Point(225, 86);
            grbHozzavalok.Name = "grbHozzavalok";
            grbHozzavalok.Size = new Size(176, 238);
            grbHozzavalok.TabIndex = 0;
            grbHozzavalok.TabStop = false;
            grbHozzavalok.Text = "hozzávalók";
            // 
            // chbTej
            // 
            chbTej.AutoSize = true;
            chbTej.Location = new Point(19, 178);
            chbTej.Name = "chbTej";
            chbTej.Size = new Size(56, 34);
            chbTej.TabIndex = 0;
            chbTej.Text = "tej";
            chbTej.UseVisualStyleBackColor = true;
            // 
            // chbCitrom
            // 
            chbCitrom.AutoSize = true;
            chbCitrom.Enabled = false;
            chbCitrom.Location = new Point(19, 112);
            chbCitrom.Name = "chbCitrom";
            chbCitrom.Size = new Size(94, 34);
            chbCitrom.TabIndex = 0;
            chbCitrom.Text = "citrom";
            chbCitrom.UseVisualStyleBackColor = true;
            // 
            // chbCukor
            // 
            chbCukor.AutoSize = true;
            chbCukor.Location = new Point(19, 47);
            chbCukor.Name = "chbCukor";
            chbCukor.Size = new Size(86, 34);
            chbCukor.TabIndex = 0;
            chbCukor.Text = "cukor";
            chbCukor.UseVisualStyleBackColor = true;
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblUI01.Location = new Point(71, 39);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(117, 30);
            lblUI01.TabIndex = 1;
            lblUI01.Text = "fizetendő:";
            // 
            // lblAr
            // 
            lblAr.BorderStyle = BorderStyle.FixedSingle;
            lblAr.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblAr.Location = new Point(225, 39);
            lblAr.Name = "lblAr";
            lblAr.Size = new Size(117, 30);
            lblAr.TabIndex = 1;
            lblAr.Text = "120 Ft";
            lblAr.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnElkeszit
            // 
            btnElkeszit.Location = new Point(12, 339);
            btnElkeszit.Name = "btnElkeszit";
            btnElkeszit.Size = new Size(389, 47);
            btnElkeszit.TabIndex = 2;
            btnElkeszit.Text = "elkészítés";
            btnElkeszit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 398);
            Controls.Add(btnElkeszit);
            Controls.Add(lblAr);
            Controls.Add(lblUI01);
            Controls.Add(grbItalok);
            Controls.Add(grbHozzavalok);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "kávéautomata";
            grbItalok.ResumeLayout(false);
            grbItalok.PerformLayout();
            grbHozzavalok.ResumeLayout(false);
            grbHozzavalok.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbItalok;
        private GroupBox grbHozzavalok;
        private Label lblUI01;
        private Label lblAr;
        private RadioButton rdbTea;
        private RadioButton rdbKakao;
        private RadioButton rdbKave;
        private CheckBox chbTej;
        private CheckBox chbCitrom;
        private CheckBox chbCukor;
        private Button btnElkeszit;
    }
}
