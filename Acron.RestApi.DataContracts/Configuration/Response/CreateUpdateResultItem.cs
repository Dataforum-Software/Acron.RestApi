using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;

using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Response;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Acron.RestApi.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.DataContracts.Configuration.Response
{

   [DataContract]
   public class CreateUpdateResult : ICreateUpdateResult<CreateUpdateResultItem>
   {
      #region cTor

      public CreateUpdateResult()
      {
         _data = new List<CreateUpdateResultItem>();
      }

      #endregion cTor

      #region ICreateUpdateResultList

      [DataMember]
      /// <summary>
      /// Count of elements with succesful performed action
      /// </summary>
      public int CountSuccessfully
      {
         get
         {
            return Data
                     .Where(item => item.State == CreateUpdateResultStates.Success)
                     .Count();
         }
      }

      [DataMember]
      /// <summary>
      /// Count of elements where action failed
      /// </summary>
      public int CountFailed
      {
         get
         {
            return Data
                     .Where(item => item.State == CreateUpdateResultStates.Error)
                     .Count();
         }
      }

      [DataMember]
      /// <summary>
      /// Count of not processed elements
      /// </summary>
      public int CountNotProcessed
      {
         get
         {
            return Data
                     .Where(item => item.State == CreateUpdateResultStates.NotProcessed)
                     .Count();
         }
      }


      private List<CreateUpdateResultItem> _data = null;

      [DataMember]
      /// <summary>
      /// Item foreach handled element
      /// </summary>
      public List<CreateUpdateResultItem> Data
      {
         get
         {
            if (_data == null)
               _data = new List<CreateUpdateResultItem>();

            return _data;
         }
      }

      #endregion ICreateUpdateResultList

      public void Add(CreateUpdateResultItem newItem)
      {
         _data.Add(newItem);
      }

      public void AddRange(List<CreateUpdateResultItem> newItems)
      {
         _data.AddRange(newItems);
      }

      public CreateUpdateResultItem FindItem(IBaseObject restApiObject)
      {
         if (restApiObject == null)
            return null;

         if (restApiObject.Id < 0 && string.IsNullOrEmpty(restApiObject.ShortName))
            return Data.FirstOrDefault(cur => cur.Id < 0 && string.IsNullOrEmpty(cur.ShortName));

         if (restApiObject.Id < 0)
            return Data.FirstOrDefault(cur => cur.ShortName == restApiObject.ShortName) as CreateUpdateResultItem;

         return Data.FirstOrDefault(cur => cur.Id == restApiObject.Id) as CreateUpdateResultItem;
      }
   }


   [DataContract]
   public class CreateUpdateResultItem : ICreateUpdateResultItem
   {
      #region cTor

      public CreateUpdateResultItem()
      {
         State = CreateUpdateResultStates.NotProcessed;
         ErrorText = string.Empty;
         _restApiObject = null;
         UpdatedProperties = new List<string>();
      }

      public CreateUpdateResultItem(IBaseObject restApiObject)
      {
         State = CreateUpdateResultStates.NotProcessed;
         ErrorText = string.Empty;
         _restApiObject = restApiObject;
         //BaseObject = null;
         UpdatedProperties = new List<string>();
      }

      public CreateUpdateResultItem(string errorText, IBaseObject restApiObject)
      {
         State = CreateUpdateResultStates.Error;
         ErrorText = errorText;
         _restApiObject = restApiObject;
         UpdatedProperties = new List<string>();
      }

      public CreateUpdateResultItem(IBaseObject restApiObject, CreateUpdateResultStates crUpdResult)
      {
         State = crUpdResult;
         ErrorText = string.Empty;
         _restApiObject = restApiObject;
         UpdatedProperties = new List<string>();
      }

      public CreateUpdateResultItem(IBaseObject restApiObject, List<string> updatedProperties, CreateUpdateResultStates crUpResult)
      {
         State = crUpResult;
         ErrorText = string.Empty;
         _restApiObject = restApiObject;
         UpdatedProperties = updatedProperties;
      }

      #endregion cTor

      private IBaseObject __restApiObject = null;
      private IBaseObject _restApiObject 
      {
         get { return __restApiObject; }
         set
         {
            __restApiObject = value;
         }
      }

      public IBaseObject GetRestApiObject()
      {
         return _restApiObject;
      }
       
      public void SetError(string errorText)
      {
         State = CreateUpdateResultStates.Error;
         ErrorText = errorText;
      }

      public void Update(CreateUpdateResultItem cur)
      {
         if (cur == null)
            return;

         // Im Ergebnis müssen immer Short- und LongName auftauchen
         if (this._restApiObject == null || string.IsNullOrEmpty(this._restApiObject.ShortName) || string.IsNullOrEmpty(this._restApiObject.LongName))
         {
            IBaseObject baseObj = cur.GetRestApiObject();
            this._restApiObject = baseObj;
         }

         this.State = cur.State;
         this.ErrorText = cur.ErrorText;
         this.UpdatedProperties = cur.UpdatedProperties;
      }

      #region ICreateUpdateResult

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public CreateUpdateResultStates State { get; set; }

      [DataMember]
      [DefaultValue("")]
      public string ErrorText { get; set; }

      public BaseObjectDefines.RestObjectTypeCode _restTypeCode;
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public BaseObjectDefines.RestObjectTypeCode RestTypeCode 
      {
         get 
         {
            if (_restApiObject == null)
            {
               //return BaseObjectDefines.RestObjectTypeCode.Unknown;
               return _restTypeCode;
            }

            return _restApiObject.RestTypeCode; 
         }
         set 
         { 
            _restTypeCode= value;
         }
      }

      private int _idParent;
      [DataMember]
      public int IdParent 
      {
         get 
         {
            if (_restApiObject == null)
               return _idParent;

            return _restApiObject.IdParent; 
         }
         set
         {
            _idParent= value;
         }
      }

      private int _id;
      [DataMember]
      public int Id 
      {
         get 
         {
            if (_restApiObject == null)
               return _id;

            return _restApiObject.Id; 
         }
         set
         {
            _id= value;
         }
      }

      private string _shortName;
      [DataMember]
      public string ShortName 
      {
         get 
         {
            if (_restApiObject == null)
               return _shortName;

            return _restApiObject.ShortName; 
         }
         set
         {
            _shortName = value;
         }
      }

      public string _longName;
      [DataMember]
      public string LongName 
      {
         get 
         {
            if (_restApiObject == null)
               return _longName;

            return _restApiObject.LongName; 
         }
         set
         {
            _longName= value;
         }
      }

      #endregion ICreateUpdateResult

      public List<string> UpdatedProperties { get; internal set; }
   }



}