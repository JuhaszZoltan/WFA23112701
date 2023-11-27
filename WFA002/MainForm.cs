using WFA002.Properties;

namespace WFA002
{
    public partial class MainForm : Form
    {
        private static readonly Random rnd = new();
        private (int Tipus, int FelsoHatar) lotto = (0, 0);

        public MainForm()
        {
            InitializeComponent();
            cbxLotto.SelectedIndexChanged += CbxLotto_SelectedIndexChanged;
            btnSorsolas.Click += BtnSorsolas_Click;
        }

        private void BtnSorsolas_Click(object? sender, EventArgs e)
        {
            if (lotto.Tipus == 0)
            {
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: "elõbb válassz a legördülõ listából!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                pnlMain.BackgroundImage = null;
                int iter = lotto.Tipus != 7 ? 1 : 2;
                for (int i = 0; i < iter; i++)
                    lblSzamok.Text += string.Join(", ", NyerszamGen())+'\n';
            }
        }

        private List<int> NyerszamGen()
        {
            List<int> nyeroszamok = [];
            while (nyeroszamok.Count < lotto.Tipus)
            {
                int szam = rnd.Next(lotto.FelsoHatar) + 1;
                if (!nyeroszamok.Contains(szam)) nyeroszamok.Add(szam);
            }
            return [.. nyeroszamok.OrderBy(e => e)];
        }

        private void CbxLotto_SelectedIndexChanged(object? sender, EventArgs e)
        {
            pnlMain.BackgroundImage = Resources.cat;
            lblSzamok.Text = null;
            lotto = cbxLotto.SelectedIndex switch
            {
                0 => (5, 90),
                1 => (6, 45),
                2 => (7, 35),
                _ => (0, 0),
            };
        }
    }
}
