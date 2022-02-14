using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Error
{
   public class StockException : ApplicationException
   {
       public StockException(String message)
           : base(message)
       {
       }
   }

   public class NegativeQuantiteException : ApplicationException
   {
       public NegativeQuantiteException(String message)
           : base(message)
       {
       }
   }

    public class NegativeNumberException : ApplicationException
   {
       public NegativeNumberException(String message)
           : base(message)
       {
       }
   }
}