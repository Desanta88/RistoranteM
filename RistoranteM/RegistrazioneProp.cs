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
    public partial class FormP : Form
    {
        public static string PasswordP;
        public string filename=@"./passwordProprietario.txt";
        public int count = 0;//variabile che serve per contare il numero di volte che scrivi la password avendola scritta precedentemente senza prima uscire
        
        //scrive il contenuto nel file
        public static void scrivi(string filename, string content)
        {
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(content);
            sw.Close();
        }

        public FormP()
        {
            InitializeComponent();
      
        }
        //mette la password all'interno di una variabile per un controllo nella pagina del login,se count è minore di 1 e se la lunghezza della password è minore o uguale a 16
        private void RegPassP_Click(object sender, EventArgs e)
        {
            if (count < 1 && TextBoxRegP.Text.Length<=12)
            {
                PasswordP = TextBoxRegP.Text;
                TextBoxRegP.Text = "";
                Login.PasswordP = PasswordP;
                scrivi(filename, PasswordP);
                count++;
            }
           
        }
        //chiude la pagina di registrazione
        private void IndietroP_Click(object sender, EventArgs e)
        {      
            Close();
        }
        //ogni volta che si chiude il form2,count=0
        private void FormP_Closed(object sender, EventArgs e)
        {
            count = 0;
        }
    }
}
