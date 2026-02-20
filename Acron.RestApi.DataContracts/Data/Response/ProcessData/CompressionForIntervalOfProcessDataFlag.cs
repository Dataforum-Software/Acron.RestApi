using Acron.RestApi.Interfaces.Data.Response.ProcessData;
using System.Collections;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData
{
   [DataContract]
   public class CompressionForIntervalOfProcessDataFlag : ICompressionForIntervalOfProcessDataFlag
   {
      [DataMember]
      public bool IDAT_REPLACEMENT { get; set; }

      [DataMember]
      public bool IDAT_OVER { get; set; }

      [DataMember]
      public bool IDAT_LESS { get; set; }

      [DataMember]
      public bool IDAT_GREATER { get; set; }

      [DataMember]
      public bool IDAT_MISSING { get; set; }

      [DataMember]
      public bool IDAT_UNDER_LIMIT { get; set; }

      [DataMember]
      public bool IDAT_OVER_LIMIT { get; set; }
   }
}