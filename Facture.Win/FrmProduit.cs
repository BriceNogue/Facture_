using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facture.BO;
using Facture.BLL;

namespace Facture.Win
{
    public partial class Products : Form
    {
        ProductManager products = new ProductManager();
        Product product;
        public Products()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            product = new Product(txtbNom.Text, txtbReference.Text, double.Parse(txtbPrixU.Text), double.Parse(tctbQuantite.Text));
            if (product != null)
            {
                products.ADDPROD(product);
                MessageBox.Show("TERMINE !");
            }
            else
            {
                MessageBox.Show("Erreur !");
            }
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            var form1 = new FormPreview();
            form1.Show();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtbNom.Clear();
            txtbReference.Clear();
            txtbReference.Clear();
            txtbPrixU.Clear();
        }
    }
}
