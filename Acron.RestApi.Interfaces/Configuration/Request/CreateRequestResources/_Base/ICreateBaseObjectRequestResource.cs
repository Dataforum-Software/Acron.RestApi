using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
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
   public interface ICreateBaseObjectRequestResource
   {
      /// <summary>
      /// ACRON base object type
      /// </summary>

      [SwaggerSchema("Type of ACRON base object")]
      [SwaggerExampleValue("1001")]
      BaseObjectDefines.RestObjectTypeCode RestTypeCode { get; }

      ///// <summary>
      ///// Unique ID of ACRON base object
      ///// </summary>

      //[SwaggerSchema("Numerical ID of ACRON base object")]
      //[SwaggerExampleValue("300000000")]
      //int Id { get; set; }

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
      /// Base object ID of parent object or zero for highest level
      /// </summary>

      [SwaggerSchema("Numerical ID of parent object")]
      [SwaggerExampleValue(0)]
      int IdParent { get; set; }

      /// <summary>
      /// All directly subordinate base objects
      /// </summary>
      [SwaggerSchema("All subordinate base objects")]
      [SwaggerExampleValue("[300000002,300000003,300000004,300000005,300000006,300000007,300000008,300000009,300000010]")]
      List<int> ReferencedIBaseObjects { get; }

   }
}