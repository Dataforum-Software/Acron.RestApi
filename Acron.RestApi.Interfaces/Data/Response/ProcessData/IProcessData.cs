using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData
{
   public interface IProcessDataBase<TDataBaseType, ValueDataBitArrayType, StringValueDataBitArrayType> 
                  where ValueDataBitArrayType : ITDataBitArrayNum
                  where StringValueDataBitArrayType : ITDataBitArrayString 
                  where TDataBaseType : ITDataBase<ValueDataBitArrayType, StringValueDataBitArrayType>                                                    
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

      [SwaggerSchema("Percentage of replaced values")]
      [SwaggerExampleValue(0.0)]
      float PercentageReplacement { get; }

      [SwaggerSchema("Values element count")]
      [SwaggerExampleValue(0)]
      int ValuesElementCount { get; }






      [SwaggerSchema("Collection of process values")]
      [SwaggerExampleValue(typeof(ITDataBase<ITDataBitArrayNum, ITDataBitArrayString>))]
      List<TDataBaseType> Values { get; set; }

      [SwaggerSchema("Last process value preceding selected time range")]
      [SwaggerExampleValue(typeof(ITDataBase<ITDataBitArrayNum, ITDataBitArrayString>))]
      TDataBaseType PredecessorValue { get; set; }

      [SwaggerSchema("Minima element count")]
      [SwaggerExampleValue(0)]
      int MinimaElementCount { get; }

      [SwaggerSchema("List of min values")]
      [SwaggerExampleValue(typeof(ITDataBase<ITDataBitArrayNum, ITDataBitArrayString>))]
      List<TDataBaseType> Minima { get; set; }

      [SwaggerSchema("Maxima element count")]
      [SwaggerExampleValue(0)]
      int MaximaElementCount { get; }

      [SwaggerSchema("List of max values")]
      [SwaggerExampleValue(typeof(ITDataBase<ITDataBitArrayNum, ITDataBitArrayString>))]
      List<TDataBaseType> Maxima { get; set; }


   }
}
