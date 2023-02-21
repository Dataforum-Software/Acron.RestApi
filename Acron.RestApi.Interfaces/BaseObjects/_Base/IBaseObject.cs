using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Base interface for all objects of the configuration
   /// </summary>
   /// <remarks>
   /// !!!!!!!
   /// For all classes, which implement this interface or derived interfaces,
   /// the user must assure that when creating an instance all ACRON properties 
   /// of type 'double' are initialized as 'BaseObjectDefines.NO_VALID' 
   /// !!!!!!!
   /// </remarks>
   public interface IBaseObject
   {
      /// <summary>
      /// ACRON base object type
      /// </summary>

      [SwaggerSchema("Type of ACRON base object")]
      [SwaggerExampleValue("1001")]
      BaseObjectDefines.RestObjectTypeCode RestTypeCode { get; }

      /// <summary>
      /// Unique ID of ACRON base object
      /// </summary>

      [SwaggerSchema("Id of ACRON object")]
      [SwaggerExampleValue("300000000")]
      int Id { get; set; }

      /// <summary>
      /// Base object identification
      /// </summary>
      [SwaggerSchema("Base object identification")]
      [SwaggerExampleValue("")]
      string ShortName { get; set; }

      /// <summary>
      /// Base object designation
      /// </summary>
      [SwaggerSchema("Base object designation")]
      [SwaggerExampleValue("Process variables")]
      string LongName { get; set; }

      /// <summary>
      /// Position within a group
      /// </summary>

      [SwaggerSchema("Base object position")]
      [SwaggerExampleValue("1")]
      int Position { get; set; }

      ///// <summary>
      ///// Parent object or null for highest level
      ///// </summary>
      //IGroupBaseObject Parent { get; set; }

      /// <summary>
      /// Base object ID of parent object or null for highest level
      /// </summary>
      
      [SwaggerSchema("Base object id of parent object")]
      [SwaggerExampleValue("")]
      int IdParent { get; set; }

      /// <summary>
      /// All directly subordinate base objects
      /// </summary>

      [SwaggerSchema("All subordinate base objects")]
      [SwaggerExampleValue("[300000002,300000003,300000004,300000005,300000006,300000007,300000008,300000009,300000010]")]
      IEnumerable<int> ReferencedIBaseObjects { get; }
   }

   public static class BaseObjectDefines
   {
      public const double NO_VALID = +1.1e+35;

      /// <summary>
      /// Types of ACRON base objects, which are available for the API
      /// </summary>
      public enum RestObjectTypeCode : int
      {
         /// <summary>Unknown type. This ist an error which must not occur.</summary>
         Unknown = 0,

         #region group based

         //PlantConfig - GROUPS
         /// <summary>root group</summary>
         RootGroup = 1000,
         /// <summary>default group</summary>
         DefaultGroup = 1001,

         /// <summary>ProviderNoConfig group</summary>
         ProviderNoConfig = 1002,
         /// <summary>Provider group</summary>
         Provider = 1003,
         /// <summary>ExtVar group</summary>
         ExtVarGroup = 1004,

         ///// <summary>Report group</summary>
         //ReportGroup = 56,
         /// <summary>Alert group</summary>
         AlertGroup = 1007,

         /// <summary>Process variable group</summary>
         VgVarGroup = 1011,

         /// <summary>Connection group</summary>
         ConnectionGroup = 1023,

         /// <summary>BaseUnit (Hat Units als ReferencedObjects >> Daher als Gruppe definiert)</summary>
         BaseUnit = 1024,

         #endregion group based

         #region simple

         //PlantConfig objects
         /// <summary>Plant base configuration</summary>
         Plant = 1050,
         /// <summary>Local plant configuration</summary>
         PlantLocal = 1051,

         /// <summary>External variable</summary>
         ExtVar = 1052,

         /// <summary>Alert</summary>
         Alert = 1053,

         /// <summary>Process variable - auto</summary>
         VgAuto = 1055,
         /// <summary>Process variable - manual</summary>
         VgHand = 1056,
         /// <summary>Process variable - calculation</summary>
         VgCalc = 1057,
         /// <summary>Process variable - calculation from key figure</summary>
         VgCalcReference = 1061,

         /// <summary>Connection</summary>
         Connection = 1111,

         /// <summary>External process variable</summary>
         VgExternal = 1112,

         /// <summary>Unit</summary>
         Unit = 1113,

         #endregion simple

         /// <summary>A provider driver.</summary>
         ProviderDriver = 1201,
      };


   }
 
}