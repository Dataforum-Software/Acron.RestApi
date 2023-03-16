using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Response;
using System.Runtime.Serialization;


namespace Acron.RestApi.DataContracts.Configuration.Response
{

   [DataContract]
   public class ChangedObjectInfo : IChangedObjectInfo
   {
      #region cTor

      public ChangedObjectInfo()
      { }

      public ChangedObjectInfo(ModificationMode mode, BaseObjectDefines.RestObjectTypeCode restTypeCode, int id, string shortName, string longName)
      {
         ModificationModeVal = mode;
         RestTypeCodeVal = restTypeCode;
         Id = id;
         ShortName = shortName;  
         LongName = longName;
      }

      #endregion cTor

      public ModificationMode ModificationModeVal { get; set; }

      /// <summary> Typ des Objects </summary>
      public BaseObjectDefines.RestObjectTypeCode RestTypeCodeVal { get; set; }

      [DataMember]
      public string RestTypeCode 
      {
         get { return RestTypeCodeVal.ToString(); }
      }

      [DataMember]
      public int Id { get; set; }

      [DataMember]
      public string ShortName { get; set; }

      [DataMember]
      public string LongName { get; set; }

      [DataMember]
      public string ModificationMode 
      { 
         get { return ModificationModeVal.ToString(); } 
      }

   }
}