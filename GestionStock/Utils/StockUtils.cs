using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.Error;
using GestionStock.Object;


namespace GestionStock.Utils
{
    class StockUtils
    {
        public static void checkStock(List<Product> ListProduct, Product produit)
        {
            var ExistingProduct = ListProduct.FirstOrDefault(x => x.nom == produit.nom);

            if(ExistingProduct != null){
                throw new ProductAlreadyExistException("Product already exist : "+ ExistingProduct.nom );
            }
        }

        public static void checkStockDosentExist(List<Product> ListProduct, Product produit)
        {
            var ExistingProduct = ListProduct.FirstOrDefault(x => x.nom == produit.nom);

            if(ExistingProduct == null){
                throw new ProductDoesntExistException("Product doesn't exist : "+ produit.nom );
            }
        }


        public static void checkStockByName(List<Product> ListProduct, string nom)
        {
            var ExistingProduct = ListProduct.FirstOrDefault(x => x.nom == nom);

            if(ExistingProduct == null){
                throw new ProductDoesntExistException("Product doesn't exist : "+ nom );
            }
        }
    } 
}