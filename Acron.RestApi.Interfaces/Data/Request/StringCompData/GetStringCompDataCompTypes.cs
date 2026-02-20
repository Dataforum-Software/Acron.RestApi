using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.StringCompData
{
   public enum GetStringCompDataCompTypes
   {
      [EnumMember]
      [SwaggerEnumInfo("No compression")]
      None = DBN_CompTypes.DBN_NONE,
      [EnumMember]
      [SwaggerEnumInfo("Main interval")]
      INT_1 = DBN_CompTypes.DBN_INT_1,
      [EnumMember]
      [SwaggerEnumInfo("Secondary interval")]
      INT_2 = DBN_CompTypes.DBN_INT_2,
      [EnumMember]
      [SwaggerEnumInfo("Custom interval 1")]
      INT_3 = DBN_CompTypes.DBN_INT_3,
      [EnumMember]
      [SwaggerEnumInfo("Custom interval 2")]
      INT_4 = DBN_CompTypes.DBN_INT_4,
      [EnumMember]
      [SwaggerEnumInfo("Custom interval 3")]
      INT_5 = DBN_CompTypes.DBN_INT_5,
      [EnumMember]
      [SwaggerEnumInfo("Custom interval 4")]
      INT_6 = DBN_CompTypes.DBN_INT_6,
      [EnumMember]
      [SwaggerEnumInfo("Custom interval 5")]
      INT_7 = DBN_CompTypes.DBN_INT_7,
      [EnumMember]
      [SwaggerEnumInfo("Custom interval 6")]
      INT_8 = DBN_CompTypes.DBN_INT_8,
      [EnumMember]
      [SwaggerEnumInfo("Daily value for main interval")]
      DAY_1 = DBN_CompTypes.DBN_DAY_1,
      [EnumMember]
      [SwaggerEnumInfo("Daily value for secondary interval")]
      DAY_2 = DBN_CompTypes.DBN_DAY_2,
   }
}
