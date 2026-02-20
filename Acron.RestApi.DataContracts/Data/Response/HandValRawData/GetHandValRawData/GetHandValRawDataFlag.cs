using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawData
{
   [DataContract]
   public class GetHandValRawDataFlag : IGetHandValRawDataFlag
   {
      [DataMember]
      public bool HDAT_GREATER { get; set; }

      [DataMember]
      public bool HDAT_LESS { get; set; }

      [DataMember]
      public bool HDAT_KEYVALID { get; set; }

      [DataMember]
      public bool HDAT_UNDER_LIMIT { get; set; }

      [DataMember]
      public bool HDAT_OVER_LIMIT { get; set; }
   }
}
