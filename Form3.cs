using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace Spooler_Universal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        //Initialiser le formulaire "A propos"
        public Form3(Form1 f)
        {
            InitializeComponent();

            this.Text = f.traduction[f.langue]["sous_menu_propos"];
            label3.Text = f.traduction[f.langue]["form3_marque"];
        }


        //Fonction qui s'exécute quand le lien "www.eticeuropedev.com" est cliqué
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo("http://www.eticeuropedev.com");
            System.Diagnostics.Process.Start(sInfo);
        }



    }
}
