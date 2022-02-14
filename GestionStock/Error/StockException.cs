using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Error
{
   public class ProductAlreadyExistException : ApplicationException
   {
       public ProductAlreadyExistException(String message)
           : base(message)
       {
       }
   }
   public class ProductDoesntExistException : ApplicationException
   {
       public ProductDoesntExistException(String message)
           : base(message)
       {
       }
   }
}