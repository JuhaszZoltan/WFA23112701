namespace WFA007
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
            lblSzoveg = new Label();
            chbFelkover = new CheckBox();
            chbDolt = new CheckBox();
            chbAlahuzott = new CheckBox();
            SuspendLayout();
            // 
            // lblSzoveg
            // 
            lblSzoveg.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblSzoveg.Location = new Point(12, 9);
            lblSzoveg.Name = "lblSzoveg";
            lblSzoveg.Size = new Size(467, 193);
            lblSzoveg.TabIndex = 0;
            lblSzoveg.Text = "A szó elszáll,\naz írás megmarad.";
            lblSzoveg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chbFelkover
            // 
            chbFelkover.AutoSize = true;
            chbFelkover.Location = new Point(167, 224);
            chbFelkover.Name = "chbFelkover";
            chbFelkover.Size = new Size(111, 34);
            chbFelkover.TabIndex = 1;
            chbFelkover.Text = "félkövér";
            chbFelkover.UseVisualStyleBackColor = true;
            // 
            // chbDolt
            // 
            chbDolt.AutoSize = true;
            chbDolt.Location = new Point(167, 264);
            chbDolt.Name = "chbDolt";
            chbDolt.Size = new Size(70, 34);
            chbDolt.TabIndex = 1;
            chbDolt.Text = "dőlt";
            chbDolt.UseVisualStyleBackColor = true;
            // 
            // chbAlahuzott
            // 
            chbAlahuzott.AutoSize = true;
            chbAlahuzott.Location = new Point(167, 304);
            chbAlahuzott.Name = "chbAlahuzott";
            chbAlahuzott.Size = new Size(120, 34);
            chbAlahuzott.TabIndex = 1;
            chbAlahuzott.Text = "aláhúzott";
            chbAlahuzott.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 395);
            Controls.Add(chbAlahuzott);
            Controls.Add(chbDolt);
            Controls.Add(chbFelkover);
            Controls.Add(lblSzoveg);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Betű stílusok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSzoveg;
        private CheckBox chbFelkover;
        private CheckBox chbDolt;
        private CheckBox chbAlahuzott;
    }
}
