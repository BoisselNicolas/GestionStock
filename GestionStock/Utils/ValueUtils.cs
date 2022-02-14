using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.Error;



namespace GestionStock.Utils
{
    class ValueUtils
    {
        public static void checkValue(int value)
        {
            if(value < 0){
                throw new NegativeNumberException("Negative number : "+ value );
            }
           
        }
    } 
}