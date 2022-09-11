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
using System.Text.RegularExpressions;

namespace RistoranteM
{
    public partial class ModificaPiatto : Form
    {
        int posi,posizi,count=0;
        public ModificaPiatto()
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
            return pi.tipo + sep + pi.nome + sep + pi.prezzo + sep + pi.ingrediente1 + sep + pi.ingrediente2 + sep + pi.ingrediente3+sep+pi.ingrediente4;
        }
        public void AggiungiSulFile( piatto pi, string filename)
        {
            ScriviAppend(ToString(pi), filename);
        }
        //cerca il piatto da modificare
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

        private void textBoxPiattoDaModificare_TextChanged(object sender, EventArgs e)
        {

        }

        private void IndietroModifica_Click(object sender, EventArgs e)
        {
            Close();
        }
        //modifica il piatto nell'array
        public void Modifica_Piatto(piatto[]c,int pos)
        {
            var errorCounter = Regex.Matches(textBoxNuovoPrezzo.Text, @"[a-zA-Z]").Count;
            if (errorCounter > 1)
            {
                throw new Exception("caratteri alfabetici presenti");
            }
            c[pos].tipo = textBoxNuovoTipo.Text;
            c[pos].nome = textBoxNuovoNome.Text;
            c[pos].prezzo = float.Parse(textBoxNuovoPrezzo.Text);
            c[pos].ingrediente1 = textBoxIng1.Text;
            c[pos].ingrediente2 = textBoxIng2.Text;
            c[pos].ingrediente3 = textBoxIng3.Text;
            c[pos].ingrediente4 = textBoxIng4.Text;
        }
        public void ModificaPiattoSulFile(piatto[]c,int i)
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

        //modifica il piatto 
        private void buttonModifica_Click(object sender, EventArgs e)
        {
            count = 0;
            posizi = 0;
            if (textBoxNuovoTipo.Text == "" || textBoxNuovoNome.Text == "" || textBoxNuovoPrezzo.Text == "" || textBoxIng1.Text == ""|| textBoxIng2.Text == ""|| textBoxIng3.Text == "" || textBoxIng4.Text == "")
            {
                count++;
            }
            posizi = ricerca(Proprietario.p, Proprietario.n, textBoxPiattoDaModificare.Text);
            if(posizi!=-1)
            {
                if (count < 1)
                {
                    posi = ricerca(Proprietario.p, Proprietario.n, textBoxPiattoDaModificare.Text);
                    try
                    {
                        Modifica_Piatto(Proprietario.p, posi);
                        ModificaPiattoSulFile(Proprietario.p, Proprietario.n);
                    }
                    catch(Exception E)
                    {
                        MessageBox.Show("caratteri non numerici presenti");
                    }
                }
                else
                {
                    MessageBox.Show("Scrivi su tutti gli spazi!", "Warning!");
                }
               
            }
            else
            {
                MessageBox.Show("Piatto non trovato", "Warning!");
            }
        }
    }
}
