namespace WFA006
{
    public class Valuta
    {
        public string Nev { get; set; }
        public float EladasiAr { get; set; }
        public float VetelAr { get; set; }

        public Valuta(string sor)
        {
            string[] v = sor.Split(';');
            Nev = v[0];
            EladasiAr = float.Parse(v[1]);
            VetelAr = float.Parse(v[2]);
        }
    }
}
