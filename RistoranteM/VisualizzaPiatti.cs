using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RistoranteM
{
    public partial class VisualizzaPiatti : Form
    {
         piatto[] Antipasti = new piatto[100];
         piatto[] Primi = new piatto[100];
         piatto[] Secondi = new piatto[100];
         piatto[] Dessert = new piatto[100];
         int ca = 0, cpr = 0, cs = 0, cd = 0;
        public VisualizzaPiatti()
        {
            InitializeComponent();
            
        }
        //aggiunge i piatti nelle varie tab
        public void piattiAntipasti(piatto[] a,int aa)
        {
            for(int i = 0; i < aa; i++)
            {
                listBoxAntipasti.Items.Add(a[i].nome);
            }
        }
        public void piattiPrimi(piatto[] pr, int prpr)
        {
            for (int i = 0; i < prpr; i++)
            {
                listBoxPrimi.Items.Add(pr[i].nome);
            }
        }
        public void piattiSecondi(piatto[] s, int ss)
        {
            for (int i = 0; i < ss; i++)
            {
                listBoxSecondi.Items.Add(s[i].nome);
            }
        }
        public void piattiDessert(piatto[] d, int dd)
        {
            for (int i = 0; i < dd; i++)
            {
                listBoxDessert.Items.Add(d[i].nome);
            }
        }

        private void VisualizzaPiatti_Load(object sender, EventArgs e)
        {
            OrdinamentoPiatti(Proprietario.p, Antipasti, Primi, Secondi, Dessert, Proprietario.n, ref ca, ref cpr, ref cs, ref cd);
            piattiAntipasti(Antipasti, ca);
            piattiPrimi(Primi, cpr);
            piattiSecondi(Secondi, cs);
            piattiDessert(Dessert, cd);
        }
        //ordina i piatti negli array specifici
        public void OrdinamentoPiatti(piatto[] c,piatto[] a,piatto[] pr,piatto[] s,piatto[] d,int i,ref int aa,ref int prpr,ref int ss,ref int dd)
        {
            for(int f = 0; f < i; f++)
            {
                if (c[f].tipo == "Antipasto" ||  c[f].tipo == "antipasto" || c[f].tipo == "antipasti" || c[f].tipo == "Antipasti")
                {
                    a[ca] = c[f];
                    aa++;
                }
                else if(c[f].tipo == "Primo"|| c[f].tipo == "primo" || c[f].tipo == "Primi" || c[f].tipo == "primi")
                {
                    pr[cpr] = c[f];
                    prpr++;
                }
                else if (c[f].tipo == "Secondo"|| c[f].tipo == "secondo" || c[f].tipo == "Secondi" || c[f].tipo == "secondi")
                {
                    s[cs] = c[f];
                    ss++;
                }
                else if (c[f].tipo == "Dessert"||c[f].tipo == "dessert"||c[f].tipo == "Desserts"|| c[f].tipo == "desserts")
                {
                    d[cd] = c[f];
                    dd++;
                }
            }
        }
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IndietroVP_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
