using System; 
using GestionStock.Utils;


namespace GestionStock.Object
{
    public class  Product {

        public string nom {get; set;}
        public int quantite {get; set;}

        public Product(){

            this.nom = "Jeux Vidéo";
            this.quantite = 10;
        }


        public Product(string nom){

            this.nom = nom;
            this.quantite = 10;
        }
        public Product(int quantite){

            this.nom = "Jeux Vidéo";
            this.quantite = quantite;
        }

        public Product(string nom, int quantite){

            this.nom = nom;
            this.quantite = quantite;
        }


        public int AddQuantite(int value){
                ValueUtils.checkValue(value);
                this.quantite += value;
                return this.quantite;
        }

        public int RemoveQuantite(int value){
                QuantiteUtils.checkQuantite(this.quantite,value);
                this.quantite -= value;
                return this.quantite;
        }
    }
}