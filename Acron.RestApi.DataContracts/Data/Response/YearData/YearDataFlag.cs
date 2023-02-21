using Acron.RestApi.Interfaces.Data.Response.YearData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.YearData
{
   [DataContract]
   public class YearDataFlag : IYearDataFlag
   {
      [DataMember]
      public bool YDAT_REPLACEMENT { get; set; }
      [DataMember]
      public bool YDAT_NOREL { get; set; }
      [DataMember]
      public bool YDAT_MISSING { get; set; }
      [DataMember]
      public bool YDAT_UNDER_LIMIT { get; set; }
      [DataMember]
      public bool YDAT_OVER_LIMIT { get; set; }
   }
}
