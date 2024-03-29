﻿using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawData
{
   [DataContract]
   public class GetHandValRawDataResult : IGetHandValRawDataResult<GetHandValRawData, GetHandValRawDataDayValue, GetHandValRawDataValue, GetHandValRawDataFlag>
   {
      [DataMember]
      public bool HasData
      {
         get { return PVList.Any(); }
      }

      [DataMember]
      public int PVCount
      {
         get { return PVList.Count; }
      }

      [DataMember]
      public List<GetHandValRawData> PVList { get; set; } = new List<GetHandValRawData>();
   }
}
