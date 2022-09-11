
namespace RistoranteM
{
    partial class Proprietario
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AggiungiPiatto = new System.Windows.Forms.Button();
            this.ModificaPiatto = new System.Windows.Forms.Button();
            this.CercaPiatto = new System.Windows.Forms.Button();
            this.VisualizzaPiatti = new System.Windows.Forms.Button();
            this.EliminaPiatto = new System.Windows.Forms.Button();
            this.IndietroPiatto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(801, 47);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AggiungiPiatto
            // 
            this.AggiungiPiatto.Location = new System.Drawing.Point(12, 83);
            this.AggiungiPiatto.Name = "AggiungiPiatto";
            this.AggiungiPiatto.Size = new System.Drawing.Size(186, 97);
            this.AggiungiPiatto.TabIndex = 0;
            this.AggiungiPiatto.Text = "AGGIUNGI PIATTO";
            this.AggiungiPiatto.UseVisualStyleBackColor = true;
            this.AggiungiPiatto.Click += new System.EventHandler(this.AggiungiPiatto_Click);
            // 
            // ModificaPiatto
            // 
            this.ModificaPiatto.Location = new System.Drawing.Point(310, 83);
            this.ModificaPiatto.Name = "ModificaPiatto";
            this.ModificaPiatto.Size = new System.Drawing.Size(186, 97);
            this.ModificaPiatto.TabIndex = 1;
            this.ModificaPiatto.Text = "MODIFICA PIATTO";
            this.ModificaPiatto.UseVisualStyleBackColor = true;
            this.ModificaPiatto.Click += new System.EventHandler(this.ModificaPiatto_Click);
            // 
            // CercaPiatto
            // 
            this.CercaPiatto.Location = new System.Drawing.Point(602, 83);
            this.CercaPiatto.Name = "CercaPiatto";
            this.CercaPiatto.Size = new System.Drawing.Size(186, 97);
            this.CercaPiatto.TabIndex = 2;
            this.CercaPiatto.Text = "CERCA PIATTO";
            this.CercaPiatto.UseVisualStyleBackColor = true;
            this.CercaPiatto.Click += new System.EventHandler(this.CercaPiatto_Click);
            // 
            // VisualizzaPiatti
            // 
            this.VisualizzaPiatti.Location = new System.Drawing.Point(160, 268);
            this.VisualizzaPiatti.Name = "VisualizzaPiatti";
            this.VisualizzaPiatti.Size = new System.Drawing.Size(186, 97);
            this.VisualizzaPiatti.TabIndex = 3;
            this.VisualizzaPiatti.Text = "VISUALIZZA PIATTI";
            this.VisualizzaPiatti.UseVisualStyleBackColor = true;
            this.VisualizzaPiatti.Click += new System.EventHandler(this.VisualizzaPiatti_Click);
            // 
            // EliminaPiatto
            // 
            this.EliminaPiatto.Location = new System.Drawing.Point(452, 268);
            this.EliminaPiatto.Name = "EliminaPiatto";
            this.EliminaPiatto.Size = new System.Drawing.Size(186, 97);
            this.EliminaPiatto.TabIndex = 4;
            this.EliminaPiatto.Text = "ELIMINA PIATTO";
            this.EliminaPiatto.UseVisualStyleBackColor = true;
            this.EliminaPiatto.Click += new System.EventHandler(this.EliminaPiatto_Click);
            // 
            // IndietroPiatto
            // 
            this.IndietroPiatto.Location = new System.Drawing.Point(12, 393);
            this.IndietroPiatto.Name = "IndietroPiatto";
            this.IndietroPiatto.Size = new System.Drawing.Size(90, 29);
            this.IndietroPiatto.TabIndex = 5;
            this.IndietroPiatto.Text = "Esci";
            this.IndietroPiatto.UseVisualStyleBackColor = true;
            this.IndietroPiatto.Click += new System.EventHandler(this.IndietroPiatto_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "ACCOUNT PROPRIETARIO";
            // 
            // Proprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IndietroPiatto);
            this.Controls.Add(this.EliminaPiatto);
            this.Controls.Add(this.VisualizzaPiatti);
            this.Controls.Add(this.CercaPiatto);
            this.Controls.Add(this.ModificaPiatto);
            this.Controls.Add(this.AggiungiPiatto);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Proprietario";
            this.Text = "AccountProprietario";
            this.Load += new System.EventHandler(this.Proprietario_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AggiungiPiatto;
        private System.Windows.Forms.Button ModificaPiatto;
        private System.Windows.Forms.Button CercaPiatto;
        private System.Windows.Forms.Button VisualizzaPiatti;
        private System.Windows.Forms.Button EliminaPiatto;
        private System.Windows.Forms.Button IndietroPiatto;
        private System.Windows.Forms.Label label1;
    }
}