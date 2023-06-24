using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.BaseObjects
{
public static class BaseObjectDefines
   {
      public const double NO_VALID = +1.1e+35;

      /// <summary>
      /// Types of ACRON base objects, which are available for the API
      /// </summary>
      public enum RestObjectTypeCode : int
      {
         /// <summary>Unknown type. This ist an error which must not occur.</summary>
         [SwaggerEnumInfo("Undefined")]
         Unknown = 0,

         #region group based

         //PlantConfig - GROUPS
         /// <summary>root group</summary>
         [SwaggerEnumInfo("Root")]
         RootGroup = 1000,
         /// <summary>default group</summary>
         [SwaggerEnumInfo("Default group")]
         DefaultGroup = 1001,

         /// <summary>ProviderNoConfig group</summary>
         [SwaggerEnumInfo("Auto generated provider for manual variables")]
         ProviderNoConfig = 1002,

         /// <summary>Provider group</summary>
         [SwaggerEnumInfo("Provider")]
         Provider = 1003,

         /// <summary>ExtVar group</summary>
         [SwaggerEnumInfo("External variables group")]
         ExtVarGroup = 1004,

         ///// <summary>Report group</summary>
         //ReportGroup = 56,
         /// <summary>Alert group</summary>
         [SwaggerEnumInfo("Alerts group")]
         AlertGroup = 1007,

         /// <summary>Process variable group</summary>
         [SwaggerEnumInfo("Process variable group")]
         VgVarGroup = 1011,

         /// <summary>Connection group</summary>
         [SwaggerEnumInfo("Connections group")]
         ConnectionGroup = 1023,

         /// <summary>BaseUnit (Hat Units als ReferencedObjects >> Daher als Gruppe definiert)</summary>
         [SwaggerEnumInfo("Base units group")]
         BaseUnit = 1024,

         /// <summary>ProviderRestApi group</summary>
         [SwaggerEnumInfo("Auto generated provider for rest api variables")]
         ProviderRestApi = 1025,

         #endregion group based

         #region simple

         //PlantConfig objects
         /// <summary>Plant base configuration</summary>
         [SwaggerEnumInfo("Plant object")]
         Plant = 1050,

         /// <summary>Local plant configuration</summary>
         [SwaggerEnumInfo("Plant object - no user login")]
         PlantLocal = 1051,

         /// <summary>External variable</summary>
         [SwaggerEnumInfo("External variable object")]
         ExtVar = 1052,

         /// <summary>Alert</summary>
         [SwaggerEnumInfo("Alert object")]
         Alert = 1053,

         /// <summary>Process variable - auto</summary>
         [SwaggerEnumInfo("Process variable object, type 'auto'")]
         VgAuto = 1055,

         /// <summary>Process variable - manual</summary>
         [SwaggerEnumInfo("Process variable object, type 'manual'")]
         VgHand = 1056,

         /// <summary>Process variable - calculation</summary>
         [SwaggerEnumInfo("Process variable object, type 'calculation'")]
         VgCalc = 1057,

         /// <summary>Process variable - calculation from key figure</summary>
         [SwaggerEnumInfo("Process variable object, type 'key figure'")]
         VgCalcReference = 1061,

         /// <summary>Connection</summary>
         [SwaggerEnumInfo("Connection object")]
         Connection = 1111,

         /// <summary>External process variable</summary>
         [SwaggerEnumInfo("External process variable object")]
         VgExternal = 1112,

         /// <summary>Unit</summary>
         [SwaggerEnumInfo("Unit object")]
         Unit = 1113,

         #endregion simple

         /// <summary>A provider driver.</summary>
         [SwaggerEnumInfo("Provider driver object")]
         ProviderDriver = 1201,
      };


   }
}
