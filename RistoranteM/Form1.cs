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
    public partial class Form1 : Form
    {
        public static string PasswordP;
        public static string PasswordC;
        FormP RegProp;
        public Form1()
        {
            InitializeComponent();
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
                }
            }

        }
        //fa un controllo della password.Se è giusta,allora fa accedere al menù
        private void Cliente_Click(object sender, EventArgs e)
        {
            if (PasswordC != "")
            {
                if (PassP.Text == PasswordP)
                {
                    cliente c = new cliente();
                    c.ShowDialog();
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
