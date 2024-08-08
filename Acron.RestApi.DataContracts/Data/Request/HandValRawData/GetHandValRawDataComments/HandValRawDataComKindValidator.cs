using Acron.RestApi.Interfaces.Data.Request.HandValRawData.GetHandValRawDataComments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.GetHandValRawDataComments
{
   sealed public class HandValRawDataComKindValidator : ValidationAttribute
   {
      public override bool IsValid(object value)
      {
         switch ((short)((AVComKinds_HandVal)value))
         {
            case 6:
            case 14:
            case 15:
            case 16:
               return true;
            default:
               return false;
         }
      }
   }
}
