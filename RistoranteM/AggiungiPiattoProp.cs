﻿using System;
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
    public partial class AggiungiPiattoProp : Form
    {
        public string filename = @"./ElencoPiatti.csv";
        public string percorso = @"./numeroPiatti.txt";
        public AggiungiPiattoProp()
        {
            InitializeComponent();
            
        }
        public void aggiungi(piatto[] pi, ref int i)
        {
            
            if (i < Proprietario.p.Length)
            {
                pi[i].tipo = textBoxTipoPiatto.Text;
                pi[i].nome = textBoxNomePiatto.Text;
                pi[i].prezzo = float.Parse(textBoxCostoPiatto.Text);
                pi[i].ingrediente1 = Ingrediente1.Text;
                pi[i].ingrediente2 = Ingrediente2.Text;
                pi[i].ingrediente3 = Ingrediente3.Text;
                pi[i].ingrediente4 = Ingrediente4.Text;
                i++;
                textBoxTipoPiatto.Text = "";
                textBoxNomePiatto.Text = "";
                textBoxCostoPiatto.Text = "";
                Ingrediente1.Text = "";
                Ingrediente2.Text = "";
                Ingrediente3.Text = "";
                Ingrediente4.Text = "";
            }
        }
        public static void scrivi(string filename, string content)
        {
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(content);
            sw.Close();
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

        private void IndietroAggiungiPiatto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAggiungiPiatto_Click(object sender, EventArgs e)
        {
            aggiungi(Proprietario.p, ref Proprietario.n);
            AggiungiSulFile(Proprietario.p[Proprietario.n-1], filename);
            scrivi(percorso, Proprietario.n.ToString());
        }
    }
}
