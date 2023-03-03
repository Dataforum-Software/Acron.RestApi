using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   [DataContract]
   public class WriteHandValRawDataAndInfoFlag : IWriteHandValRawDataAndInfoFlag
   {
      [DataMember]
      public bool HDAT_GREATER { get; set; }

      [DataMember]
      public bool HDAT_LESS { get; set; }

      [DataMember]
      public bool HDAT_KEYVALID { get; set; }
   }
}
