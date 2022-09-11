using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RistoranteM
{
    public partial class Proprietario : Form
    {
        public static piatto[] p = new piatto[100];
        public static piatto pp;
        public static int n;
        string iFilename = @"./numeroPiatti.txt";
        string FILENAME = @"./ElencoPiatti.csv";
        public int ii=0;
        public Proprietario()
        {
            InitializeComponent();
        }
        public static piatto FromString(string piattoStringa, string sep = ";")
        {
            piatto v;
            string[] piattoC;
            v.prezzo = -1;
            v.tipo = "";
            v.nome = "";
            v.ingrediente1 = "";
            v.ingrediente2 = "";
            v.ingrediente3 = "";
            v.ingrediente4 = "";
            //dalla stringa deve ritornare la variabile Voto v settata con  i valori
            piattoC = piattoStringa.Split(';');
            Console.WriteLine(piattoC[0]);
            v.tipo = piattoC[0];
            v.nome = piattoC[1];
            v.prezzo = float.Parse(piattoC[2]);
            v.ingrediente1 = piattoC[3];
            v.ingrediente2 = piattoC[4];
            v.ingrediente3 = piattoC[5];
            v.ingrediente4 = piattoC[6];
            return v;
        }

        private void AggiungiPiatto_Click(object sender, EventArgs e)
        {
            AggiungiPiattoProp a = new AggiungiPiattoProp();
            a.ShowDialog();
        }

        private void IndietroPiatto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminaPiatto_Click(object sender, EventArgs e)
        {
            EliminaPiatto eli = new EliminaPiatto();
            eli.ShowDialog();
        }

        private void ModificaPiatto_Click(object sender, EventArgs e)
        {
            ModificaPiatto mp = new ModificaPiatto();
            mp.ShowDialog();
        }

        private void CercaPiatto_Click(object sender, EventArgs e)
        {
            CercaPiatto cp = new CercaPiatto();
            cp.ShowDialog();
        }

        private void VisualizzaPiatti_Click(object sender, EventArgs e)
        {
            VisualizzaPiatti vp = new VisualizzaPiatti();
            vp.ShowDialog();
        }

        private void Proprietario_Load(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader(iFilename);
            string line = "";
            string line2;
            int s;
            line2 = SR.ReadLine();
            s = int.Parse(line2);
            SR.Close();
            if (s != 0)
            {
                StreamReader sr = new StreamReader(FILENAME);
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (line!="")
                    {
                        p[ii] = FromString(line, ";");
                        ii++;
                    }
                }
                sr.Close();
                n = s;
            }
        }
    }
    public struct piatto
    {
        public string tipo;
        public string nome;
        public string ingrediente1;
        public string ingrediente2;
        public string ingrediente3;
        public string ingrediente4;
        public float prezzo;
    }
}
