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
    public partial class CercaPiatto : Form
    {
        string filename = @"./ElencoPiatti.csv";
        piatto P;
        public CercaPiatto()
        {
            InitializeComponent();
        }
        public static void ScriviAppend(string content, string filename)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
        }
        public string ToString(piatto pi, string sep = ";"/*se non passo sep il punto e virgola sarà il valore di default*/)
        {
            return pi.tipo + sep + pi.nome + sep + pi.prezzo + sep + pi.ingrediente1 + sep + pi.ingrediente2 + sep + pi.ingrediente3 + sep + pi.ingrediente4;
        }
        public void AggiungiSulFile(piatto pi, string filename)
        {
            ScriviAppend(ToString(pi), filename);
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
            v.tipo =piattoC[0];
            v.nome = piattoC[1];
            v.prezzo = float.Parse(piattoC[2]);
            v.ingrediente1 = piattoC[3];
            v.ingrediente2 = piattoC[4];
            v.ingrediente3 = piattoC[5];
            v.ingrediente4 = piattoC[6];
            return v;
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
        public static piatto cerca_Piatto(string name, string filename)
        {
            return FromString(cercaSuFile(name, filename));
        }


        private void CercaPiatto_Load(object sender, EventArgs e)
        {

        }

        private void IndietroCercaP_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCercaPiatto_Click(object sender, EventArgs e)
        {
            P = cerca_Piatto(textBoxPiattoDaCercare.Text, filename);
            label4.Text = "tipo: " + P.tipo;
            label4.Visible = true;
            label5.Text = "nome: " + P.nome;
            label5.Visible = true;
            label6.Text = "prezzo: " + P.prezzo.ToString()+" euro";
            label6.Visible = true;
            label7.Text = "primo ingrediente: " + P.ingrediente1;
            label7.Visible = true;
            label8.Text = "secondo ingrediente: " + P.ingrediente2;
            label8.Visible = true;
            label9.Text = "terzo ingrediente: " + P.ingrediente3;
            label9.Visible = true;
            label10.Text = "quarto ingrediente: " + P.ingrediente4;
            label10.Visible = true;
        }
    }
}
