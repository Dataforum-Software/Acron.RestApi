using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public interface IObjectInfoEnhanced
   {
      /// <summary> Ergebnis Object </summary>
      [SwaggerSchema("Config object")]
      IBaseObject BaseObject { get; }

      /// <summary> Referenzierte Objecte (Ids) </summary>
      [SwaggerSchema("List of objects referenced by this config object")]
      List<int> ReferencedObjects { get; }

      /// <summary> Objecte, von denen BaseObject referenziert wird (Ids) </summary>
      [SwaggerSchema("List of objects that contain references to this config object")]
      List<int> ObjectUsages { get; }
   }
}
