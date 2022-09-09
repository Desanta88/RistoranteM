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
    public partial class RecuperoPiattiPersi : Form
    {
        string filename = @"./ElencoPiatti.csv";
        string Filename = @"./numeroPiatti.txt";
        public RecuperoPiattiPersi()
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
        public void ModificaPiattoSulFile(piatto[] c, int i)
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
        public void Eliminazione(piatto[] v, ref int n, int pos)
        {
            for (int r = pos; r < n - 1; r++)
            {
                v[pos] = v[pos + 1];
                pos++;
            }
            n--;
        }
        public void RipristinoPiatto(piatto[] c, piatto[] pc,ref int i)
        {
            int PCcounter = 0, counterPC = 0, count = 0;
            PCcounter = listBoxPiattiCanc.SelectedIndex;
            for (int t = 0; t < i; t++)
            {
                if (Proprietario.p[t].tipo == "")
                    count++;
            }
            if (count > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Proprietario.p[j].tipo == "" && counterPC == 0)
                    {
                        Proprietario.p[j] = EliminaPiatto.PiattiCancellati[PCcounter];
                        Eliminazione(EliminaPiatto.PiattiCancellati, ref EliminaPiatto.pc, PCcounter);
                        listBoxPiattiCanc.Items.RemoveAt(PCcounter);
                        counterPC++;
                    }
                }
                ModificaPiattoSulFile(c, i);
            }
            else
            {
                i++;
                scrivi(Filename, i.ToString());
                Proprietario.p[i] = EliminaPiatto.PiattiCancellati[PCcounter];
                listBoxPiattiCanc.Items.RemoveAt(PCcounter);
                AggiungiSulFile(EliminaPiatto.PiattiCancellati[PCcounter], filename);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RipristinoPiatto(Proprietario.p, EliminaPiatto.PiattiCancellati, ref Proprietario.n);
        }

        private void listBoxPiattiCanc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RecuperoPiattiPersi_Load(object sender, EventArgs e)
        {
            for(int s = 0; s < EliminaPiatto.pc; s++)
            {
                listBoxPiattiCanc.Items.Add(EliminaPiatto.PiattiCancellati[s].nome);
            }
        }

        private void IndietroRecupero_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
