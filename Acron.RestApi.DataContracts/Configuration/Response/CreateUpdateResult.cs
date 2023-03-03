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
   public class CreateUpdateResult : ICreateUpdateResult
   {
      #region cTor

      public CreateUpdateResult(IBaseObject restApiObject)
      {
         State = CrUpdState.NotProcessed;
         ErrorText = string.Empty;
         _restApiObject = restApiObject;
         //BaseObject = null;
         UpdatedProperties = new List<string>();
      }

      public CreateUpdateResult(string errorText, IBaseObject restApiObject)
      {
         State = CrUpdState.Error;
         ErrorText = errorText;
         _restApiObject = restApiObject;
         UpdatedProperties = new List<string>();
      }

      public CreateUpdateResult(IBaseObject restApiObject, CrUpdState crUpdResult)
      {
         State = crUpdResult;
         ErrorText = string.Empty;
         _restApiObject = restApiObject;
         UpdatedProperties = new List<string>();
      }

      public CreateUpdateResult(IBaseObject restApiObject, List<string> updatedProperties, CrUpdState crUpResult)
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
         State = CrUpdState.Error;
         ErrorText = errorText;
      }

      public void Update(CreateUpdateResult cur)
      {
         if (cur == null)
            return;

         this.State = cur.State;
         this.ErrorText = cur.ErrorText;
         this.UpdatedProperties = cur.UpdatedProperties;
      }

      #region ICreateUpdateResult

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public CrUpdState State { get; internal set; }

      [DataMember]
      [DefaultValue("")]
      public string ErrorText { get; internal set; }

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public BaseObjectDefines.RestObjectTypeCode RestTypeCode 
      {
         get { return _restApiObject.RestTypeCode; }
      }

      [DataMember]
      public int IdParent 
      {
         get { return _restApiObject.IdParent; }
      }

      [DataMember]
      public int Id 
      {
         get { return _restApiObject.Id; }
      }

      [DataMember]
      public string ShortName 
      {
         get { return _restApiObject.ShortName; }
      }

      [DataMember]
      public string LongName 
      {
         get { return _restApiObject.LongName; }
      }
 
      #endregion ICreateUpdateResult

      public List<string> UpdatedProperties { get; internal set; }
   }


   [DataContract]
   public class CreateUpdateResultList : ICreateUpdateResultList<ICreateUpdateResult>
   {
      #region cTor

      public CreateUpdateResultList()
      {
         _data = new List<ICreateUpdateResult>();
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
                     .Where(item => item.State == CrUpdState.Success)
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
                     .Where(item => item.State == CrUpdState.Error)
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
                     .Where(item => item.State == CrUpdState.NotProcessed)
                     .Count();
         }
      }


      private List<ICreateUpdateResult> _data = null;

      [DataMember]
      /// <summary>
      /// Item foreach handled element
      /// </summary>
      public IEnumerable<ICreateUpdateResult> Data
      {
         get
         {
            if (_data == null)
               _data = new List<ICreateUpdateResult>();

            return _data;
         }
      }

      #endregion ICreateUpdateResultList

      public void Add(ICreateUpdateResult newItem)
      {
         _data.Add(newItem);
      }

      public void AddRange(IEnumerable<ICreateUpdateResult> newItems)
      {
         _data.AddRange(newItems);
      }

      public CreateUpdateResult FindItem(IBaseObject restApiObject)
      {
         if (restApiObject == null)
            return null;

         if (restApiObject.Id < 0 && string.IsNullOrEmpty(restApiObject.ShortName))
            return null;

         if (restApiObject.Id < 0)
            return Data.FirstOrDefault(cur => cur.ShortName == restApiObject.ShortName) as CreateUpdateResult;

         return Data.FirstOrDefault(cur => cur.Id == restApiObject.Id) as CreateUpdateResult;
      }
   }

}