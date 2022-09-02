
namespace RistoranteM
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PassP = new System.Windows.Forms.TextBox();
            this.Prop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PassC = new System.Windows.Forms.TextBox();
            this.RegistrazioneProprietario = new System.Windows.Forms.LinkLabel();
            this.RegistrazioneCliente = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Cliente
            // 
            this.Cliente.Location = new System.Drawing.Point(522, 282);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(106, 26);
            this.Cliente.TabIndex = 1;
            this.Cliente.Text = "Accedi";
            this.Cliente.UseVisualStyleBackColor = true;
            this.Cliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            // 
            // PassP
            // 
            this.PassP.Location = new System.Drawing.Point(168, 236);
            this.PassP.Name = "PassP";
            this.PassP.Size = new System.Drawing.Size(106, 20);
            this.PassP.TabIndex = 3;
            // 
            // Prop
            // 
            this.Prop.Location = new System.Drawing.Point(168, 282);
            this.Prop.Name = "Prop";
            this.Prop.Size = new System.Drawing.Size(106, 26);
            this.Prop.TabIndex = 4;
            this.Prop.Text = "Accedi";
            this.Prop.UseVisualStyleBackColor = true;
            this.Prop.Click += new System.EventHandler(this.Prop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ACCOUNT PROPRIETARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inserire la password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ACCOUNT CLIENTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Inserire la password";
            // 
            // PassC
            // 
            this.PassC.Location = new System.Drawing.Point(522, 236);
            this.PassC.Name = "PassC";
            this.PassC.Size = new System.Drawing.Size(106, 20);
            this.PassC.TabIndex = 9;
            // 
            // RegistrazioneProprietario
            // 
            this.RegistrazioneProprietario.AutoSize = true;
            this.RegistrazioneProprietario.Location = new System.Drawing.Point(70, 323);
            this.RegistrazioneProprietario.Name = "RegistrazioneProprietario";
            this.RegistrazioneProprietario.Size = new System.Drawing.Size(299, 13);
            this.RegistrazioneProprietario.TabIndex = 10;
            this.RegistrazioneProprietario.TabStop = true;
            this.RegistrazioneProprietario.Text = "Se ti sei scordato la password o ti devi registrare,clicca sul link";
            this.RegistrazioneProprietario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistrazioneProprietario_LinkClicked);
            // 
            // RegistrazioneCliente
            // 
            this.RegistrazioneCliente.AutoSize = true;
            this.RegistrazioneCliente.Location = new System.Drawing.Point(427, 323);
            this.RegistrazioneCliente.Name = "RegistrazioneCliente";
            this.RegistrazioneCliente.Size = new System.Drawing.Size(299, 13);
            this.RegistrazioneCliente.TabIndex = 11;
            this.RegistrazioneCliente.TabStop = true;
            this.RegistrazioneCliente.Text = "Se ti sei scordato la password o ti devi registrare,clicca sul link";
            this.RegistrazioneCliente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistrazioneCliente_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistrazioneCliente);
            this.Controls.Add(this.RegistrazioneProprietario);
            this.Controls.Add(this.PassC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prop);
            this.Controls.Add(this.PassP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cliente);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassP;
        private System.Windows.Forms.Button Prop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PassC;
        private System.Windows.Forms.LinkLabel RegistrazioneProprietario;
        private System.Windows.Forms.LinkLabel RegistrazioneCliente;
    }
}

