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
    public partial class Login : Form
    {
        public static string PasswordP;
        public static string PasswordC;
        public int posi;
        public static int nc;
        public static string[] Clientela = new string[100];
        public string Filename = @"./Indice.txt";
        string FILENAME = @"./passwordUtenti.txt";
        string FILEname = @"./passwordProprietario.txt";
        FormP RegProp;
        public Login()
        {
            InitializeComponent();
            //ogni volta che si apre il programma legge le informazioni contenuti nei file e li mette in variabili apposite
            StreamReader sr = new StreamReader(Filename);
            StreamReader SR = new StreamReader(FILENAME);
            StreamReader sR = new StreamReader(FILEname);
            string number, line,line2;
            int nn = 0;
            number = sr.ReadLine();
            nc = int.Parse(number);
            sr.Close();
            if (nc != 0)
            {
                while (!SR.EndOfStream)
                {
                    line = SR.ReadLine();
                    Clientela[nn] = line;
                    nn++;
                }
            }
            SR.Close();
            line2 = sR.ReadLine();
            PasswordP = line2;
            sR.Close();
        }
        public int ricerca(string[] c, int n, string pass)
        {
            int pos = -1, m = 0;
            for (int i = 0; i < n; i++)
            {
                if (c[i] == pass)
                {
                    pos = m;
                }
                m++;
            }
            return pos;
        }
        //porta alla pagina della registrazione
        private void RegistrazioneProprietario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegProp = new FormP();
            RegProp.ShowDialog();
        }
        //controlla se la password inserita è uguale a quella impostata.Se è giusta,allora fa accedere al menù
        private void Prop_Click(object sender, EventArgs e)
        {
            if (PasswordP != "")
            {
                if (PassP.Text == PasswordP)
                {
                    Proprietario p = new Proprietario();
                    p.ShowDialog();
                    PassP.Text = "";
                }
            }

        }
        //fa un controllo della password.Se è giusta,allora fa accedere al menù
        private void Cliente_Click(object sender, EventArgs e)
        {
            PasswordC = PassC.Text;
            if (PasswordC != "" && nc!=0)
            {
                posi=ricerca(Clientela, nc, PasswordC);
                if (posi != -1)
                {
                    cliente cl = new cliente();
                    cl.ShowDialog();
                    PassC.Text = "";
                }
                else
                {

                }
            }

        }
        //apre la pagina di registrazione del cliente
        private void RegistrazioneCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegCliente cli = new RegCliente();
            cli.ShowDialog();
        }
    }
}
