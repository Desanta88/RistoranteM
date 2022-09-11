
namespace RistoranteM
{
    partial class FormP
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
            this.RegPassP = new System.Windows.Forms.Button();
            this.IndietroP = new System.Windows.Forms.Button();
            this.TextBoxRegP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scegliere una password con al massimo 12 caratteri:";
            // 
            // RegPassP
            // 
            this.RegPassP.Location = new System.Drawing.Point(257, 193);
            this.RegPassP.Name = "RegPassP";
            this.RegPassP.Size = new System.Drawing.Size(83, 29);
            this.RegPassP.TabIndex = 2;
            this.RegPassP.Text = "OK";
            this.RegPassP.UseVisualStyleBackColor = true;
            this.RegPassP.Click += new System.EventHandler(this.RegPassP_Click);
            // 
            // IndietroP
            // 
            this.IndietroP.Location = new System.Drawing.Point(12, 324);
            this.IndietroP.Name = "IndietroP";
            this.IndietroP.Size = new System.Drawing.Size(101, 29);
            this.IndietroP.TabIndex = 3;
            this.IndietroP.Text = "< Indietro";
            this.IndietroP.UseVisualStyleBackColor = true;
            this.IndietroP.Click += new System.EventHandler(this.IndietroP_Click);
            // 
            // TextBoxRegP
            // 
            this.TextBoxRegP.Location = new System.Drawing.Point(198, 152);
            this.TextBoxRegP.Name = "TextBoxRegP";
            this.TextBoxRegP.Size = new System.Drawing.Size(196, 20);
            this.TextBoxRegP.TabIndex = 4;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 44);
            this.panel1.TabIndex = 6;
            // 
            // FormP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxRegP);
            this.Controls.Add(this.IndietroP);
            this.Controls.Add(this.RegPassP);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(605, 404);
            this.MinimumSize = new System.Drawing.Size(605, 404);
            this.Name = "FormP";
            this.Text = "RegProprietario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegPassP;
        private System.Windows.Forms.Button IndietroP;
        private System.Windows.Forms.TextBox TextBoxRegP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}