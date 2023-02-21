using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;

using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Response;

namespace Acron.RestApi.DataContracts.Configuration.Response
{

   [DataContract]
   public class CreateUpdateResult : ICreateUpdateResult
   {
      #region cTor

      public CreateUpdateResult(string errorText, IBaseObject restApiObject, IBaseObject baseObject)
      {
         HasError = true;
         ErrorText = errorText;
         RestApiObject = restApiObject;
         BaseObject = baseObject;
         UpdatedProperties = new List<string>();
      }

      public CreateUpdateResult(string errorText, IBaseObject restApiObject)
      {
         HasError = true;
         ErrorText = errorText;
         RestApiObject = restApiObject;
         BaseObject = null;
         UpdatedProperties = new List<string>();
      }

      public CreateUpdateResult(IBaseObject restApiObject, IBaseObject baseObject)
      {
         HasError = false;
         ErrorText = string.Empty;
         RestApiObject = restApiObject;
         BaseObject = baseObject;
         UpdatedProperties = new List<string>();
      }

      public CreateUpdateResult(IBaseObject restApiObject, IBaseObject baseObject, List<string> updatedProperties)
      {
         HasError = false;
         ErrorText = string.Empty;
         RestApiObject = restApiObject;
         BaseObject = baseObject;
         UpdatedProperties = updatedProperties;
      }

      #endregion cTor

      #region ICreateUpdateResult

      [DataMember]
      public bool HasError { get; internal set; }

      [DataMember]
      [DefaultValue("")]
      public string ErrorText { get; internal set; }

      [DataMember]
      public IBaseObject RestApiObject { get; internal set; }

      [DataMember]
      public IBaseObject BaseObject { get; internal set; }

      [DataMember]
      public List<string> UpdatedProperties { get; internal set; }

      #endregion ICreateUpdateResult

   }


   [DataContract]
   public class CreateUpdateResultList : ICreateUpdateResultList
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
                     .Where(item => item.HasError == false)
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
                     .Where(item => item.HasError == true)
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
   }

}