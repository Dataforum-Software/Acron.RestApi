using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Base interface for units
   /// </summary>
   public interface IUnitBase : IGroupBaseObject
   {
      /// <summary>
      /// Beschreibung der Einheit
      /// </summary>
      /// 
      [SwaggerSchema("Description of unit ")]
      [SwaggerExampleValue("")]
      public string PropDescription { get; set; }
   }

   public static class UnitDefines
   {
      #region Enums + Defines

      public enum UnitType
      {
         /// <summary>
         /// "Diverse Einheiten"
         /// </summary>
         Default = 0,
         /// <summary>
         /// Von uns vorgegebene
         /// </summary>
         DaFo = 1,
         /// <summary>
         /// Vom Kunden
         /// </summary>
         User = 2,
      }

      /// <summary>
      /// Identifikation der Basiseinheit "Stücke"
      /// </summary>
      public const string UnitlessShortName = "pcs";

      #endregion Enums + Defines

   }
}