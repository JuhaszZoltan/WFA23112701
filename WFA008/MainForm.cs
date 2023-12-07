namespace WFA008
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            rdbKave.CheckedChanged += AnyCheck_CheckedChanged;
            rdbKakao.CheckedChanged += AnyCheck_CheckedChanged;
            rdbTea.CheckedChanged += AnyCheck_CheckedChanged;
            chbCukor.CheckedChanged += AnyCheck_CheckedChanged;
            chbCitrom.CheckedChanged += AnyCheck_CheckedChanged;
            chbTej.CheckedChanged += AnyCheck_CheckedChanged;
        }

        private void AnyCheck_CheckedChanged(object? sender, EventArgs e)
        {
            int ar = 0;
            if (!rdbTea.Checked)
            {
                chbCitrom.Checked = false;
                chbCitrom.Enabled = false;
                ar = 120;
            }
            else
            {
                chbCitrom.Enabled = true;
                ar = 80;
            }

            if (chbCukor.Checked) ar += 60;
            if (chbCitrom.Checked) ar += 60;
            if (chbTej.Checked) ar += 60;

            lblAr.Text = $"{ar} Ft";
        }
    }
}
