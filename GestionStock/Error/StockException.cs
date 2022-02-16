using System;

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