namespace WFA001
{
    public partial class MainForm : Form
    {
        private static Random rnd = new();
        private Button[] gombok;
        private int rSzam;
        private int proba = 0;

        public MainForm()
        {
            InitializeComponent();
            InitGombVektor(100, 10);
            rSzam = rnd.Next(gombok.Length) + 1;
        }

        private void InitGombVektor(int len, int noCols)
        {
            gombok = new Button[len];

            for (int i = 0; i < len; i++)
            {
                int lx = i % noCols * 70;
                int ly = i / noCols * 70;

                gombok[i] = new()
                {
                    Font = new("Arial", 12f, FontStyle.Bold),
                    Text = $"{i + 1}",
                    Size = new(width: 50, height: 50),
                    Location = new Point(x: 20 + lx, y: 20 + ly),
                    BackColor = Color.LightGray,
                };
                gombok[i].Click += MainForm_Click;
                pnlMain.Controls.Add(gombok[i]);
            }
            this.Size = new(
                Size.Width + 15,
                Size.Height + 15);
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
            (sender as Button).Enabled = false;
            int gSzam = int.Parse((sender as Button).Text);
            proba++;
            if (gSzam == rSzam)
            {
                _ = MessageBox.Show(
                    caption: "GRATULÁLOK!",
                    text: "Eltaláltad! :)\n" +
                    $"próbálkozások száma: {proba}");
                Application.Restart();
            }
            else
            {
                _ = MessageBox.Show(
                    caption: "Nem jó",
                    text: gSzam > rSzam 
                    ? "túl nagy" 
                    : "túl kicsi");
            }


        }
    }
}
