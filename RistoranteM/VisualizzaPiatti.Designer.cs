
namespace RistoranteM
{
    partial class VisualizzaPiatti
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
            this.tabAntipasti = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxAntipasti = new System.Windows.Forms.ListBox();
            this.tabPrimi = new System.Windows.Forms.TabPage();
            this.listBoxPrimi = new System.Windows.Forms.ListBox();
            this.tabSecondi = new System.Windows.Forms.TabPage();
            this.listBoxSecondi = new System.Windows.Forms.ListBox();
            this.tabDessert = new System.Windows.Forms.TabPage();
            this.listBoxDessert = new System.Windows.Forms.ListBox();
            this.IndietroVP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabAntipasti.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPrimi.SuspendLayout();
            this.tabSecondi.SuspendLayout();
            this.tabDessert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAntipasti
            // 
            this.tabAntipasti.Controls.Add(this.tabPage1);
            this.tabAntipasti.Controls.Add(this.tabPrimi);
            this.tabAntipasti.Controls.Add(this.tabSecondi);
            this.tabAntipasti.Controls.Add(this.tabDessert);
            this.tabAntipasti.Location = new System.Drawing.Point(39, 102);
            this.tabAntipasti.Name = "tabAntipasti";
            this.tabAntipasti.SelectedIndex = 0;
            this.tabAntipasti.Size = new System.Drawing.Size(197, 281);
            this.tabAntipasti.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxAntipasti);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(189, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Antipasti";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxAntipasti
            // 
            this.listBoxAntipasti.FormattingEnabled = true;
            this.listBoxAntipasti.Location = new System.Drawing.Point(6, 6);
            this.listBoxAntipasti.Name = "listBoxAntipasti";
            this.listBoxAntipasti.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxAntipasti.Size = new System.Drawing.Size(177, 238);
            this.listBoxAntipasti.TabIndex = 2;
            // 
            // tabPrimi
            // 
            this.tabPrimi.Controls.Add(this.listBoxPrimi);
            this.tabPrimi.Location = new System.Drawing.Point(4, 22);
            this.tabPrimi.Name = "tabPrimi";
            this.tabPrimi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrimi.Size = new System.Drawing.Size(189, 255);
            this.tabPrimi.TabIndex = 1;
            this.tabPrimi.Text = "Primi";
            this.tabPrimi.UseVisualStyleBackColor = true;
            // 
            // listBoxPrimi
            // 
            this.listBoxPrimi.FormattingEnabled = true;
            this.listBoxPrimi.Location = new System.Drawing.Point(6, 6);
            this.listBoxPrimi.Name = "listBoxPrimi";
            this.listBoxPrimi.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxPrimi.Size = new System.Drawing.Size(177, 238);
            this.listBoxPrimi.TabIndex = 0;
            // 
            // tabSecondi
            // 
            this.tabSecondi.Controls.Add(this.listBoxSecondi);
            this.tabSecondi.Location = new System.Drawing.Point(4, 22);
            this.tabSecondi.Name = "tabSecondi";
            this.tabSecondi.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecondi.Size = new System.Drawing.Size(189, 255);
            this.tabSecondi.TabIndex = 2;
            this.tabSecondi.Text = "Secondi";
            this.tabSecondi.UseVisualStyleBackColor = true;
            // 
            // listBoxSecondi
            // 
            this.listBoxSecondi.FormattingEnabled = true;
            this.listBoxSecondi.Location = new System.Drawing.Point(6, 6);
            this.listBoxSecondi.Name = "listBoxSecondi";
            this.listBoxSecondi.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxSecondi.Size = new System.Drawing.Size(177, 238);
            this.listBoxSecondi.TabIndex = 0;
            // 
            // tabDessert
            // 
            this.tabDessert.Controls.Add(this.listBoxDessert);
            this.tabDessert.Location = new System.Drawing.Point(4, 22);
            this.tabDessert.Name = "tabDessert";
            this.tabDessert.Padding = new System.Windows.Forms.Padding(3);
            this.tabDessert.Size = new System.Drawing.Size(189, 255);
            this.tabDessert.TabIndex = 3;
            this.tabDessert.Text = "Dessert";
            this.tabDessert.UseVisualStyleBackColor = true;
            // 
            // listBoxDessert
            // 
            this.listBoxDessert.FormattingEnabled = true;
            this.listBoxDessert.Location = new System.Drawing.Point(6, 6);
            this.listBoxDessert.Name = "listBoxDessert";
            this.listBoxDessert.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxDessert.Size = new System.Drawing.Size(177, 238);
            this.listBoxDessert.TabIndex = 0;
            this.listBoxDessert.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // IndietroVP
            // 
            this.IndietroVP.Location = new System.Drawing.Point(12, 415);
            this.IndietroVP.Name = "IndietroVP";
            this.IndietroVP.Size = new System.Drawing.Size(75, 23);
            this.IndietroVP.TabIndex = 1;
            this.IndietroVP.Text = "< Indietro";
            this.IndietroVP.UseVisualStyleBackColor = true;
            this.IndietroVP.Click += new System.EventHandler(this.IndietroVP_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 49);
            this.panel1.TabIndex = 2;
            // 
            // VisualizzaPiatti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IndietroVP);
            this.Controls.Add(this.tabAntipasti);
            this.Name = "VisualizzaPiatti";
            this.Text = "VisualizzaPiatti";
            this.Load += new System.EventHandler(this.VisualizzaPiatti_Load);
            this.tabAntipasti.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPrimi.ResumeLayout(false);
            this.tabSecondi.ResumeLayout(false);
            this.tabDessert.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAntipasti;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPrimi;
        private System.Windows.Forms.TabPage tabSecondi;
        private System.Windows.Forms.TabPage tabDessert;
        private System.Windows.Forms.ListBox listBoxAntipasti;
        private System.Windows.Forms.ListBox listBoxPrimi;
        private System.Windows.Forms.ListBox listBoxSecondi;
        private System.Windows.Forms.ListBox listBoxDessert;
        private System.Windows.Forms.Button IndietroVP;
        private System.Windows.Forms.Panel panel1;
    }
}