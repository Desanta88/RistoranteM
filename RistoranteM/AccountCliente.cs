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
    public partial class cliente : Form
    {
        piatto[] Antipasti = new piatto[100];
        piatto[] Primi = new piatto[100];
        piatto[] Secondi = new piatto[100];
        piatto[] Dessert = new piatto[100];
        piatto[] Piatti = new piatto[100];
        public static piatto[] PO = new piatto[100];
        public static piatto[] PoIng = new piatto[100];
        public static string[] piattiOrdinati = new string[100];
        public static string[] piattiIng = new string[100];
        int ca = 0, cpr = 0, cs = 0, cd = 0, np = 0,m=0;
        public static int npo = 0, nPoS = 0;
        public static float conto=0;
        string FILENAME = @"./ElencoPiatti.csv";
        string iFilename = @"./numeroPiatti.txt";
        string piattoOrdinatoA, piattoOrdinatoP, piattoOrdinatoS, piattoOrdinatoD;
        int poA, poP, poS, poD;
        public static bool PiattiO=false;

        //apre la guida
        private void GuidaOrdinePiatti_Click(object sender, EventArgs e)
        {
            GuidaPerOrdinarePiatti G = new GuidaPerOrdinarePiatti();
            G.ShowDialog();
        }

        public cliente()
        {
            InitializeComponent();
        }
        //aggiunge i piatti considerati antipasti nella listview dedicata ad essi
        public void piattiAntipasti(piatto[] a,int aa)
        {
            for (int i = 0; i < aa; i++)
            {
                ListViewItem A = new ListViewItem(a[i].nome);
                A.SubItems.Add(a[i].prezzo.ToString());
                listViewAntipasti.Items.Add(A);
            }
        }
        //aggiunge i piatti considerati primi nella listview dedicata ad essi
        public void piattiPrimi(piatto[] pr, int prpr)
        {
            for (int i = 0; i < prpr; i++)
            {
                ListViewItem P = new ListViewItem(pr[i].nome);
                P.SubItems.Add(pr[i].prezzo.ToString());
                listViewPrimi.Items.Add(P);
            }
        }
        //aggiunge i piatti considerati secondi nella listview dedicata ad essi
        public void piattiSecondi(piatto[] s, int ss)
        {
            for (int i = 0; i < ss; i++)
            {
                ListViewItem S = new ListViewItem(s[i].nome);
                S.SubItems.Add(s[i].prezzo.ToString());
                listViewSecondi.Items.Add(S);
            }
        }

        //aggiunge i piatti considerati dessert nella listview dedicata ad essi
        public void piattiDessert(piatto[] d, int dd)
        {
            for (int i = 0; i < dd; i++)
            {
                ListViewItem D = new ListViewItem(d[i].nome);
                D.SubItems.Add(d[i].prezzo.ToString());
                listViewDesserts.Items.Add(D);
            }
        }
        //mette il piatto scelto nel conto
        private void listviewConto(int Aop,int Pop,int Sop,int Dop,string piaorA,string piaorP,string piaorS,string piaorD,string[] PiaOr,ref int NPO,piatto[]Po,ref int NPOS)
        {
            Aop = listViewAntipasti.SelectedItems.Count;
            Pop = listViewPrimi.SelectedItems.Count;
            Sop = listViewSecondi.SelectedItems.Count;
            Dop = listViewDesserts.SelectedItems.Count;
            if (Aop > 0)
                piaorA = listViewAntipasti.SelectedItems[0].Text;
            else if (Pop > 0)
                piaorP = listViewPrimi.SelectedItems[0].Text;
            else if (Sop > 0)
                piaorS = listViewSecondi.SelectedItems[0].Text;
            else if (Dop > 0)
                piaorD = listViewDesserts.SelectedItems[0].Text;

            for (int i = 0; i < m; i++)
            {
                if (piaorA == Piatti[i].nome && Aop > 0)
                {
                    PiaOr[NPO] = listViewAntipasti.SelectedItems[0].Text;
                    NPO++;
                    Po[NPOS] = Piatti[i];
                    nPoS++;
                    conto = conto + Piatti[i].prezzo;
                    Aop = 0;
                    piaorA = "";
                }
                else if (piaorP == Piatti[i].nome && Pop > 0)
                {
                    PiaOr[NPO] = listViewPrimi.SelectedItems[0].Text;
                    NPO++;
                    Po[NPOS] = Piatti[i];
                    nPoS++;
                    conto = conto + Piatti[i].prezzo;
                    Pop = 0;
                    piaorP = "";
                }
                else if (piaorS == Piatti[i].nome && Sop > 0)
                {
                    PiaOr[NPO] = listViewSecondi.SelectedItems[0].Text;
                    NPO++;
                    Po[NPOS] = Piatti[i];
                    nPoS++;
                    conto = conto + Piatti[i].prezzo;
                    Sop = 0;
                    piaorS = "";
                }
                else if (piaorD == Piatti[i].nome && Dop > 0)
                {
                    PiaOr[NPO] = listViewDesserts.SelectedItems[0].Text;
                    NPO++;
                    Po[NPOS] = Piatti[i];
                    nPoS++;
                    conto = conto + Piatti[i].prezzo;
                    Dop = 0;
                    piaorD = "";
                }

            }

        }
        // mostra gli ingredienti del piatto scelto 
        public void VisualizzaIngredienti(int Aop, int Pop, int Sop, int Dop, string piaorA, string piaorP, string piaorS, string piaorD)
        {
            Aop = listViewAntipasti.SelectedItems.Count;
            Pop = listViewPrimi.SelectedItems.Count;
            Sop = listViewSecondi.SelectedItems.Count;
            Dop = listViewDesserts.SelectedItems.Count;
            if (Aop > 0)
                piaorA = listViewAntipasti.SelectedItems[0].Text;
            else if (Pop > 0)
                piaorP = listViewPrimi.SelectedItems[0].Text;
            else if (Sop > 0)
                piaorS = listViewSecondi.SelectedItems[0].Text;
            else if (Dop > 0)
                piaorD = listViewDesserts.SelectedItems[0].Text;

            for (int i = 0; i < m; i++)
            {
                if (piaorA == Piatti[i].nome && Aop > 0)
                {
                    MessageBox.Show("Primo ingrediente:" + Piatti[i].ingrediente1 + Environment.NewLine + "Secondo ingrediente:" + Piatti[i].ingrediente2 + Environment.NewLine + "Terzo ingrediente:" + Piatti[i].ingrediente3 + Environment.NewLine + "Quarto ingrediente:" + Piatti[i].ingrediente4,"Ingredienti");
                    Aop = 0;
                    piaorA = "";
                }
                else if (piaorP == Piatti[i].nome && Pop > 0)
                {
                    MessageBox.Show("Primo ingrediente:" + Piatti[i].ingrediente1 + Environment.NewLine + "Secondo ingrediente:" + Piatti[i].ingrediente2 + Environment.NewLine + "Terzo ingrediente:" + Piatti[i].ingrediente3 + Environment.NewLine + "Quarto ingrediente:" + Piatti[i].ingrediente4,"Ingredienti");
                    Pop = 0;
                    piaorP = "";
                }
                else if (piaorS == Piatti[i].nome && Sop > 0)
                {
                    MessageBox.Show("Primo ingrediente:" + Piatti[i].ingrediente1 + Environment.NewLine + "Secondo ingrediente:" + Piatti[i].ingrediente2 + Environment.NewLine + "Terzo ingrediente:" + Piatti[i].ingrediente3 + Environment.NewLine + "Quarto ingrediente:" + Piatti[i].ingrediente4, "Ingredienti");
                    Sop = 0;
                    piaorS = "";
                }
                else if (piaorD == Piatti[i].nome && Dop > 0)
                {
                    MessageBox.Show("Primo ingrediente:" + Piatti[i].ingrediente1 + Environment.NewLine + "Secondo ingrediente:" + Piatti[i].ingrediente2 + Environment.NewLine + "Terzo ingrediente:" + Piatti[i].ingrediente3 + Environment.NewLine + "Quarto ingrediente:" + Piatti[i].ingrediente4, "Ingredienti");
                    Dop = 0;
                    piaorD = "";
                }

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisualizzaIngredienti(poA, poP, poS, poD, piattoOrdinatoA, piattoOrdinatoP, piattoOrdinatoS, piattoOrdinatoD);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listviewConto(poA, poP, poS, poD, piattoOrdinatoA, piattoOrdinatoP, piattoOrdinatoS, piattoOrdinatoD, piattiOrdinati, ref npo,PO,ref nPoS);
        }

        private void PrezzoTotale_Click(object sender, EventArgs e)
        {
            Conto con = new Conto();
            con.ShowDialog();
        }

        //fa apparire una messagebox che fa sapere all'utente che i piatti sono stati ordinati
        private void ordinaPiatti_Click(object sender, EventArgs e)
        {
            if (conto != 0)
            {
                MessageBox.Show("Piatti Ordinati con successo,Bon appetit!");
                PiattiO = true;
                Array.Clear(piattiOrdinati, 0,npo);
                conto = 0;
                npo = 0;
            }
            else
            {
                MessageBox.Show("Non hai ordinato nessun piatto!");
            }
        }
        //ordina tutti i piatti presenti nel programma nei 4 array rispettivi
        public void OrdinamentoPiatti(piatto[] c, piatto[] a, piatto[] pr, piatto[] s, piatto[] d, int i, ref int aa, ref int prpr, ref int ss, ref int dd)
        {
            for (int f = 0; f < i; f++)
            {
                if (c[f].tipo == "Antipasto" || c[f].tipo == "antipasto" || c[f].tipo == "antipasti" || c[f].tipo == "Antipasti")
                {
                    a[ca] = c[f];
                    aa++;
                }
                else if (c[f].tipo == "Primo" || c[f].tipo == "primo" || c[f].tipo == "Primi" || c[f].tipo == "primi")
                {
                    pr[cpr] = c[f];
                    prpr++;
                }
                else if (c[f].tipo == "Secondo" || c[f].tipo == "secondo" || c[f].tipo == "Secondi" || c[f].tipo == "secondi")
                {
                    s[cs] = c[f];
                    ss++;
                }
                else if (c[f].tipo == "Dessert" || c[f].tipo == "dessert" || c[f].tipo == "Desserts" || c[f].tipo == "desserts")
                {
                    d[cd] = c[f];
                    dd++;
                }
            }
        }
        //prende una riga dal file e la mette in una variabile di tipo piatto
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
            v.tipo = piattoC[0];
            v.nome = piattoC[1];
            v.prezzo = float.Parse(piattoC[2]);
            v.ingrediente1 = piattoC[3];
            v.ingrediente2 = piattoC[4];
            v.ingrediente3 = piattoC[5];
            v.ingrediente4 = piattoC[6];
            return v;
        }

        private void EsciCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cliente_Load(object sender, EventArgs e)
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
                    Piatti[np] = FromString(line, ";");
                    np++;
                }
                sr.Close();
                m = s;
            }

            OrdinamentoPiatti(Piatti, Antipasti, Primi, Secondi, Dessert, m, ref ca, ref cpr, ref cs, ref cd);
            piattiAntipasti(Antipasti,ca);
            piattiPrimi(Primi, cpr);
            piattiSecondi(Secondi, cs);
            piattiDessert(Dessert, cd);
            conto = 0;
        }
    }
}
