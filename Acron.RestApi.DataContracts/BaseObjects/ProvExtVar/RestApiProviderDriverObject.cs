using Acron.RestApi.Interfaces.BaseObjects;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiProviderDriverObject : RestApiBaseObject, IProviderDriverObject
   {
      #region cTor

      public RestApiProviderDriverObject()
         : base(BaseObjectDefines.RestObjectTypeCode.ProviderDriver)
      { }

      public RestApiProviderDriverObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IProviderDriverObject iProvDrv = baseObject as IProviderDriverObject;

         this._propVersion = iProvDrv.PropVersion;
         this._propDescription = iProvDrv.PropDescription;

         this._propParamText1 = iProvDrv.PropParam1Text;
         this._propParamDefault1 = iProvDrv.PropParam1Default;

         this._propParamText2 = iProvDrv.PropParam2Text;
         this._propParamDefault2 = iProvDrv.PropParam2Default;

         this._propParamText3 = iProvDrv.PropParam3Text;
         this._propParamDefault3 = iProvDrv.PropParam3Default;

         this._propParamText4 = iProvDrv.PropParam4Text;
         this._propParamDefault4 = iProvDrv.PropParam4Default;

         this._propReadingInterval = iProvDrv.PropReadingInterval;
         this._propStartupDelayTime = iProvDrv.PropStartupDelayTime;

         this._propConnectionType = iProvDrv.PropConnectionType;
         this._propTransferType = iProvDrv.PropTransferType;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         //IProviderDriverObject iProvDrv = baseObject as IProviderDriverObject;

         //this._propVersion = iProvDrv.PropVersion;
         //this._propDescription = iProvDrv.PropDescription;

         //this._propParamText1 = iProvDrv.PropParam1Text;
         //this._propParamDefault1 = iProvDrv.PropParam1Default;

         //this._propParamText2 = iProvDrv.PropParam2Text;
         //this._propParamDefault2 = iProvDrv.PropParam2Default;

         //this._propParamText3 = iProvDrv.PropParam3Text;
         //this._propParamDefault3 = iProvDrv.PropParam3Default;

         //this._propParamText4 = iProvDrv.PropParam4Text;
         //this._propParamDefault4 = iProvDrv.PropParam4Default;

         //this._propReadingInterval = iProvDrv.PropReadingInterval;
         //this._propStartupDelayTime = iProvDrv.PropStartupDelayTime;

         //this._propConnectionType = iProvDrv.PropConnectionType;
         //this._propTransferType = iProvDrv.PropTransferType;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         //IUpdateProviderDriverObject iProvDrv = baseObject as IProviderDriverObject;

         //this._propVersion = iProvDrv.PropVersion;
         //this._propDescription = iProvDrv.PropDescription;

         //this._propParamText1 = iProvDrv.PropParam1Text;
         //this._propParamDefault1 = iProvDrv.PropParam1Default;

         //this._propParamText2 = iProvDrv.PropParam2Text;
         //this._propParamDefault2 = iProvDrv.PropParam2Default;

         //this._propParamText3 = iProvDrv.PropParam3Text;
         //this._propParamDefault3 = iProvDrv.PropParam3Default;

         //this._propParamText4 = iProvDrv.PropParam4Text;
         //this._propParamDefault4 = iProvDrv.PropParam4Default;

         //this._propReadingInterval = iProvDrv.PropReadingInterval;
         //this._propStartupDelayTime = iProvDrv.PropStartupDelayTime;

         //this._propConnectionType = iProvDrv.PropConnectionType;
         //this._propTransferType = iProvDrv.PropTransferType;

         return true;
      }

      #region IProviderDriverObject

      private string _propVersion = string.Empty;
      [DataMember]
      [DefaultValue("")]
      public string PropVersion
      {
         get
         {
            return _propVersion;
         }
      }

      private string _propDescription = string.Empty;
      [DataMember]
      [DefaultValue("")]
      public string PropDescription
      {
         get
         {
            return _propDescription;
         }
      }

      private string _propParamText1 = string.Empty;
      [DataMember]
      [DefaultValue("")]
      public string PropParam1Text
      {
         get
         {
            return _propParamText1;
         }
      }

      private string _propParamDefault1 = string.Empty;
      [DataMember]
      [DefaultValue("")]
      public string PropParam1Default
      {
         get
         {
            return _propParamDefault1;
         }
      }

      private string _propParamText2 = string.Empty;
      [DataMember]
      [DefaultValue("")]
      public string PropParam2Text
      {
         get
         {
            return _propParamText2;
         }
      }

      private string _propParamDefault2 = string.Empty;
      [DataMember]
      [DefaultValue("")]
      public string PropParam2Default
      {
         get
         {
            return _propParamDefault2;
         }
      }

      private string _propParamText3 = string.Empty;
      [DataMember]
      [DefaultValue("")]
      public string PropParam3Text
      {
         get
         {
            return _propParamText3;
         }
      }

      private string _propParamDefault3 = string.Empty;
      [DataMember]
      [DefaultValue("")]
      public string PropParam3Default
      {
         get
         {
            return _propParamDefault3;
         }
      }

      private string _propParamText4 = string.Empty;
      [DataMember]
      [DefaultValue("")]
      public string PropParam4Text
      {
         get
         {
            return _propParamText4;
         }
      }

      private string _propParamDefault4 = string.Empty;
      [DataMember]
      [DefaultValue("")]
      public string PropParam4Default
      {
         get
         {
            return _propParamDefault4;
         }
      }

      private int _propReadingInterval = 0;
      [DataMember]
      public int PropReadingInterval
      {
         get
         {
            return _propReadingInterval;
         }
      }

      private int _propStartupDelayTime = 0;
      [DataMember]
      public int PropStartupDelayTime
      {
         get
         {
            return _propStartupDelayTime;
         }
      }

      private char _propConnectionType = '?';
      [DataMember]
      public char PropConnectionType
      {
         get
         {
            return _propConnectionType;
         }
      }

      private char _propTransferType = '?';
      [DataMember]
      public char PropTransferType
      {
         get
         {
            return _propTransferType;
         }
      }

      #endregion IProviderDriverObject
   }
}