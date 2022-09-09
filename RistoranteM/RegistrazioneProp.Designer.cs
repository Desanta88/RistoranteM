
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scegliere una password con al massimo 12 caratteri:";
            // 
            // RegPassP
            // 
            this.RegPassP.Location = new System.Drawing.Point(362, 199);
            this.RegPassP.Name = "RegPassP";
            this.RegPassP.Size = new System.Drawing.Size(83, 29);
            this.RegPassP.TabIndex = 2;
            this.RegPassP.Text = "OK";
            this.RegPassP.UseVisualStyleBackColor = true;
            this.RegPassP.Click += new System.EventHandler(this.RegPassP_Click);
            // 
            // IndietroP
            // 
            this.IndietroP.Location = new System.Drawing.Point(41, 400);
            this.IndietroP.Name = "IndietroP";
            this.IndietroP.Size = new System.Drawing.Size(101, 29);
            this.IndietroP.TabIndex = 3;
            this.IndietroP.Text = "< Indietro";
            this.IndietroP.UseVisualStyleBackColor = true;
            this.IndietroP.Click += new System.EventHandler(this.IndietroP_Click);
            // 
            // TextBoxRegP
            // 
            this.TextBoxRegP.Location = new System.Drawing.Point(305, 152);
            this.TextBoxRegP.Name = "TextBoxRegP";
            this.TextBoxRegP.Size = new System.Drawing.Size(196, 20);
            this.TextBoxRegP.TabIndex = 4;
            // 
            // FormP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxRegP);
            this.Controls.Add(this.IndietroP);
            this.Controls.Add(this.RegPassP);
            this.Controls.Add(this.label1);
            this.Name = "FormP";
            this.Text = "RegProprietario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegPassP;
        private System.Windows.Forms.Button IndietroP;
        private System.Windows.Forms.TextBox TextBoxRegP;
    }
}