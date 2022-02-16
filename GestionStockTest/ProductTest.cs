using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionStock.Object;
using GestionStock.Error;

namespace GestionStockTest
{
    [TestClass]
    public class UnitTest1
    {
       [TestMethod]
        public void Product_construct_NoParam_Nom()
        {
            Product p = new Product();

            string expected = "Jeux Vidéo";
            string actual = p.nom;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Product_construct_NoParam_Quantite()
        {
            Product p = new Product();

            int expected = 11;
            int actual = p.quantite;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Product_construct_Voiture_Nom()
        {
            string expected = "Voiture";

            Product p = new Product(expected);
            
            string actual = p.nom;

            Assert.AreEqual(expected, actual);

        }

         [TestMethod]
        public void Product_construct_200_Quantite()
        {
            int  expected = 200;

            Product p = new Product(expected);
            
            int actual = p.quantite;

            Assert.AreEqual(expected, actual);

        }

         [TestMethod]
        public void Product_construct_500AndBeer_Nom()
        {
            string nom = "Beer";
            int quantite = 500;

            Product p = new Product(nom, quantite);
            
            string actual = p.nom;

            Assert.AreEqual(nom, actual);

        }

         [TestMethod]
        public void Product_construct_500AndBeer_Quantite()
        {
            string nom = "Beer";
            int quantite = 500;

            Product p = new Product(nom, quantite);
            
            int actual = p.quantite;

            Assert.AreEqual(quantite, actual);

        }

         [TestMethod]
        public void Product_AddQuantite_10()
        {
            string nom = "Beer";
            int quantite = 500;

            Product p = new Product(nom, quantite);
            

            int actual = p.AddQuantite(10);

            int expected = 510;

            Assert.AreEqual(expected, actual);

        }

           [TestMethod]
        public void Product_AddQuantite_Negative10()
        {
            string nom = "Beer";
            int quantite = 500;

            Product p = new Product(nom, quantite);

            Assert.ThrowsException<NegativeNumberException>(() => p.AddQuantite(-10));

        }

         [TestMethod]
        public void Product_RemoveQuantite_10()
        {
            string nom = "Beer";
            int quantite = 500;

            Product p = new Product(nom, quantite);

            int actual = p.RemoveQuantite(10);
            int expected = 490; 

            Assert.AreEqual(expected, p.quantite);

        }

        [TestMethod]
        public void Product_RemoveQuantite_Negative10()
        {
            string nom = "Beer";
            int quantite = 500;

            Product p = new Product(nom, quantite);

            Assert.ThrowsException<NegativeNumberException>(() => p.AddQuantite(-10));
        }


        [TestMethod]
        public void Product_RemoveQuantite_MoreThanQuantite()
        {
            string nom = "Beer";
            int quantite = 500;

            Product p = new Product(nom, quantite);

            Assert.ThrowsException<NegativeQuantiteException>(() => p.RemoveQuantite(600));
        }
    }
}
