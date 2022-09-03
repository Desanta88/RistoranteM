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
    public partial class RegCliente : Form
    {
        public string[] Clienti = new string[100];
        public int n=0;
        public int count=0;//variabile che serve per contare il numero di volte che scrivi la password avendola scritta precedentemente senza prima uscire
        string filename = @"./Indice.txt";//file contenente il numero di clienti registrati
        string FILENAME = @"./passwordUtenti.txt";//file contenente le password dei clienti
        string percorso = @"./temp.txt";//file temporaneo

        //aggiunge il contenuto nel file
        public void AggiungiSulFile(string v, string filename)
        {
            ScriviAppend(v, filename);
        }
        //crea un file temporaneo in cui ci saranno tutte le password compresa quella aggiunta al momento,poi le copia in un altro file e cancella il file temporaneo
        public void aggiuntaNelFile(string[] a,string perc,int i)
        {
            FileStream fs;
            fs = File.Create(perc);
            fs.Close();
            for (int f = 0; f < i; f++)
            {
                AggiungiSulFile(a[f], perc);
            }
            File.Copy(perc, FILENAME, true);
            if (File.Exists(perc))
                File.Delete(perc);
        }
        //scrive il contenuto nel file
        public static void scrivi(string filename, string content)
        {
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(content);
            sw.Close();
        }
        //scrive il contenuto nel file
        public static void ScriviAppend(string content, string filename)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
        }
        //aggiunge password nel file
        public void AggiuntaC(string[] c,ref int i,ref int counter)
        {  
            if (TextBoxRegC.Text != "" && i<c.Length && counter<1)
            {
                c[i] = TextBoxRegC.Text;
                TextBoxRegC.Text = "";
                Form1.Clientela[i] = Clienti[i];
                i++;
            }
            counter++;
        }
        //ogni volta che si apre il form3,le informazioni contenenti nei file verranno messe in variabili apposite
        public RegCliente()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(filename);
            StreamReader SR = new StreamReader(FILENAME);
            string number, line;
            int nn = 0;
            number = sr.ReadLine();
            n = int.Parse(number);
            sr.Close();
            if (n != 0)
            {
                while (!SR.EndOfStream)
                {
                    line = SR.ReadLine();
                    Clienti[nn] = line;
                    nn++;
                }
            }
            SR.Close();
        }
        //ogni volta che viene premuto questo bottone,la password verrà aggiunta al file e all'array di stringhe
        private void RegPassC_Click(object sender, EventArgs e)
        {
            AggiuntaC(Clienti, ref n,ref count);
            scrivi(filename, n.ToString());
            aggiuntaNelFile(Clienti, percorso, n);
            Form1.nc = n;
            Form1.Clientela = Clienti;
        }
        //ogni volta che viene premuto questo bottone,si uscirà dal form3
        private void IndietroC_Click(object sender, EventArgs e)
        {
            Close();
        }
        //ogni volta che si chiude il form3,count=0 
        private void RegCliente_Closed(object sender, EventArgs e)
        {
            count=0;
        }

    }
}
