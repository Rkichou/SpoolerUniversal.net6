using System.Windows.Forms;

namespace Spooler_Universal
{
    partial class FormPrinterList
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxPrinters;
        private System.Windows.Forms.Label label1;
        private Button btnSelectPrinter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxPrinters = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPrinter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPrinters
            // 
            this.listBoxPrinters.FormattingEnabled = true;
            this.listBoxPrinters.ItemHeight = 16;
            this.listBoxPrinters.Location = new System.Drawing.Point(12, 34);
            this.listBoxPrinters.Name = "listBoxPrinters";
            this.listBoxPrinters.Size = new System.Drawing.Size(964, 180);
            this.listBoxPrinters.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imprimantes détectées :";
            // 
            // btnSelectPrinter
            // 
            this.btnSelectPrinter.Location = new System.Drawing.Point(901, 220);
            this.btnSelectPrinter.Name = "btnSelectPrinter";
            this.btnSelectPrinter.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPrinter.TabIndex = 2;
            this.btnSelectPrinter.Text = "Sélectionner";
            this.btnSelectPrinter.UseVisualStyleBackColor = true;
            this.btnSelectPrinter.Click += new System.EventHandler(this.btnSelectPrinter_Click);
            // 
            // FormPrinterList
            // 
            this.ClientSize = new System.Drawing.Size(1023, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPrinters);
            this.Controls.Add(this.btnSelectPrinter);
            this.Name = "FormPrinterList";
            this.Text = "Liste des Imprimantes USB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}