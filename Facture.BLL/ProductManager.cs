using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facture.BO;
using Facture.DAL;

namespace Facture.BLL
{
    public class ProductManager
    {
        ProductRepository ProductRepository = new ProductRepository();
        public void ADDPROD(Product product)
        {
            ProductRepository.Add(product);
        }
        public void EDDITPROD(Product product,Product newproduct)
        {
            ProductRepository.Set(product, newproduct);
        }
        public List<Product> GetProducts()
        {
            return ProductRepository.GetAll();
        }

    }
}
