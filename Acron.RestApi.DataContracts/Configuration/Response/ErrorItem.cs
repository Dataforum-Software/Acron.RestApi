using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Response
{
   
   [DataContract]
   public class ErrorItem : IErrorItem
   {
      #region cTor

      public ErrorItem()
      {
         _restTypeCode = BaseObjectDefines.RestObjectTypeCode.Unknown;
      }

      public ErrorItem(IErrorItem errorItem)
      {
         if (errorItem == null)
            throw new ArgumentNullException("errorItem");

         mapProperties(errorItem);
      }

      #endregion cTor

      private void mapProperties(IErrorItem errorItem)
      {
         _restTypeCode = errorItem.RestTypeCode;
         _id = errorItem.Id;
         _affectedProperties = errorItem.AffectedPropertyKey;
         _text = errorItem.Text;
      }

      #region IErrorItem

      private BaseObjectDefines.RestObjectTypeCode _restTypeCode;

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public BaseObjectDefines.RestObjectTypeCode RestTypeCode
      {
         get { return _restTypeCode; }
         set { _restTypeCode = value; }
      }

      private int _id;

      [DataMember]
      public int Id
      {
         get { return _id; }
         set { _id = value; }
      }

      private string[] _affectedProperties = null;

      [DataMember]
      public string[] AffectedPropertyKey
      {
         get { return _affectedProperties; }
         set { _affectedProperties = value; }  
      }

      private string _text = string.Empty;

      [DataMember]
      public string Text
      {
         get { return _text; }
         set { _text = value; }
      }

      #endregion IErrorItem

   }
}
