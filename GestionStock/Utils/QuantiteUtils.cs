using GestionStock.Error;

namespace GestionStock.Utils
{
    class QuantiteUtils
    {
        public static void checkQuantite(int quantite,int value)
        {
            if(value > quantite){
                throw new NegativeQuantiteException("Quantite will be negative: Value - "+ value +", Quantite - " + quantite);
            }
        }

        public static void checkUpdateQuantite(int quantite)
        {
            if(quantite < 0){
                throw new NegativeQuantiteException("Quantite will be negative: Value - " );
            }
           
        }
    } 
}