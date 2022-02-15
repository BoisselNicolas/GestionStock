using System;
using System.Collections.Generic;
using GestionStock.Object;
using GestionStock.Error; 


namespace GestionStock
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false; 

            Stock myStock = Stock.GetInstance();

                Console.Clear();
           
         
            while(!end){
                Console.Clear();
                LoadAction();
                string response = Console.ReadLine().ToString();

                switch(response) {
                    
                    case "1" : 
                        loadStock(myStock.ListProduct);
                        break;
                    case "2" : 
                        AddProduct(myStock);
                        loadStock(myStock.ListProduct);
                        break;
                    case "3" : 
                        UpdateProduct(myStock);
                        loadStock(myStock.ListProduct);

                        break;
                    case "4" : 
                        DeleteProduct(myStock);
                        loadStock(myStock.ListProduct);
                        break;
                }

                Console.WriteLine("Continue ? : Yes | exit");
                response = Console.ReadLine();
                if(response == "exit"){
                    end = true;
                } 
            }
        }

        public static void LoadAction(){
            Console.WriteLine("Please select an option ");
            Console.WriteLine("1. Voir mon stock");
            Console.WriteLine("2. Ajouter un produit");
            Console.WriteLine("3. Modifier un produit");
            Console.WriteLine("4. Supprimer un produit");
        }
        private static void loadStock(List<Product> myStock){

            if (myStock.Count > 0)
            {
                foreach (var item in myStock)
                {
                    Console.WriteLine(item.nom + " | " + item.quantite);
                }
            }else{
                Console.WriteLine("Aucun produit dans le stock");
            }

            

        }
        private static void AddProduct(Stock myStock){

            try
            {
                Console.WriteLine("Saisissez un nom de produit : ");
                string nom = Console.ReadLine();
                Console.WriteLine("Saisissez la quantite de votre produit: ");
                int quantite = Convert.ToInt32(Console.ReadLine());
                Product produit = new Product(nom, quantite);

                myStock.addProduct(produit);
            }
            catch (ProductAlreadyExistException)
            {
                Console.WriteLine("Le produit exite déjà ");
            }
        }

        private static void UpdateProduct(Stock myStock){

            loadStock(myStock.ListProduct);
            if(myStock.ListProduct.Count > 0){
                Console.WriteLine("Saisissez un nom de produit : ");
                string nom = Console.ReadLine();

                Product produit = myStock.GetProduct(nom);

                Console.WriteLine(produit.nom + " | " + produit.quantite);
                

                Console.WriteLine("Please select an option ");
                Console.WriteLine("1. Ajouter quantite");
                Console.WriteLine("2. Supprimer quantite");

                string response = Console.ReadLine();
                
                switch(response){
                    case "1" :
                            try
                            {
                            Console.WriteLine("Saisissez la quantite : ");
                            int quantiteToAdd = Convert.ToInt32(Console.ReadLine());
                            produit.AddQuantite(quantiteToAdd);
                            }
                            catch (NegativeNumberException)
                            {
                                Console.WriteLine("Impossible d'ajouter un nombre négatif");
                            }
                        break;
                    case "2" : 
                        try
                        {
                            Console.WriteLine("Saisissez la quantite : ");
                            int QuantiteToRemove = Convert.ToInt32(Console.ReadLine());
                            produit.RemoveQuantite(QuantiteToRemove);
                        }
                        catch (NegativeQuantiteException)
                        {
                            Console.WriteLine("Impossible d'enlever plus que la quantite existante");
                        }
                        break;
                }
            }else{
                Console.WriteLine("Aucun produit dans le stock");
            }
        }

        private static void DeleteProduct(Stock myStock){
            try{
                loadStock(myStock.ListProduct);
                if(myStock.ListProduct.Count > 0){
                    Console.WriteLine("Saisissez le nom du produit à supprimer");
                    string response = Console.ReadLine();
                    Product produit = myStock.GetProduct(response);
                    myStock.removeProduct(produit);
                    Console.WriteLine("Produit supprimé");
                }
            }
            catch (ProductDoesntExistException e)
            {
                Console.WriteLine("Le produit que vous voulez supprimé n'existe pas ");
            }

        }
    }
}
