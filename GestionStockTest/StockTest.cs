using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionStock.Object;
using System.Collections.Generic;
using GestionStock.Error;

namespace GestionStockTest
{
    [TestClass]
    public class StockTest
    {
       [TestMethod]
        public void Stock_construct_NoParam_ListProduit()
        {
            Stock s = Stock.GetInstance();

            List<Product> actual = s.ListProduct;
            Assert.AreNotEqual(null, actual);
        }

        [TestMethod]
        public void Stock_AddProduct_CheckProduct(){
            Stock s = Stock.GetInstance();

            string nom = "VinoBlanco";
            int quantite = 500;

            Product p = new Product(nom, quantite);
            s.addProduct(p);
            Assert.AreEqual(p, s.ListProduct[0]);
        }
        
        [TestMethod]
        public void Stock_AddProduct(){
            Stock s = Stock.GetInstance();

            
            for (int i = 0; i < 10; i++)
            {
                string nom = "Beer" + i.ToString();
                int quantite = 500;

                Product p = new Product(nom, quantite);
                s.addProduct(p);
            }

            int expected = 11;
            Assert.AreEqual(expected, s.ListProduct.Count);
        }

        [TestMethod]
        public void Stock_AddProduct_AlreadyExist(){
            Stock s = Stock.GetInstance();

            string nom = "Vodka";
            int quantite = 500;

            Product p = new Product(nom, quantite);
            s.addProduct(p);
            quantite = 300;
            Product p2 = new Product(nom, quantite);

            Assert.ThrowsException<ProductAlreadyExistException>(() => s.addProduct(p2));
        }
        
        [TestMethod]
        public void Stock_RemoveProduct(){
            Stock s = Stock.GetInstance();

            
            for (int i = 0; i < 10; i++)
            {
                string nom = "Beer" + i.ToString();
                int quantite = 500;

                Product p = new Product(nom, quantite);
                s.removeProduct(p);
            }

            int expected = 12;
            Assert.AreEqual(expected, s.ListProduct.Count);
        }

        [TestMethod]
        public void Stock_RemoveProduct_DoesntExist(){
            Stock s = Stock.GetInstance();

            string nom = "Gin";
            int quantite = 500;

            Product p = new Product(nom, quantite);

            Assert.ThrowsException<ProductDoesntExistException>(() => s.removeProduct(p));
        }


        [TestMethod]
        public void Stock_GetProduct(){
            Stock s = Stock.GetInstance();

            string nom = "Kebab";
            int quantite = 10;

            Product p = new Product(nom, quantite);
            s.addProduct(p);

            var produit = s.GetProduct("Kebab");
            
            Assert.AreEqual(p, produit);
        }
    }
}
