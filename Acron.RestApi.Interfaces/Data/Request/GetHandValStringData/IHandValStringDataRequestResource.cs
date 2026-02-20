using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.HandValStringData
{
   public interface IHandValStringDataRequestResource
   {
      [SwaggerSchema("Get weekly, monthly or yearly values")]
      [SwaggerExampleValue(HandValStringDataKind.PVWEEKVAL)]
      HandValStringDataKind Kind { get; set; }

      [SwaggerSchema("Start date")]
      [SwaggerExampleValue("2020-08-15")]
      DateOnly FromDate { get; set; }

      [SwaggerSchema("End date")]
      [SwaggerExampleValue("2020-08-16")]
      DateOnly ToDate { get; set; }

      [SwaggerSchema("List of process variable ids")]
      [SwaggerExampleValue(new int[] { 302000001, 302000005, 302000013, 302000015, 302000016, 302000029 })]
      List<uint> PVIds { get; set; }
   }


   [SwaggerSchema("Value types for process variables with output format text")]
   public enum HandValStringDataKind : short
   {
      [SwaggerEnumInfo("Undefined")]
      UNKNOWN = AVComKinds.AVCOMMENT_UNKNOWN,  

      [SwaggerEnumInfo("Daily comment for a process variable")]
      PVDAY = AVComKinds.AVCOMMENT_PVDAY, 

      [SwaggerEnumInfo("Weekly value for a process variable of type text")]
      PVWEEKVAL = AVComKinds.AVCOMMENT_PVWEEKVAL, 

      [SwaggerEnumInfo("Monthly value for a process variable of type text")]
      PVMONVAL = AVComKinds.AVCOMMENT_PVMONVAL, 

      [SwaggerEnumInfo("Yearly value for a process variable of type text")]
      PVYEARVAL = AVComKinds.AVCOMMENT_PVYEARVAL, 
   }
}
