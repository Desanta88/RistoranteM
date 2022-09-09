
namespace RistoranteM
{
    partial class RecuperoPiattiPersi
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
            this.listBoxPiattiCanc = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.IndietroRecupero = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPiattiCanc
            // 
            this.listBoxPiattiCanc.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxPiattiCanc.FormattingEnabled = true;
            this.listBoxPiattiCanc.Location = new System.Drawing.Point(60, 73);
            this.listBoxPiattiCanc.Name = "listBoxPiattiCanc";
            this.listBoxPiattiCanc.Size = new System.Drawing.Size(153, 212);
            this.listBoxPiattiCanc.TabIndex = 0;
            this.listBoxPiattiCanc.SelectedIndexChanged += new System.EventHandler(this.listBoxPiattiCanc_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 46);
            this.panel1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuItem1.Text = "Ripristina";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // IndietroRecupero
            // 
            this.IndietroRecupero.Location = new System.Drawing.Point(12, 343);
            this.IndietroRecupero.Name = "IndietroRecupero";
            this.IndietroRecupero.Size = new System.Drawing.Size(75, 23);
            this.IndietroRecupero.TabIndex = 3;
            this.IndietroRecupero.Text = "< Indietro";
            this.IndietroRecupero.UseVisualStyleBackColor = true;
            this.IndietroRecupero.Click += new System.EventHandler(this.IndietroRecupero_Click);
            // 
            // RecuperoPiattiPersi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 388);
            this.Controls.Add(this.IndietroRecupero);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxPiattiCanc);
            this.Name = "RecuperoPiattiPersi";
            this.Text = "RecuperoPiattiPersi";
            this.Load += new System.EventHandler(this.RecuperoPiattiPersi_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPiattiCanc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button IndietroRecupero;
    }
}