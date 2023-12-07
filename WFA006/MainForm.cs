namespace WFA006
{
    public partial class MainForm : Form
    {
        private List<Valuta> Valutak { get; set; }
        private bool Vetel { get; set; } = true;
        private Valuta KivalasztottValuta { get; set; }

        public MainForm()
        {
            Valutak = new();
            InitializeComponent();
            this.Load += MainForm_Load;
            rbEladas.CheckedChanged += Condition_Changed;
            rbVetel.CheckedChanged += Condition_Changed;
            cbxValuta.SelectedIndexChanged += Condition_Changed;
            btnOK.Click += BtnOK_Click;

            //NINCS KÉSZ!!!
        }

        private void BtnOK_Click(object? sender, EventArgs e)
        {
            
        }

        private void Condition_Changed(object? sender, EventArgs e)
        {
            Vetel = rbVetel.Checked;

            KivalasztottValuta = Valutak.Single(v => v.Nev == cbxValuta.Text);

            lblArfolyam.Text = Vetel
                ? $"{KivalasztottValuta.VetelAr}"
                : $"{KivalasztottValuta.EladasiAr}";

            lblAdasVetelOsszege.Text = Vetel
                ? "vásárlás összege:"
                : "eladás összege:";

            lblPenznem.Text = KivalasztottValuta.Nev;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            using StreamReader sr = new(@"..\..\..\src\valuta.txt");
            while (!sr.EndOfStream) Valutak.Add(new(sr.ReadLine()!));
            foreach (var v in Valutak) cbxValuta.Items.Add(v.Nev);
            cbxValuta.SelectedIndex = 1;
        }
    }
}
