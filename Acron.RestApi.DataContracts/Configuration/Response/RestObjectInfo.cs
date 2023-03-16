using System.Collections.Generic;
using System.Runtime.Serialization;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Response;

namespace Acron.RestApi.DataContracts.Configuration.Response
{
   
   [DataContract]
   public class RestObjectInfo : IRestObjectInfo
   {
      #region cTor

      public RestObjectInfo() { }

      public RestObjectInfo(BaseObjectDefines.RestObjectTypeCode restTypeCode, DefaultGroupDefines.GroupType defaultGroupType, int configIdMin, int configIdMax, bool isReadOnly)
      {
         RestTypeCodeVal = restTypeCode;
         DefaultGroupTypeVal = defaultGroupType;
         ConfigIdMin = configIdMin;
         ConfigIdMax = configIdMax;
         IsReadOnly = isReadOnly;
         ValidIDs = new List<int>();
      }

      public RestObjectInfo(BaseObjectDefines.RestObjectTypeCode restTypeCode, DefaultGroupDefines.GroupType defaultGroupType, List<int> validIDs, bool isReadOnly)
      {
         RestTypeCodeVal = restTypeCode;
         DefaultGroupTypeVal = defaultGroupType;
         ConfigIdMin = -1;
         ConfigIdMax = -1;
         IsReadOnly = isReadOnly;
         ValidIDs = validIDs;
      }

      public RestObjectInfo(IRestObjectInfo iRestObj)
      {
         RestTypeCode = iRestObj.RestTypeCode;
         DefaultGroupType = iRestObj.DefaultGroupType;
         IsReadOnly = iRestObj.IsReadOnly;
         NumberRange = iRestObj.NumberRange;
      }

      #endregion cTor

      /// <summary> Typ des Objects </summary>
      public BaseObjectDefines.RestObjectTypeCode RestTypeCodeVal { get; private set; }

      private string _restTypeCode = null;

      /// <summary> Typ des Objects </summary>
      [DataMember]
      public string RestTypeCode
      {
         get 
         { 
            if (!string.IsNullOrEmpty(_restTypeCode)) 
            {
               return _restTypeCode;
            }

            return string.Format("{0} ({1})", (int)RestTypeCodeVal, RestTypeCodeVal.ToString());  
         }
         private set 
         {
            _restTypeCode = value;
         }
      }

      /// <summary> Hauptgruppe des Objects / Bereich </summary>
      public DefaultGroupDefines.GroupType DefaultGroupTypeVal { get; private set; }

      private string _defaultGroupType = null;

      /// <summary> Hauptgruppe des Objects / Bereich </summary>
      [DataMember]
      public string DefaultGroupType 
      {
         get 
         {
            if (!string.IsNullOrEmpty(_defaultGroupType))
               return _defaultGroupType;

            if (DefaultGroupTypeVal == DefaultGroupDefines.GroupType.DefaultUnknown)
               return "n.a.";

            return string.Format("{0} ({1})", DefaultGroupTypeVal.ToString(), (int)DefaultGroupTypeVal); 
         }
         private set 
         { 
            _defaultGroupType = value;
         }
      }

      /// <summary>
      /// Kleinste ID
      /// </summary>
      public int ConfigIdMin { get; private set; }

      /// <summary>
      /// Größte ID
      /// </summary>
      public int ConfigIdMax { get; private set; }

      /// <summary>
      /// Alternativ zum Min/Max - nur diskrete Werte
      /// </summary>
      public List<int> ValidIDs { get; private set; }

      /// <summary>
      /// true - Objekte dieses Typs können nicht geändert werden
      /// </summary>
      [DataMember]
      public bool IsReadOnly { get; internal set; }

      private string _numberRange = null;
      /// <summary>
      /// Alle gültigen IDs für diesen Objekt-Typ
      /// </summary>
      [DataMember]
      public string NumberRange 
      { 
         get
         {
            if (!string.IsNullOrEmpty(_numberRange))
               return _numberRange;

            if (ConfigIdMin != -1 && ConfigIdMax != -1)
               return string.Format("{0}  -  {1}", ConfigIdMin, ConfigIdMax);

            string result = string.Empty;

            foreach(int val in ValidIDs)
            {
               if (!string.IsNullOrEmpty(result))
                  result += ", ";
               result += val.ToString();
            }

            return result;
         }
         private set 
         { 
            _numberRange = value;
         }
      }

   }
}