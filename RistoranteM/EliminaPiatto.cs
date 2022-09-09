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
    public partial class EliminaPiatto : Form
    {
        public int posi;
        public static int pc = 0;
        public static piatto[] PiattiCancellati = new piatto[100];
        public string Filename = @"./numeroPiatti.txt";
        public EliminaPiatto()
        {
            InitializeComponent();
        }
        public static piatto FromString(string piattoStringa, string sep = ";")
        {
            piatto c;
            string[] piattoT;
            c.tipo = "";
            c.nome = "";
            c.prezzo = -1;
            c.ingrediente1 = "";
            c.ingrediente2 = "";
            c.ingrediente3 = "";
            c.ingrediente4 = "";
            //dalla stringa deve ritornare la variabile Voto v settata con  i valori
            piattoT = piattoStringa.Split(';');
            c.tipo =piattoT[0];
            c.nome = piattoT[1];
            c.prezzo = float.Parse(piattoT[2]);
            c.ingrediente1 = piattoT[3];
            c.ingrediente2 = piattoT[4];
            c.ingrediente3 = piattoT[5];
            c.ingrediente4 = piattoT[6];
            return c;
        }
        public static string cercaSuFile(string name, string filename, string sep = ";")
        {
            StreamReader sr = new StreamReader(filename);
            string line = "";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                if (line.Contains(name))
                {
                    sr.Close();
                    return line;
                }
            }
            return line;
        }
         public static void ScriviAppend(string content,string filename)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
        }
        public string ToString(piatto c, string sep = ";"/*se non passo sep il punto e virgola sarà il valore di default*/)
        {
            return c.tipo + sep + c.nome + sep + c.prezzo + sep + c.ingrediente1+ sep + c.ingrediente2 + sep + c.ingrediente3+sep+c.ingrediente4;
        }
        public void AggiungiSulFile(piatto v, string filename)
        {
            ScriviAppend(ToString(v), filename);
        }
        public static piatto cerca(string name, string filename)
        {
            return FromString(cercaSuFile(name, filename));
        }
        public int ricerca(piatto[] c, int n, string name)
        {
            int pos = -1, m = 0;
            for (int i = 0; i < n; i++)
            {
                if (c[i].nome == name)
                {
                    pos = m;
                }
                m++;
            }
            return pos;
        }
        public void Eliminazione(piatto[] c, ref int i, int pos)
        {
            int cont=0,app=0,m=0;

            for (int h = 0; h < i; h++)
            {
                if (c[h].tipo == "")
                {
                    cont++;
                }
            }
            if (c[0].tipo != "")
            {
                for (int q = 0; q < i; q++)
                {
                    if (cont >= 1)
                    {
                        q = 0;
                    }

                    if (c[q].tipo == "")
                    {
                        for (int r = q; r < i; r++)
                        {
                            c[r] = c[r + 1];
                        }
                        i--;
                        cont = app;
                        app = 0;
                    }
                    else
                    {
                        app = cont;
                        cont = 0;
                    }
                }

            }
            else
            {
                for (int q = 0; q < i; q++)
                {
                    if (cont >= 1)
                    {
                        q = 0;
                    }

                    if (c[q].tipo == "")
                    {
                        for (int r = q; r < i; r++)
                        {
                            c[r] = c[r + 1];
                        }
                        i--;
                        if (m >= 1)
                        {
                            cont = app;
                            app = 0;
                        }
                        m++;
                    }
                    else
                    {
                        app = cont;
                        cont = 0;
                    }
                }
            }
        }
        public void EliminazioneLogica(piatto[] c, int i, int pos)
        {
            c[pos].nome = "";
            c[pos].tipo = "";
            c[pos].prezzo = -1;
            c[pos].ingrediente1 = "";
            c[pos].ingrediente2 = "";
            c[pos].ingrediente3 = "";
            c[pos].ingrediente4 = "";
        }
        public void EliminaSulFile(piatto[]c,int i,int pos)
        {
            FileStream fs;
            string percorso = @"./temp.txt";
            fs = File.Create(percorso);
            fs.Close();
            for (int f = 0; f < i; f++)
            {
                AggiungiSulFile(c[f], percorso);
            }
            File.Copy(percorso, "ElencoPiatti.csv", true);
            if (File.Exists(percorso))
                File.Delete(percorso);
        }
        public static void scrivi(string filename, string content)
        {
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(content);
            sw.Close();
        }
        public void RecuperaPiatti(piatto[] c,piatto[] pp,int i,int x)
        {

        }

        private void IndietroEli_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RicompattaFile_Click(object sender, EventArgs e)
        {
            Eliminazione(Proprietario.p, ref Proprietario.n, posi);
            scrivi(Filename, Proprietario.n.ToString());
            EliminaSulFile(Proprietario.p, Proprietario.n, posi);
        }

        private void RecuperoPiatto_Click(object sender, EventArgs e)
        {
            RecuperoPiattiPersi rpp = new RecuperoPiattiPersi();
            rpp.ShowDialog();
        }

        private void CancellaPiatto_Click(object sender, EventArgs e)
        {
            if (textBoxPiattoCancella.Text != "")
            {
                posi = ricerca(Proprietario.p, Proprietario.n, textBoxPiattoCancella.Text);
                PiattiCancellati[pc] = Proprietario.p[posi];
                pc++;
                EliminazioneLogica(Proprietario.p, Proprietario.n, posi);
                EliminaSulFile(Proprietario.p, Proprietario.n, posi);
                textBoxPiattoCancella.Text = "";
            }
        }
    }
}
