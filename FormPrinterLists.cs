using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spooler_Universal
{
    public partial class FormPrinterList : Form
    {
        public FormPrinterList()
        {
            InitializeComponent();
        }

        // Constructeur qui reçoit une liste d'imprimantes
        public FormPrinterList(List<string> printers)
        {
            InitializeComponent();
            foreach (var printer in printers)
            {
                listBoxPrinters.Items.Add(printer); // Ajoute chaque imprimante à la ListBox
            }
        }
        public string SelectedPrinter { get; private set; }

        private void btnSelectPrinter_Click(object sender, EventArgs e)
        {
            if (listBoxPrinters.SelectedItem != null)
            {
                SelectedPrinter = listBoxPrinters.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une imprimante.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
