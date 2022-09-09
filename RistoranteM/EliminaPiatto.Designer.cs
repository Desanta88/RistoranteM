
namespace RistoranteM
{
    partial class EliminaPiatto
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
            this.CancellaPiatto = new System.Windows.Forms.Button();
            this.RicompattaFile = new System.Windows.Forms.Button();
            this.NomePiattoCancella = new System.Windows.Forms.Label();
            this.textBoxPiattoCancella = new System.Windows.Forms.TextBox();
            this.IndietroEli = new System.Windows.Forms.Button();
            this.RecuperoPiatto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancellaPiatto
            // 
            this.CancellaPiatto.Location = new System.Drawing.Point(236, 268);
            this.CancellaPiatto.Name = "CancellaPiatto";
            this.CancellaPiatto.Size = new System.Drawing.Size(117, 31);
            this.CancellaPiatto.TabIndex = 0;
            this.CancellaPiatto.Text = "Cancella Piatto";
            this.CancellaPiatto.UseVisualStyleBackColor = true;
            this.CancellaPiatto.Click += new System.EventHandler(this.CancellaPiatto_Click);
            // 
            // RicompattaFile
            // 
            this.RicompattaFile.Location = new System.Drawing.Point(458, 268);
            this.RicompattaFile.Name = "RicompattaFile";
            this.RicompattaFile.Size = new System.Drawing.Size(117, 31);
            this.RicompattaFile.TabIndex = 1;
            this.RicompattaFile.Text = "Ricompatta il file";
            this.RicompattaFile.UseVisualStyleBackColor = true;
            this.RicompattaFile.Click += new System.EventHandler(this.RicompattaFile_Click);
            // 
            // NomePiattoCancella
            // 
            this.NomePiattoCancella.AutoSize = true;
            this.NomePiattoCancella.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NomePiattoCancella.Location = new System.Drawing.Point(232, 95);
            this.NomePiattoCancella.Name = "NomePiattoCancella";
            this.NomePiattoCancella.Size = new System.Drawing.Size(343, 24);
            this.NomePiattoCancella.TabIndex = 2;
            this.NomePiattoCancella.Text = "Inserisci il nome del piatto da cancellare";
            // 
            // textBoxPiattoCancella
            // 
            this.textBoxPiattoCancella.Location = new System.Drawing.Point(353, 183);
            this.textBoxPiattoCancella.Name = "textBoxPiattoCancella";
            this.textBoxPiattoCancella.Size = new System.Drawing.Size(100, 20);
            this.textBoxPiattoCancella.TabIndex = 3;
            // 
            // IndietroEli
            // 
            this.IndietroEli.Location = new System.Drawing.Point(12, 409);
            this.IndietroEli.Name = "IndietroEli";
            this.IndietroEli.Size = new System.Drawing.Size(99, 29);
            this.IndietroEli.TabIndex = 4;
            this.IndietroEli.Text = "< Indietro";
            this.IndietroEli.UseVisualStyleBackColor = true;
            this.IndietroEli.Click += new System.EventHandler(this.IndietroEli_Click);
            // 
            // RecuperoPiatto
            // 
            this.RecuperoPiatto.Location = new System.Drawing.Point(322, 332);
            this.RecuperoPiatto.Name = "RecuperoPiatto";
            this.RecuperoPiatto.Size = new System.Drawing.Size(165, 50);
            this.RecuperoPiatto.TabIndex = 5;
            this.RecuperoPiatto.Text = "Recupera piatti cancellati";
            this.RecuperoPiatto.UseVisualStyleBackColor = true;
            this.RecuperoPiatto.Click += new System.EventHandler(this.RecuperoPiatto_Click);
            // 
            // EliminaPiatto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RecuperoPiatto);
            this.Controls.Add(this.IndietroEli);
            this.Controls.Add(this.textBoxPiattoCancella);
            this.Controls.Add(this.NomePiattoCancella);
            this.Controls.Add(this.RicompattaFile);
            this.Controls.Add(this.CancellaPiatto);
            this.Name = "EliminaPiatto";
            this.Text = "EliminaPiatto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancellaPiatto;
        private System.Windows.Forms.Button RicompattaFile;
        private System.Windows.Forms.Label NomePiattoCancella;
        private System.Windows.Forms.TextBox textBoxPiattoCancella;
        private System.Windows.Forms.Button IndietroEli;
        private System.Windows.Forms.Button RecuperoPiatto;
    }
}