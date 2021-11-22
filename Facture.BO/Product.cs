using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.BO
{
    public class Product
    {
        public Product(string nom, string reference, double prixU,double quantite)
        {
            Nom = nom;
            Reference = reference;
            Quantite = quantite;
            PrixU = prixU;

            TotalPrice = prixU * quantite;
           
        }

        public string Nom { get; set; }
        public string Reference { get; set; }
        public double PrixU { get; set; }
        public double TotalPrice { get; set; }
        public double Quantite { get; set; }

       
        public Product()
        {

        }
        public Product(Product product) : this(product?.Nom, product?.Reference, product?.PrixU ?? 0, product?.Quantite ?? 0)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Reference == product.Reference;
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Reference);
        }
    }
}
