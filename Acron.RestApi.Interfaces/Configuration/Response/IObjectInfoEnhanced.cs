using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public interface IObjectInfoEnhanced<T> where T : IBaseObject
   {
      /// <summary> Ergebnis Object </summary>
      [SwaggerSchema("Config object")]
      [SwaggerExampleValue(typeof(IBaseObject))]
      T BaseObject { get; }

      /// <summary> Referenzierte Objecte (Ids) </summary>
      [SwaggerSchema("List of objects referenced by this config object")]
      [SwaggerExampleValue(new int[] { 302000003 })]
      List<int> ReferencedObjects { get; }

      /// <summary> Objecte, von denen BaseObject referenziert wird (Ids) </summary>
      [SwaggerSchema("List of objects that contain references to this config object")]
      [SwaggerExampleValue(new int[] { 302000005 })]
      List<int> ObjectUsages { get; }
   }
}
