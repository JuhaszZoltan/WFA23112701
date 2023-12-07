namespace WFA007
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            chbAlahuzott.CheckedChanged += CHB_CheckedChanged;
            chbDolt.CheckedChanged += CHB_CheckedChanged;
            chbFelkover.CheckedChanged += CHB_CheckedChanged;
        }

        private void CHB_CheckedChanged(object? sender, EventArgs e)
        {
            var fontStyle = FontStyle.Regular;

            if (chbAlahuzott.Checked) fontStyle |= FontStyle.Underline;
            if (chbDolt.Checked) fontStyle |= FontStyle.Italic;
            if (chbFelkover.Checked) fontStyle |= FontStyle.Bold;

            lblSzoveg.Font = new(
                lblSzoveg.Font.FontFamily,
                lblSzoveg.Font.Size,
                fontStyle);
        }
    }
}
