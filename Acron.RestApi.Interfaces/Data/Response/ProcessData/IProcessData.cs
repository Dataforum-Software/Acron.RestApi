using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using System.Collections.Generic;
using static Acron.RestApi.Interfaces.Data.Response.ProcessData.TData.ITDataBase;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData
{
   public interface IProcessData
   {
      uint PVID { get; }

      string ShortName { get; }

      public DataTypes DataType { get; }

      IArrayHeader ValuesArrayHeader { get; }

      List<ITDataBase> Values { get; }

      ITDataBase PredecessorValue { get; }

      IArrayHeader MinimaArrayHeader { get; }

      int MinimaElementCount { get; }

      List<ITDataBase> Minima { get; }

      IArrayHeader MaximaArrayHeader { get; }

      int MaximaElementCount { get; }

      List<ITDataBase> Maxima { get; }

      float PercentageReplacement { get; }
   }
}
