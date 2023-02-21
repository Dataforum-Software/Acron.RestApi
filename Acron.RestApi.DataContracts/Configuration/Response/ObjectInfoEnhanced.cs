using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Response;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Response
{

   [DataContract]
   public class ObjectInfoEnhanced : IObjectInfoEnhanced
   {
      #region cTor

      public ObjectInfoEnhanced(IBaseObject baseObject) : this(baseObject, null, null)
      { }

      public ObjectInfoEnhanced(IBaseObject baseObject, List<int> referencedObjects, List<int> objectUsages)
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

      #endregion cTor

      /// <summary> Ergebnis Object </summary>
      [DataMember]
      public IBaseObject BaseObject { get; private set; }

      /// <summary> Referenzierte Objecte (Ids) </summary>
      [DataMember]
      public List<int> ReferencedObjects { get; private set; }

      /// <summary> Objecte, von denen BaseObject referenziert wird (Ids) </summary>
      [DataMember]
      public List<int> ObjectUsages { get; private set; }

   }

}
