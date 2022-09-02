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
        public int n;

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
        public void AggiuntaC(string[] c,ref int i)
        {
            i = 0;
            int counter = 0;
            if (TextBoxRegC.Text != "" && i<c.Length && counter<1)
            {
                c[i] = TextBoxRegC.Text;
                TextBoxRegC.Text = "";
                counter++;
            }
            i++;
        }
        private void RegCliente_Load(object sender, EventArgs e)
        {

        }
        public RegCliente()
        {
            InitializeComponent();
        }

        private void RegPassC_Click(object sender, EventArgs e)
        {
            AggiuntaC(Clienti, ref n);
        }

        private void IndietroC_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RegCliente_Closed(object sender, EventArgs e)
        {

        }
    }
}
