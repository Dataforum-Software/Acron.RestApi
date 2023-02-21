using Acron.RestApi.Interfaces.Data.Request.YearData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.YearData
{
   [DataContract]
   public class GetYearDataPVDescription : IGetYearDataPVDescription<YearWhat>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public YearWhat YearWhat { get; set; }
   }
}
