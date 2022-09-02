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
    public partial class FormP : Form
    {
        public static string PasswordP;
        public FormP()
        {
            InitializeComponent();
        }
        //mette la password all'interno di una variabile per un controllo nella pagina del login
        private void RegPassP_Click(object sender, EventArgs e)
        {
            PasswordP = TextBoxRegP.Text;
            TextBoxRegP.Text = "";
            Form1.PasswordP = PasswordP;
        }
        //chiude la pagina di registrazione
        private void IndietroP_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
