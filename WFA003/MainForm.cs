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
                hibauzenet += "A n�v megad�sa k�telez�!\n";
            if (!joEv)
                hibauzenet += "A sz�let�si �v megad�s�nak form�tuma nem megfelel�!\n";
            if (cbxNyel.SelectedIndex == -1)
                hibauzenet += "Nem v�lasztottad ki a nyelvet vagy ilyen nyelv� oktat�s nincs!\n";
            if (cbxSzint.SelectedIndex == -1)
                hibauzenet += "Nem v�lasztottad ki a szintet, vagy ilyen szint� k�pz�s nincs!\n";

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
                    caption: "SIKERES JELENTKEZ�S!",
                    text: "a jelentkez� adatait r�gz�tett�k!",
                    icon: MessageBoxIcon.Information,
                    buttons: MessageBoxButtons.OK);

                tbxNev.Text = null;
                tbxSzulEv.Text = null;
                cbxNyel.SelectedIndex = -1;
                cbxSzint.SelectedIndex = -1;
                cbxNyel.Text = "v�lassz...";
                cbxSzint.Text = "v�lassz...";
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
                    case "n�met":
                        swNemet.WriteLine(sor);
                        break;
                    default: break;
                }
            }

            _ = MessageBox.Show(
                caption: "SIKERES SZ�TV�LOGAT�S!",
                text: "a jelentkez�k n�vsorait nyelvenk�nt\n" +
                "megtalalja a ...\\output mapp�ban!",
                icon: MessageBoxIcon.Information,
                buttons: MessageBoxButtons.OK);
        }

    }
}
