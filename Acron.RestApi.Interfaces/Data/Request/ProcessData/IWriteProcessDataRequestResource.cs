﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.ProcessData
{
   public interface IWriteProcessDataRequestResource<T> where T : IWriteProcessDataDescription
   {
      List<T> ProcessDataDescriptions { get; set; }
   }
}
