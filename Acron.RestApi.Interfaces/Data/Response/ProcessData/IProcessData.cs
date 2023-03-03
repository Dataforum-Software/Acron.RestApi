using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using static Acron.RestApi.Interfaces.Data.Response.ProcessData.TData.ITDataBase;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData
{
   public interface IProcessData
   {
      [SwaggerSchema("Numeric ID process value")]
      [SwaggerExampleValue(302000003)]
      uint PVID { get; }

      [SwaggerSchema("Identification of process value")]
      [SwaggerExampleValue("Temperature")]
      string ShortName { get; }

      [SwaggerSchema("Data type (Numeric / Text)")]
      [SwaggerExampleValue(DataTypes.Numeric)]
      public DataTypes DataType { get; }

      //internal
      IArrayHeader ValuesArrayHeader { get; }

      [SwaggerSchema("Collection of process values")]
      [SwaggerExampleValue(typeof(ITDataBase))]
      List<ITDataBase> Values { get; }

      [SwaggerSchema("Last process value preceding selected time range")]
      [SwaggerExampleValue(typeof(ITDataBase))]
      ITDataBase PredecessorValue { get; }

      //internal
      IArrayHeader MinimaArrayHeader { get; }

      [SwaggerSchema("Minima element count")]
      [SwaggerExampleValue(0)]
      int MinimaElementCount { get; }

      [SwaggerSchema("List of min values")]
      [SwaggerExampleValue(typeof(ITDataBase))]
      List<ITDataBase> Minima { get; }

      //internal
      IArrayHeader MaximaArrayHeader { get; }

      [SwaggerSchema("Maxima element count")]
      [SwaggerExampleValue(0)]
      int MaximaElementCount { get; }

      [SwaggerSchema("List of max values")]
      [SwaggerExampleValue(typeof(ITDataBase))]
      List<ITDataBase> Maxima { get; }

      [SwaggerSchema("Percentage of replaced values")]
      [SwaggerExampleValue(0.0)]
      float PercentageReplacement { get; }
   }
}
