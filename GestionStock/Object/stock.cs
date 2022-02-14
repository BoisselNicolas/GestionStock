using System; 
using System.Linq;
using System.Collections.Generic;
using GestionStock.Utils;
using GestionStock.Error;

namespace GestionStock.Object
{
    public class Stock {

        public List<Product> ListProduct {get; set;}

        private static Stock _instance;
        private Stock () { 
            this.ListProduct = new List<Product>();
        }


        public static Stock GetInstance(){
            if(_instance == null ){
                _instance = new Stock();
            }
            return _instance;
        }
        public string addProduct(Product produit){
            StockUtils.checkStock(this.ListProduct, produit);
            this.ListProduct.Add(produit);
            return "Product add in stock ";
        }

        public string removeProduct(Product produit){
            StockUtils.checkStockDosentExist(this.ListProduct, produit);
            this.ListProduct.Remove(produit);
            return "Product remove in stock ";
        }

        public Product GetProduct(String nom){
            StockUtils.checkStockByName(this.ListProduct, nom);
            var ProductToUpdate = this.ListProduct.FirstOrDefault(x => x.nom == nom);
            return ProductToUpdate;
        }


        

    }
}