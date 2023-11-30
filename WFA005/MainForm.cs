namespace WFA005
{
    public partial class MainForm : Form
    {
        private int sportagTenyezo = 20;
        private (float t1, float t2) terepTenyezo = (1.5f, 1.2f);

        public MainForm()
        {
            InitializeComponent();
            rbSik.CheckedChanged += RbTerep_CheckedChanged;
            rbEmelkedo.CheckedChanged += RbTerep_CheckedChanged;

            rbGyaloglas.CheckedChanged += RbSportag_CheckedChanged;
            rbKerekparozas.CheckedChanged += RbSportag_CheckedChanged;
            rbKocogas.CheckedChanged += RbSportag_CheckedChanged;

            btnSzamol.Click += BtnSzamol_Click;
        }

        private void BtnSzamol_Click(object? sender, EventArgs e)
        {
            int ido = int.Parse(tbxPerc.Text);
            float kj = ido * (terepTenyezo.t1 + sportagTenyezo) * terepTenyezo.t2;
            float kcal = kj / 4.184f;
            tbxKJ.Text = $"{kj:0} kJ ({kcal:0} kcal)";
        }

        private void RbSportag_CheckedChanged(object? sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                sportagTenyezo = (sender as RadioButton).Text switch
                {
                    "gyaloglás" => 20,
                    "kerékpározás" => 24,
                    "kocogás" => 33,
                    _ => 0
                };
            }
        }

        private void RbTerep_CheckedChanged(object? sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                terepTenyezo = (sender as RadioButton).Text switch
                {
                    "sík" => (1.5f, 1.2f),
                    "emelkedõ" => (2f, 1.7f),
                    _ => (0, 0)
                };
            }
        }
    }
}
