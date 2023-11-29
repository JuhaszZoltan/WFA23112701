namespace WFA004
{
    public partial class MainForm : Form
    {
        private Dictionary<RadioButton, float> afak;
        private float afakulcs = .27f;
        public MainForm()
        {
            InitializeComponent();
            afak = new()
            {
                { rbA00, .00f },
                { rbA05, .05f },
                { rbA18, .18f },
                { rbA27, .27f },
            };
            rbA00.CheckedChanged += RbA_CheckedChanged;
            rbA05.CheckedChanged += RbA_CheckedChanged;
            rbA18.CheckedChanged += RbA_CheckedChanged;
            rbA27.CheckedChanged += RbA_CheckedChanged;
            tbxNettoAr.TextChanged += TbxNettoAr_TextChanged;
            btnSzamol.Click += BtnSzamol_Click;

        }

        private void TbxNettoAr_TextChanged(object? sender, EventArgs e)
        {
            TbxClear();
        }

        private void BtnSzamol_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNettoAr.Text))
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: "a nettó árérték mezõt ben töltötted ki!",
                    icon: MessageBoxIcon.Warning,
                    buttons: MessageBoxButtons.OK);
            else
            {
                int nettoAr = int.Parse(tbxNettoAr.Text);
                float afaEretek = nettoAr * afakulcs;
                tbxAfaErtek.Text = $"{nettoAr * afakulcs:0}";
                tbxBruttoAr.Text = $"{nettoAr - afaEretek:0}";
            }
        }

        private void RbA_CheckedChanged(object? sender, EventArgs e)
        {
            TbxClear();
            afakulcs = afak.Single(kvp => kvp.Key.Checked).Value;
        }

        private void TbxClear()
        {
            tbxAfaErtek.Text = null;
            tbxBruttoAr.Text = null;
        }
    }
}
