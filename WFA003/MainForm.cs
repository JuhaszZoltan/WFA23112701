namespace WFA003
{
    public partial class MainForm : Form
    {
        private List<Jelentkezo> jelentkezok = new();
        public MainForm()
        {
            InitializeComponent();
            btnAdatbevitel.Click += BtnAdatbevitel_Click;
            btnKiiras.Click += BtnKiiras_Click;
        }

        private void BtnAdatbevitel_Click(object? sender, EventArgs e)
        {
            string nev = tbxNev.Text;
            bool joEv = int.TryParse(tbxSzulEv.Text, out int ev);
            string nyelv = cbxNyel.Text;
            string szint = cbxSzint.Text;

            string hibauzenet = string.Empty;

            if (string.IsNullOrWhiteSpace(nev))
                hibauzenet += "A név megadása kötelezõ!\n";
            if (!joEv)
                hibauzenet += "A születési év megadásának formátuma nem megfelelõ!\n";
            if (cbxNyel.SelectedIndex == -1)
                hibauzenet += "Nem választottad ki a nyelvet vagy ilyen nyelvû oktatás nincs!\n";
            if (cbxSzint.SelectedIndex == -1)
                hibauzenet += "Nem választottad ki a szintet, vagy ilyen szintû képzés nincs!\n";

            if (hibauzenet != string.Empty)
            {
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: hibauzenet,
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                jelentkezok.Add(new(nev, ev, nyelv, szint));

                _ = MessageBox.Show(
                    caption: "SIKERES JELENTKEZÉS!",
                    text: "a jelentkezõ adatait rögzítettük!",
                    icon: MessageBoxIcon.Information,
                    buttons: MessageBoxButtons.OK);

                tbxNev.Text = null;
                tbxSzulEv.Text = null;
                cbxNyel.SelectedIndex = -1;
                cbxSzint.SelectedIndex = -1;
                cbxNyel.Text = "válassz...";
                cbxSzint.Text = "válassz...";
            }
        }

        private void BtnKiiras_Click(object? sender, EventArgs e)
        {
            using StreamWriter swAngol = new(@"..\..\..\output\angol.txt");
            using StreamWriter swFrancia = new(@"..\..\..\output\francia.txt");
            using StreamWriter swNemet = new(@"..\..\..\output\nemet.txt");

            foreach (var jel in jelentkezok)
            {
                string sor = $"{jel.Nev};{jel.SzulEv};{jel.Szint}";
                switch (jel.Nyelv)
                {
                    case "angol":
                        swAngol.WriteLine(sor);
                        break;
                    case "francia":
                        swFrancia.WriteLine(sor);
                        break;
                    case "német":
                        swNemet.WriteLine(sor);
                        break;
                    default: break;
                }
            }

            _ = MessageBox.Show(
                caption: "SIKERES SZÉTVÁLOGATÁS!",
                text: "a jelentkezõk névsorait nyelvenként\n" +
                "megtalalja a ...\\output mappában!",
                icon: MessageBoxIcon.Information,
                buttons: MessageBoxButtons.OK);
        }

    }
}
