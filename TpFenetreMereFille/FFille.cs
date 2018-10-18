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
    public partial class FFille : Form
    {
        private string monNom;
        private FMere maMere;

        public FFille(FMere maMere,int numero)
        {
            InitializeComponent();
            this.Text = "Fille n°" + numero;
            this.monNom = this.Text;
            this.maMere = maMere;
            btnMere.Click += new EventHandler (btnMere_Click);
            this.FormClosing += new FormClosingEventHandler(FFille_FormClosing);
            this.Load += new EventHandler(FFille_Load);
            btnChanger.Click += new EventHandler(btnChanger_Click);
            tbNom.TextChanged += new EventHandler(tbNom_TextChanged);
        }

        private void btnMere_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maMere.GetNomMere);
        }

        void FFille_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

        void FFille_Load(object sender, EventArgs e) {
            MessageBox.Show("Evenement Load sur"+ this.monNom);
        }

        void btnChanger_Click(object sender, EventArgs e) {
            monNom = tbNom.Text;
            this.Text = monNom;
            maMere.MaFilleChangeDeNom(this, monNom);
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            monNom = tbNom.Text;
            this.Text = monNom;
            maMere.MaFilleChangeDeNom(this, monNom);
        }
       
    }
}
