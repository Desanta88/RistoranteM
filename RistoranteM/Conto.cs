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
    public partial class Conto : Form
    {
        int index=0;
        public static bool piattiOrdinati = true;
        string[] PIATTIORDINATI = new string[100];
        
        public Conto()
        {
            InitializeComponent();
        }
        // elimina il piatto dall'array dei piatti ordinati
        public void Eliminazione(string[] v, ref int n, int pos)
        {
            for (int r = pos; r < n - 1; r++)
            {
                v[pos] = v[pos + 1];
                pos++;
            }
            n--;
        }
        private void IndietroRecupero_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Conto_Load(object sender, EventArgs e)
        {          
            labelContoTot.Text = cliente.conto.ToString() + " euro";
            for (int i = 0; i < cliente.npo; i++)
            {
                listBoxPiattiConto.Items.Add(cliente.piattiOrdinati[i]);   
            }
            if (cliente.PiattiO == true)
            {
                listBoxPiattiConto.Items.Clear();
                cliente.PiattiO = false;
            }
        }

        //toglie piatto dal conto
        private void TogliDalConto_Click(object sender, EventArgs e)
        {
                index = listBoxPiattiConto.SelectedIndex;
                cliente.conto = cliente.conto - cliente.PO[index].prezzo;
                labelContoTot.Text = cliente.conto.ToString() + " euro";
                Eliminazione(cliente.piattiOrdinati, ref cliente.npo, index);
                listBoxPiattiConto.Items.RemoveAt(index);
        }
    }
}
