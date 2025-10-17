using Acron.RestApi.DataContracts.Data.Request.DayData;
using Acron.RestApi.Interfaces.Data.Request.ProcessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.ProcessData
{
   public class GetProcessDataPVDescriptionForTemporaryCompression : IGetProcessDataPVDescriptionForTemporaryCompression<DayWhat>
   {
      public uint PVID { get; set; }
      public IGetProcessDataPVDescription.DataValueTypes ValueTypes { get; set; }
      public IGetProcessDataPVDescription.DBP_ReadTypes DBP_ReadType { get; set; }
      public DayWhat DayWhat { get; set; }
   }
}
