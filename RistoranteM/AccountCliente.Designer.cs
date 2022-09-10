
namespace RistoranteM
{
    partial class cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EsciCliente = new System.Windows.Forms.Button();
            this.PrezzoTotale = new System.Windows.Forms.Button();
            this.ordinaPiatti = new System.Windows.Forms.Button();
            this.GuidaOrdinePiatti = new System.Windows.Forms.Button();
            this.contextMenuStripIng = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewAntipasti = new System.Windows.Forms.ListView();
            this.nomeAntipasti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.costoAntipasti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeDesserts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.costoDesserts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDesserts = new System.Windows.Forms.ListView();
            this.nomeSecondi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.costoSecondi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSecondi = new System.Windows.Forms.ListView();
            this.nomePrimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.costoPrimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPrimi = new System.Windows.Forms.ListView();
            this.contextMenuStripIng.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 42);
            this.panel1.TabIndex = 1;
            // 
            // EsciCliente
            // 
            this.EsciCliente.Location = new System.Drawing.Point(12, 415);
            this.EsciCliente.Name = "EsciCliente";
            this.EsciCliente.Size = new System.Drawing.Size(75, 23);
            this.EsciCliente.TabIndex = 1;
            this.EsciCliente.Text = "Esci";
            this.EsciCliente.UseVisualStyleBackColor = true;
            this.EsciCliente.Click += new System.EventHandler(this.EsciCliente_Click);
            // 
            // PrezzoTotale
            // 
            this.PrezzoTotale.Location = new System.Drawing.Point(315, 400);
            this.PrezzoTotale.Name = "PrezzoTotale";
            this.PrezzoTotale.Size = new System.Drawing.Size(102, 42);
            this.PrezzoTotale.TabIndex = 2;
            this.PrezzoTotale.Text = "Vedi il conto";
            this.PrezzoTotale.UseVisualStyleBackColor = true;
            this.PrezzoTotale.Click += new System.EventHandler(this.PrezzoTotale_Click);
            // 
            // ordinaPiatti
            // 
            this.ordinaPiatti.Location = new System.Drawing.Point(474, 400);
            this.ordinaPiatti.Name = "ordinaPiatti";
            this.ordinaPiatti.Size = new System.Drawing.Size(102, 42);
            this.ordinaPiatti.TabIndex = 3;
            this.ordinaPiatti.Text = "Ordina piatti scelti";
            this.ordinaPiatti.UseVisualStyleBackColor = true;
            this.ordinaPiatti.Click += new System.EventHandler(this.ordinaPiatti_Click);
            // 
            // GuidaOrdinePiatti
            // 
            this.GuidaOrdinePiatti.Location = new System.Drawing.Point(822, 405);
            this.GuidaOrdinePiatti.Name = "GuidaOrdinePiatti";
            this.GuidaOrdinePiatti.Size = new System.Drawing.Size(34, 33);
            this.GuidaOrdinePiatti.TabIndex = 3;
            this.GuidaOrdinePiatti.Text = "?";
            this.GuidaOrdinePiatti.UseVisualStyleBackColor = true;
            this.GuidaOrdinePiatti.Click += new System.EventHandler(this.GuidaOrdinePiatti_Click);
            // 
            // contextMenuStripIng
            // 
            this.contextMenuStripIng.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStripIng.Name = "contextMenuStripIng";
            this.contextMenuStripIng.Size = new System.Drawing.Size(157, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem1.Text = "Vedi ingredienti";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem2.Text = "Metti sul conto";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(65, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Antipasti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(302, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Primi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(496, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Secondi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(709, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desserts";
            // 
            // listViewAntipasti
            // 
            this.listViewAntipasti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomeAntipasti,
            this.costoAntipasti});
            this.listViewAntipasti.ContextMenuStrip = this.contextMenuStripIng;
            this.listViewAntipasti.HideSelection = false;
            this.listViewAntipasti.Location = new System.Drawing.Point(12, 97);
            this.listViewAntipasti.MultiSelect = false;
            this.listViewAntipasti.Name = "listViewAntipasti";
            this.listViewAntipasti.Size = new System.Drawing.Size(206, 290);
            this.listViewAntipasti.TabIndex = 10;
            this.listViewAntipasti.UseCompatibleStateImageBehavior = false;
            this.listViewAntipasti.View = System.Windows.Forms.View.Details;
            // 
            // nomeAntipasti
            // 
            this.nomeAntipasti.Text = "Piatti";
            this.nomeAntipasti.Width = 130;
            // 
            // costoAntipasti
            // 
            this.costoAntipasti.Text = "Costo(euro)";
            this.costoAntipasti.Width = 76;
            // 
            // nomeDesserts
            // 
            this.nomeDesserts.Text = "Piatti";
            this.nomeDesserts.Width = 130;
            // 
            // costoDesserts
            // 
            this.costoDesserts.Text = "Costo(euro)";
            this.costoDesserts.Width = 76;
            // 
            // listViewDesserts
            // 
            this.listViewDesserts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomeDesserts,
            this.costoDesserts});
            this.listViewDesserts.ContextMenuStrip = this.contextMenuStripIng;
            this.listViewDesserts.HideSelection = false;
            this.listViewDesserts.Location = new System.Drawing.Point(648, 97);
            this.listViewDesserts.MultiSelect = false;
            this.listViewDesserts.Name = "listViewDesserts";
            this.listViewDesserts.Size = new System.Drawing.Size(206, 290);
            this.listViewDesserts.TabIndex = 13;
            this.listViewDesserts.UseCompatibleStateImageBehavior = false;
            this.listViewDesserts.View = System.Windows.Forms.View.Details;
            // 
            // nomeSecondi
            // 
            this.nomeSecondi.Text = "Piatti";
            this.nomeSecondi.Width = 130;
            // 
            // costoSecondi
            // 
            this.costoSecondi.Text = "Costo(euro)";
            this.costoSecondi.Width = 76;
            // 
            // listViewSecondi
            // 
            this.listViewSecondi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomeSecondi,
            this.costoSecondi});
            this.listViewSecondi.ContextMenuStrip = this.contextMenuStripIng;
            this.listViewSecondi.HideSelection = false;
            this.listViewSecondi.Location = new System.Drawing.Point(436, 97);
            this.listViewSecondi.MultiSelect = false;
            this.listViewSecondi.Name = "listViewSecondi";
            this.listViewSecondi.Size = new System.Drawing.Size(206, 290);
            this.listViewSecondi.TabIndex = 12;
            this.listViewSecondi.UseCompatibleStateImageBehavior = false;
            this.listViewSecondi.View = System.Windows.Forms.View.Details;
            // 
            // nomePrimi
            // 
            this.nomePrimi.Text = "Piatti";
            this.nomePrimi.Width = 130;
            // 
            // costoPrimi
            // 
            this.costoPrimi.Text = "Costo(euro)";
            this.costoPrimi.Width = 76;
            // 
            // listViewPrimi
            // 
            this.listViewPrimi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomePrimi,
            this.costoPrimi});
            this.listViewPrimi.ContextMenuStrip = this.contextMenuStripIng;
            this.listViewPrimi.HideSelection = false;
            this.listViewPrimi.Location = new System.Drawing.Point(224, 97);
            this.listViewPrimi.MultiSelect = false;
            this.listViewPrimi.Name = "listViewPrimi";
            this.listViewPrimi.Size = new System.Drawing.Size(206, 290);
            this.listViewPrimi.TabIndex = 11;
            this.listViewPrimi.UseCompatibleStateImageBehavior = false;
            this.listViewPrimi.View = System.Windows.Forms.View.Details;
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.listViewDesserts);
            this.Controls.Add(this.listViewSecondi);
            this.Controls.Add(this.listViewPrimi);
            this.Controls.Add(this.listViewAntipasti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuidaOrdinePiatti);
            this.Controls.Add(this.EsciCliente);
            this.Controls.Add(this.PrezzoTotale);
            this.Controls.Add(this.ordinaPiatti);
            this.Controls.Add(this.panel1);
            this.Name = "cliente";
            this.Text = "AccountCliente";
            this.Load += new System.EventHandler(this.cliente_Load);
            this.contextMenuStripIng.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EsciCliente;
        private System.Windows.Forms.Button PrezzoTotale;
        private System.Windows.Forms.Button ordinaPiatti;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIng;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button GuidaOrdinePiatti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewAntipasti;
        private System.Windows.Forms.ColumnHeader nomeAntipasti;
        private System.Windows.Forms.ColumnHeader costoAntipasti;
        private System.Windows.Forms.ColumnHeader nomeDesserts;
        private System.Windows.Forms.ColumnHeader costoDesserts;
        private System.Windows.Forms.ListView listViewDesserts;
        private System.Windows.Forms.ColumnHeader nomeSecondi;
        private System.Windows.Forms.ColumnHeader costoSecondi;
        private System.Windows.Forms.ListView listViewSecondi;
        private System.Windows.Forms.ColumnHeader nomePrimi;
        private System.Windows.Forms.ColumnHeader costoPrimi;
        private System.Windows.Forms.ListView listViewPrimi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}