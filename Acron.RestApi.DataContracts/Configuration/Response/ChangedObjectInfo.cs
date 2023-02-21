using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Response;
using System.Runtime.Serialization;


namespace Acron.RestApi.DataContracts.Configuration.Response
{

   [DataContract]
   public class ChangedObjectInfo : IChangedObjectInfo
   {
      #region cTor

      public ChangedObjectInfo(ModificationMode mode, BaseObjectDefines.RestObjectTypeCode restTypeCode, int id, string shortName, string longName)
      {
         ModificationModeVal = mode;
         RestTypeCodeVal = restTypeCode;
         Id = id;
         ShortName = shortName;  
         LongName = longName;
      }

      #endregion cTor

      public ModificationMode ModificationModeVal { get; private set; }

      /// <summary> Typ des Objects </summary>
      public BaseObjectDefines.RestObjectTypeCode RestTypeCodeVal { get; private set; }

      [DataMember]
      public string RestTypeCode 
      {
         get { return RestTypeCodeVal.ToString(); }
      }

      [DataMember]
      public int Id { get; private set; }

      [DataMember]
      public string ShortName { get; private set; }

      [DataMember]
      public string LongName { get; private set; }

      [DataMember]
      public string ModificationMode 
      { 
         get { return ModificationModeVal.ToString(); } 
      }

   }
}