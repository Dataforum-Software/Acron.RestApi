﻿using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiProviderObject : RestApiProviderBaseObject, IProviderObject
   {
      #region cTor

      public RestApiProviderObject()
         : base(BaseObjectDefines.RestObjectTypeCode.Provider)
      { }

      public RestApiProviderObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropProviderId = 1;
         this.PropIdDriver = ProviderObjectDefines.DrvSimulate;
         this.PropReadingInterval = 3600;
      }

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IProviderObject iProv = baseObject as IProviderObject;

         this.PropIdDriver = iProv.PropIdDriver;

         this.PropDriverParameter1 = iProv.PropDriverParameter1;
         this.PropDriverParameter2 = iProv.PropDriverParameter2;
         this.PropDriverParameter3 = iProv.PropDriverParameter3;
         this.PropDriverParameter4 = iProv.PropDriverParameter4;
         this.PropDriverParameter5 = iProv.PropDriverParameter5;

         if (string.IsNullOrEmpty(this.PropDriverParameter5))
            this.PropDriverParameter5 = null;

         this.PropReadingInterval = iProv.PropReadingInterval;
         this.PropStartupDelayTime = iProv.PropStartupDelayTime;

         this.PropTestMode = iProv.PropTestMode;

         this.PropAlwaysOnTop = iProv.PropAlwaysOnTop;

         this.PropAlertAutoGeneration = iProv.PropAlertAutoGeneration;
         this.PropAlertRuleGroupName = iProv.PropAlertRuleGroupName;
         this.PropAlertRuleVarName = iProv.PropAlertRuleVarName;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreateProviderObjectRequestResource iProv = baseObject as ICreateProviderObjectRequestResource;

         this.PropIdDriver = iProv.PropIdDriver;

         this.PropDriverParameter1 = iProv.PropDriverParameter1;
         this.PropDriverParameter2 = iProv.PropDriverParameter2;
         this.PropDriverParameter3 = iProv.PropDriverParameter3;
         this.PropDriverParameter4 = iProv.PropDriverParameter4;
         this.PropDriverParameter5 = iProv.PropDriverParameter5;

         if (string.IsNullOrEmpty(this.PropDriverParameter5))
            this.PropDriverParameter5 = null;

         this.PropReadingInterval = iProv.PropReadingInterval;
         this.PropStartupDelayTime = iProv.PropStartupDelayTime;

         this.PropTestMode = iProv.PropTestMode;

         this.PropAlwaysOnTop = iProv.PropAlwaysOnTop;

         this.PropAlertAutoGeneration = iProv.PropAlertAutoGeneration;
         this.PropAlertRuleGroupName = iProv.PropAlertRuleGroupName;
         this.PropAlertRuleVarName = iProv.PropAlertRuleVarName;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdateProviderObjectRequestResource iProv = baseObject as IUpdateProviderObjectRequestResource;

         this.PropIdDriver = iProv.PropIdDriver;

         this.PropDriverParameter1 = iProv.PropDriverParameter1;
         this.PropDriverParameter2 = iProv.PropDriverParameter2;
         this.PropDriverParameter3 = iProv.PropDriverParameter3;
         this.PropDriverParameter4 = iProv.PropDriverParameter4;
         this.PropDriverParameter5 = iProv.PropDriverParameter5;

         if (string.IsNullOrEmpty(this.PropDriverParameter5))
            this.PropDriverParameter5 = null;

         this.PropReadingInterval = iProv.PropReadingInterval;
         this.PropStartupDelayTime = iProv.PropStartupDelayTime;

         this.PropTestMode = iProv.PropTestMode;

         this.PropAlwaysOnTop = iProv.PropAlwaysOnTop;

         this.PropAlertAutoGeneration = iProv.PropAlertAutoGeneration;
         this.PropAlertRuleGroupName = iProv.PropAlertRuleGroupName;
         this.PropAlertRuleVarName = iProv.PropAlertRuleVarName;

         return true;
      }

      #region IProviderObject

      private int _propIdDriver;

      [DataMember]
      public int PropIdDriver
      {
         get { return _propIdDriver; }
         set 
         {
            _propIdDriver = value;
            ModifiedProperties.Add(nameof(PropIdDriver));
         }
      }

      private string _propDriverParameter1;

      [DataMember]
      [DefaultValue("")]
      public string PropDriverParameter1
      {
         get { return _propDriverParameter1; }
         set
         {
            _propDriverParameter1 = value;
            ModifiedProperties.Add(nameof(PropDriverParameter1));
         }
      }

      private string _propDriverParameter2;

      [DataMember]
      [DefaultValue("")]
      public string PropDriverParameter2
      {
         get { return _propDriverParameter2; }
         set
         {
            _propDriverParameter2 = value;
            ModifiedProperties.Add(nameof(PropDriverParameter2));
         }
      }

      private string _propDriverParameter3;
      [DataMember]
      [DefaultValue("")]
      public string PropDriverParameter3
      {
         get { return _propDriverParameter3; }
         set
         {
            _propDriverParameter3 = value;
            ModifiedProperties.Add(nameof(PropDriverParameter3));
         }
      }

      private string _propDriverParameter4;
      [DataMember]
      [DefaultValue("")]
      public string PropDriverParameter4
      {
         get { return _propDriverParameter4; }
         set
         {
            _propDriverParameter4 = value;
            ModifiedProperties.Add(nameof(PropDriverParameter4));
         }
      }

      private string _propDriverParameter5;
      [DataMember]
      [DefaultValue("")]
      public string PropDriverParameter5
      {
         get { return _propDriverParameter5; }
         set
         {
            _propDriverParameter5 = value;
            ModifiedProperties.Add(nameof(PropDriverParameter5));
         }
      }

      private int _propReadingInterval;
      [DataMember]
      [DefaultValue(3600)]
      public int PropReadingInterval
      {
         get { return _propReadingInterval; }
         set
         {
            _propReadingInterval = value;
            ModifiedProperties.Add(nameof(PropReadingInterval));
         }
      }

      private int _propStartupDelayTime;
      [DataMember]
      [DefaultValue(0)]
      public int PropStartupDelayTime
      {
         get { return _propStartupDelayTime; }
         set
         {
            _propStartupDelayTime = value;
            ModifiedProperties.Add(nameof(PropStartupDelayTime));
         }
      }

      private bool _propTestMode;
      [DataMember]
      [DefaultValue(false)]
      public bool PropTestMode
      {
         get { return _propTestMode; }
         set
         {
            _propTestMode = value;
            ModifiedProperties.Add(nameof(PropTestMode));
         }
      }

      private bool _propAlwaysOnTop;
      [DataMember]
      [DefaultValue(false)]
      public bool PropAlwaysOnTop
      {
         get { return _propAlwaysOnTop; }
         set
         {
            _propAlwaysOnTop = value;
            ModifiedProperties.Add(nameof(PropAlwaysOnTop));
         }
      }

      private bool _propAlertAutoGeneration;
      [DataMember]
      [DefaultValue(false)]
      public bool PropAlertAutoGeneration
      {
         get { return _propAlertAutoGeneration; }
         set
         {
            _propAlertAutoGeneration = value;
            ModifiedProperties.Add(nameof(PropAlertAutoGeneration));
         }
      }

      private string _propAlertRuleGroupName;
      [DataMember]
      [DefaultValue("")]
      [MaxLength(255)]
      public string PropAlertRuleGroupName
      {
         get { return _propAlertRuleGroupName; }
         set
         {
            _propAlertRuleGroupName = value;
            ModifiedProperties.Add(nameof(PropAlertRuleGroupName));
         }
      }

      private string _propAlertRuleVarName;
      [DataMember]
      [DefaultValue("")]
      [MaxLength(255)]
      public string PropAlertRuleVarName
      {
         get { return _propAlertRuleVarName; }
         set
         {
            _propAlertRuleVarName = value;
            ModifiedProperties.Add(nameof(PropAlertRuleVarName));
         }
      }

      #endregion IProviderObject

   }
}
