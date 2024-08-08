using Acron.RestApi.Interfaces;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiUserObject : RestApiBaseObject, IUserObject
   {
      #region cTor

      public RestApiUserObject()
         : base(BaseObjectDefines.RestObjectTypeCode.User)
      { }

      public RestApiUserObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IUserObject iUs = baseObject as IUserObject;

         this.ShortName = null;
         this.LongName = null;

         //this.PropUserGroupId = iUs.PropUserGroupId;
         this.PropLogin = iUs.PropLogin;
         this.PropFirstName = iUs.PropFirstName;
         this.PropLastName = iUs.PropLastName;
         this.PropEmailAdress = iUs.PropEmailAdress;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         //   ICreateUserObjectRequestResource iAl = baseObject as ICreateUserObjectRequestResource;

         this.ShortName = null;
         this.LongName = null;

         //this.PropLogin = iUs.PropLogin;
         //this.PropFirstName = iUs.PropFirstName;
         //this.PropLastName = iUs.PropLastName;
         //this.PropEmailAdress = iUs.PropEmailAdress;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         //   IUpdateUserObjectRequestResource iAl = baseObject as IUpdateUserObjectRequestResource;

         this.ShortName = null;
         this.LongName = null;

         //this.PropLogin = iUs.PropLogin;
         //this.PropFirstName = iUs.PropFirstName;
         //this.PropLastName = iUs.PropLastName;
         //this.PropEmailAdress = iUs.PropEmailAdress;

         return true;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.ShortName = null;
         this.LongName = null;

         //this.PropUserGroupId = 0;
         this.PropLogin = string.Empty;
         this.PropFirstName = string.Empty;
         this.PropLastName = string.Empty;
         this.PropEmailAdress = string.Empty;
      }

      #region IUserObject

      //private int _propUserGroupId = 0;

      //[DataMember]
      ///// <summary> Id of usergroup </summary>
      //public int PropUserGroupId
      //{
      //   get { return _propUserGroupId; }
      //   private set
      //   {
      //      _propUserGroupId = value;
      //      ModifiedProperties.Add(nameof(PropUserGroupId));
      //   }
      //}

      private string _propLogin = string.Empty;

      [DataMember]
      /// <summary> Login </summary>
      public string PropLogin
      {
         get { return _propLogin; }
         private set 
         { 
            _propLogin = value;
            ModifiedProperties.Add(nameof(PropLogin));
         }

      }

      private string _propFirstName = string.Empty;
      /// <summary> First name </summary>
      [DataMember]
      public string PropFirstName 
      {
         get { return _propFirstName; }
         private set
         {
            _propFirstName = value;
            ModifiedProperties.Add(nameof(PropFirstName));
         }
      }

      private string _propLastName = string.Empty;
      /// <summary> Last name </summary>
      [DataMember]
      public string PropLastName 
      {
         get { return _propLastName; }
         private set
         {
            _propLastName = value;
            ModifiedProperties.Add(nameof(PropLastName));
         }
      }

      private string _propEMailAdress = string.Empty;
      /// <summary> Mail adress </summary>
      [DataMember]
      public string PropEmailAdress
      {
         get { return _propEMailAdress; }
         private set
         {
            _propEMailAdress = value;
            ModifiedProperties.Add(nameof(PropEmailAdress));
         }
      }

      #endregion IUserObject

      }
}