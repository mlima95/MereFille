using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TpFenetreMereFille
{
    public partial class FMere : Form
    {
        private List<FFille> lesFilles;
        private int nombreFille;
        private string nomMere;

        public FMere()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.nomMere = "Maman";
            lesFilles = new List<FFille>();
            btnNew.Click += new EventHandler(btnNew_Click);
            btnShow.Click += new EventHandler(btnShow_Click);
            btnHide.Click += new EventHandler(btnHide_Click);
            btnClose.Click += new EventHandler(btnClose_Click);
            btnShowDialog.Click += new EventHandler(btnShowDialog_Click);
            btnNew.Click += new EventHandler(btnNew_Click_Message);
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            FFille nouvelleFille;
            nombreFille = nombreFille + 1;
            nouvelleFille = new FFille(this, nombreFille);
            lesFilles.Add(nouvelleFille);
            lbLesFilles.Items.Add("Fille n°" + this.nombreFille);
        }

        public string GetNomMere
        {
            get
            {
                return this.nomMere;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int position = lbLesFilles.SelectedIndex;
            if (position != -1) {
                lesFilles[position].Show();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            int position = this.lbLesFilles.SelectedIndex;
            if (position != -1) {
                this.lesFilles[position].Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int position = this.lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                this.lesFilles[position].Close();
                lesFilles.RemoveAt(position);
                lbLesFilles.Items.RemoveAt(position);
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            int position = this.lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                this.lesFilles[position].ShowDialog();
            }
        }

        private void btnNew_Click_Message(object sender,EventArgs e)
        {
            MessageBox.Show("Une fenêtre fille a été instanciée");
        }

        public void MaFilleChangeDeNom(FFille ffille,string nouveauNom)
        {
            int position = lesFilles.IndexOf(ffille);
            if (position != -1)
            {
                lesFilles[position]=ffille;
                lbLesFilles.Items[position]=nouveauNom;
            }
        }
    }
}
