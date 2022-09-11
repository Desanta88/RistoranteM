
namespace RistoranteM
{
    partial class RegCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxRegC = new System.Windows.Forms.TextBox();
            this.RegPassC = new System.Windows.Forms.Button();
            this.IndietroC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scegliere una password con al massimo 12 caratteri:";
            // 
            // TextBoxRegC
            // 
            this.TextBoxRegC.Location = new System.Drawing.Point(199, 145);
            this.TextBoxRegC.Name = "TextBoxRegC";
            this.TextBoxRegC.Size = new System.Drawing.Size(196, 20);
            this.TextBoxRegC.TabIndex = 3;
            // 
            // RegPassC
            // 
            this.RegPassC.Location = new System.Drawing.Point(255, 185);
            this.RegPassC.Name = "RegPassC";
            this.RegPassC.Size = new System.Drawing.Size(83, 29);
            this.RegPassC.TabIndex = 4;
            this.RegPassC.Text = "OK";
            this.RegPassC.UseVisualStyleBackColor = true;
            this.RegPassC.Click += new System.EventHandler(this.RegPassC_Click);
            // 
            // IndietroC
            // 
            this.IndietroC.Location = new System.Drawing.Point(12, 316);
            this.IndietroC.Name = "IndietroC";
            this.IndietroC.Size = new System.Drawing.Size(82, 37);
            this.IndietroC.TabIndex = 5;
            this.IndietroC.Text = "< Indietro";
            this.IndietroC.UseVisualStyleBackColor = true;
            this.IndietroC.Click += new System.EventHandler(this.IndietroC_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 44);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "REGISTRAZIONE";
            // 
            // RegCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IndietroC);
            this.Controls.Add(this.RegPassC);
            this.Controls.Add(this.TextBoxRegC);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(605, 404);
            this.MinimumSize = new System.Drawing.Size(605, 404);
            this.Name = "RegCliente";
            this.Text = "RegistrazioneCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxRegC;
        private System.Windows.Forms.Button RegPassC;
        private System.Windows.Forms.Button IndietroC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}