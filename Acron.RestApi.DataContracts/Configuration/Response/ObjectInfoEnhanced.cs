using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Response;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Response
{

   [DataContract]
   public class ObjectInfoEnhanced : IObjectInfoEnhanced<RestApiBaseObject>
   {
      #region cTor

      public ObjectInfoEnhanced() { }

      public ObjectInfoEnhanced(RestApiBaseObject baseObject) : this(baseObject, null, null)
      { }

      public ObjectInfoEnhanced(RestApiBaseObject baseObject, List<int> referencedObjects, List<int> objectUsages)
      {
         BaseObject = baseObject;

         if (referencedObjects != null)
            ReferencedObjects = referencedObjects;
         else
            ReferencedObjects = new List<int>();

         if (objectUsages != null)
            ObjectUsages = objectUsages;
         else
            ObjectUsages = new List<int>();
      }

      public ObjectInfoEnhanced(ObjectInfoEnhanced iObj)
      {
         BaseObject = iObj.BaseObject;
         ReferencedObjects = iObj.ReferencedObjects;
         ObjectUsages = iObj.ObjectUsages;
      }

      #endregion cTor

      /// <summary> Ergebnis Object </summary>
      [DataMember]
      public RestApiBaseObject BaseObject { get; private set; }

      /// <summary> Referenzierte Objecte (Ids) </summary>
      [DataMember]
      public List<int> ReferencedObjects { get; private set; }

      /// <summary> Objecte, von denen BaseObject referenziert wird (Ids) </summary>
      [DataMember]
      public List<int> ObjectUsages { get; private set; }

   }

}
