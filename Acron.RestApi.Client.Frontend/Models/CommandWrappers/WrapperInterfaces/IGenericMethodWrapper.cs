using Acron.RestApi.Interfaces.BaseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers
{
   internal interface IGenericMethodWrapper :IWrapper
   {
      public Type TestType { get; set; }
   }
}
