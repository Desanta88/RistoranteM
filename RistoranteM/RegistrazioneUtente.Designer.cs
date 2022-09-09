
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scegliere una password con al massimo 12 caratteri:";
            // 
            // TextBoxRegC
            // 
            this.TextBoxRegC.Location = new System.Drawing.Point(305, 152);
            this.TextBoxRegC.Name = "TextBoxRegC";
            this.TextBoxRegC.Size = new System.Drawing.Size(196, 20);
            this.TextBoxRegC.TabIndex = 3;
            // 
            // RegPassC
            // 
            this.RegPassC.Location = new System.Drawing.Point(362, 199);
            this.RegPassC.Name = "RegPassC";
            this.RegPassC.Size = new System.Drawing.Size(83, 29);
            this.RegPassC.TabIndex = 4;
            this.RegPassC.Text = "OK";
            this.RegPassC.UseVisualStyleBackColor = true;
            this.RegPassC.Click += new System.EventHandler(this.RegPassC_Click);
            // 
            // IndietroC
            // 
            this.IndietroC.Location = new System.Drawing.Point(41, 400);
            this.IndietroC.Name = "IndietroC";
            this.IndietroC.Size = new System.Drawing.Size(101, 29);
            this.IndietroC.TabIndex = 5;
            this.IndietroC.Text = "< Indietro";
            this.IndietroC.UseVisualStyleBackColor = true;
            this.IndietroC.Click += new System.EventHandler(this.IndietroC_Click);
            // 
            // RegCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IndietroC);
            this.Controls.Add(this.RegPassC);
            this.Controls.Add(this.TextBoxRegC);
            this.Controls.Add(this.label1);
            this.Name = "RegCliente";
            this.Text = "RegistrazioneCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxRegC;
        private System.Windows.Forms.Button RegPassC;
        private System.Windows.Forms.Button IndietroC;
    }
}