
namespace RistoranteM
{
    partial class Conto
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
            this.listBoxPiattiConto = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TogliDalConto = new System.Windows.Forms.ToolStripMenuItem();
            this.IndietroRecupero = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelContoTot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPiattiConto
            // 
            this.listBoxPiattiConto.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxPiattiConto.FormattingEnabled = true;
            this.listBoxPiattiConto.Location = new System.Drawing.Point(35, 49);
            this.listBoxPiattiConto.Name = "listBoxPiattiConto";
            this.listBoxPiattiConto.Size = new System.Drawing.Size(153, 212);
            this.listBoxPiattiConto.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TogliDalConto});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // TogliDalConto
            // 
            this.TogliDalConto.Name = "TogliDalConto";
            this.TogliDalConto.Size = new System.Drawing.Size(152, 22);
            this.TogliDalConto.Text = "Togli dal conto";
            this.TogliDalConto.Click += new System.EventHandler(this.TogliDalConto_Click);
            // 
            // IndietroRecupero
            // 
            this.IndietroRecupero.Location = new System.Drawing.Point(3, 361);
            this.IndietroRecupero.Name = "IndietroRecupero";
            this.IndietroRecupero.Size = new System.Drawing.Size(75, 23);
            this.IndietroRecupero.TabIndex = 4;
            this.IndietroRecupero.Text = "< Indietro";
            this.IndietroRecupero.UseVisualStyleBackColor = true;
            this.IndietroRecupero.Click += new System.EventHandler(this.IndietroRecupero_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 31);
            this.panel1.TabIndex = 5;
            // 
            // labelContoTot
            // 
            this.labelContoTot.AutoSize = true;
            this.labelContoTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelContoTot.Location = new System.Drawing.Point(12, 296);
            this.labelContoTot.Name = "labelContoTot";
            this.labelContoTot.Size = new System.Drawing.Size(60, 24);
            this.labelContoTot.TabIndex = 6;
            this.labelContoTot.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTO";
            // 
            // Conto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 397);
            this.Controls.Add(this.labelContoTot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IndietroRecupero);
            this.Controls.Add(this.listBoxPiattiConto);
            this.MaximumSize = new System.Drawing.Size(237, 436);
            this.MinimumSize = new System.Drawing.Size(237, 436);
            this.Name = "Conto";
            this.Text = "Conto";
            this.Load += new System.EventHandler(this.Conto_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPiattiConto;
        private System.Windows.Forms.Button IndietroRecupero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelContoTot;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TogliDalConto;
        private System.Windows.Forms.Label label1;
    }
}