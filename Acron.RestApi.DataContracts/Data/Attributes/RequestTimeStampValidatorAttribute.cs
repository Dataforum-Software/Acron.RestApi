using System.ComponentModel.DataAnnotations;
using System;

namespace Acron.RestApi.DataContracts.Data.Attributes
{
   sealed public class RequestTimeStampValidatorAttribute : ValidationAttribute
   {
      public RequestTimeStampValidatorAttribute()
      { }

      static private DateTime _minTime = new DateTime(1970, 01, 10, 12, 00, 0);

      public override bool IsValid(object value)
      {
         if (value is DateTime)
         {
            DateTime dtm = (DateTime)value;
            if (dtm < _minTime)
               return false;

         }
         else if (value is DateTimeOffset)
         {
            DateTimeOffset dtm = (DateTimeOffset)value;
            if (dtm < _minTime)
               return false;
         }

         return true;
      }

   }

}