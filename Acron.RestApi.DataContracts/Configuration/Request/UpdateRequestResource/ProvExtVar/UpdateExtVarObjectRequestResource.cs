using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.Serialization;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdateExtVarObjectRequestResource : UpdateBaseObjectRequestResource, IUpdateExtVarObjectRequestResource
   {
      #region cTor

      public UpdateExtVarObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.ExtVar)
      { }

      #endregion cTor

      public void SetProviderId(int providerId)
      {
         this._propIdProvider = providerId;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropDataType = ExtVarDefines.DbpDataType.DbpSint4;

         this.PropPeriodOfValidity = 3600;
         this.PropCyclicInterval = 3600;

         this.PropGeneralValueFrom = BaseObjectDefines.NO_VALID;
         this.PropGeneralValueTo = BaseObjectDefines.NO_VALID;
         this.PropDeltaEventValueFrom1 = BaseObjectDefines.NO_VALID;
         this.PropDeltaEventValueTo1 = BaseObjectDefines.NO_VALID;
         this.PropDeltaEventValueChange1 = BaseObjectDefines.NO_VALID;
         this.PropDeltaEventValueFrom2 = BaseObjectDefines.NO_VALID;
         this.PropDeltaEventValueTo2 = BaseObjectDefines.NO_VALID;
         this.PropDeltaEventValueChange2 = BaseObjectDefines.NO_VALID;
         this.PropDeltaEventValueFrom3 = BaseObjectDefines.NO_VALID;
         this.PropDeltaEventValueTo3 = BaseObjectDefines.NO_VALID;
         this.PropDeltaEventValueChange3 = BaseObjectDefines.NO_VALID;

         this.PropServiceUnit = ExtVarDefines.ServiceUnit.Seconds;
         this.PropServiceOverflowValue = BaseObjectDefines.NO_VALID;
      }

      #region IExtVarObject

      [DataMember]
      [MinLength(1)]
      [MaxLength(256)]
      [Required]
      public override string ShortName
      {
         get { return base.ShortName; }
         set { base.ShortName = value; }
      }

      [DataMember]
      [MaxLength(256)]
      public override string LongName
      {
         get { return base.LongName; }
         set { base.LongName = value; }
      }

      private string _propComment;
      [DataMember]
      [DefaultValue("")]
      public string PropComment
      {
         get { return _propComment; }
         set
         {
            _propComment = value;
            ModifiedProperties.Add(nameof(PropComment));
         }
      }

      private int _propIdProvider;
      [DataMember]
      public int PropIdProvider
      {
         get
         {
            return _propIdProvider;
         }
         //set
         //{
         //   _propIdProvider = value;
         //   ModifiedProperties.Add(nameof(PropIdProvider));
         //}
      }

      private int _propIdDependVar1;
      /// <summary>ID der abhängigen Externen Variablen 1</summary>
      [DataMember]
      [DefaultValue(0)]
      public int PropIdDependVar1
      {
         get { return _propIdDependVar1; }
         set
         {
            _propIdDependVar1 = value;
            ModifiedProperties.Add(nameof(PropIdDependVar1));
         }
      }

      private int _propIdDependVar2;
      /// <summary>ID der abhängigen Externen Variablen 2</summary>
      [DataMember]
      [DefaultValue(0)]
      public int PropIdDependVar2
      {
         get { return _propIdDependVar2; }
         set
         {
            _propIdDependVar2 = value;
            ModifiedProperties.Add(nameof(PropIdDependVar2));
         }
      }

      private int _propIdDependVar3;
      /// <summary>ID der abhängigen Externen Variablen 3</summary>
      [DataMember]
      [DefaultValue(0)]
      public int PropIdDependVar3
      {
         get { return _propIdDependVar3; }
         set
         {
            _propIdDependVar3 = value;
            ModifiedProperties.Add(nameof(PropIdDependVar3));
         }
      }

      private string _propConditionVar;
      /// <summary>Bedingungsvariable</summary>
      [DataMember]
      [DefaultValue("")]
      [MaxLength(256)]
      public string PropConditionVar
      {
         get { return _propConditionVar; }
         set
         {
            _propConditionVar = value;
            ModifiedProperties.Add(nameof(PropConditionVar));
         }
      }

      private string _propAcknowledgeVar;
      /// <summary>Bestätigungsvariable</summary>
      [DataMember]
      [DefaultValue("")]
      [MaxLength(256)]
      public string PropAcknowledgeVar
      {
         get { return _propAcknowledgeVar; }
         set
         {
            _propAcknowledgeVar = value;
            ModifiedProperties.Add(nameof(PropAcknowledgeVar));
         }
      }

      #region Measurement

      private bool _propMeasurementActive;
      [DataMember]
      [DefaultValue(false)]
      public bool PropMeasurementActive
      {
         get { return _propMeasurementActive; }
         set
         {
            _propMeasurementActive = value;
            ModifiedProperties.Add(nameof(PropMeasurementActive));
         }
      }

      private ExtVarDefines.MeasurementRecordingType _propMeasurementRecordingType;
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public ExtVarDefines.MeasurementRecordingType PropMeasurementRecordingType
      {
         get { return _propMeasurementRecordingType; }
         set
         {
            _propMeasurementRecordingType = value;
            ModifiedProperties.Add(nameof(PropMeasurementRecordingType));
         }
      }

      private bool _propCyclicMin;
      [DataMember]
      [DefaultValue(false)]
      public bool PropCyclicMin
      {
         get { return _propCyclicMin; }
         set
         {
            _propCyclicMin = value;
            ModifiedProperties.Add(nameof(PropCyclicMin));
         }
      }

      private bool _propCyclicMax;
      [DataMember]
      [DefaultValue(false)]
      public bool PropCyclicMax
      {
         get { return _propCyclicMax; }
         set
         {
            _propCyclicMax = value;
            ModifiedProperties.Add(nameof(PropCyclicMax));
         }
      }

      private ExtVarDefines.DbpDataType _propDataType;
      [DataMember]
      [DefaultValue(9)]
      [JsonConverter(typeof(StringEnumConverter))]
      public ExtVarDefines.DbpDataType PropDataType
      {
         get { return _propDataType; }
         set
         {
            _propDataType = value;
            ModifiedProperties.Add(nameof(PropDataType));
         }
      }

      private double _propGeneralValueFrom;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropGeneralValueFrom
      {
         get { return _propGeneralValueFrom; }
         set
         {
            _propGeneralValueFrom = value;
            ModifiedProperties.Add(nameof(PropGeneralValueFrom));
         }
      }

      private double _propGeneralValueTo;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropGeneralValueTo
      {
         get { return _propGeneralValueTo; }
         set
         {
            _propGeneralValueTo = value;
            ModifiedProperties.Add(nameof(PropGeneralValueTo));
         }
      }

      private int _propPeriodOfValidity;
      [DataMember]
      [DefaultValue(0)]
      public int PropPeriodOfValidity
      {
         get { return _propPeriodOfValidity; }
         set
         {
            _propPeriodOfValidity = value;
            ModifiedProperties.Add(nameof(PropPeriodOfValidity));
         }
      }

      private int _propCyclicInterval;
      [DataMember]
      [DefaultValue(3600)]
      public int PropCyclicInterval
      {
         get { return _propCyclicInterval; }
         set
         {
            _propCyclicInterval = value;
            ModifiedProperties.Add(nameof(PropCyclicInterval));
         }
      }

      #region Delta Event

      private bool _propDeltaEventActive1;
      [DataMember]
      [DefaultValue(false)]
      public bool PropDeltaEventActive1
      {
         get { return _propDeltaEventActive1; }
         set
         {
            _propDeltaEventActive1 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventActive1));
         }
      }

      private double _propDeltaEventValueFrom1;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropDeltaEventValueFrom1
      {
         get { return _propDeltaEventValueFrom1; }
         set
         {
            _propDeltaEventValueFrom1 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventValueFrom1));
         }
      }

      private double _propDeltaEventValueTo1;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropDeltaEventValueTo1
      {
         get { return _propDeltaEventValueTo1; }
         set
         {
            _propDeltaEventValueTo1 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventValueTo1));
         }
      }

      private double _propDeltaEventValueChange1;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropDeltaEventValueChange1
      {
         get { return _propDeltaEventValueChange1; }
         set
         {
            _propDeltaEventValueChange1 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventValueChange1));
         }
      }


      private bool _propDeltaEventActive2;
      [DataMember]
      [DefaultValue(false)]
      public bool PropDeltaEventActive2
      {
         get { return _propDeltaEventActive2; }
         set
         {
            _propDeltaEventActive2 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventActive2));
         }
      }

      private double _propDeltaEventValueFrom2;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropDeltaEventValueFrom2
      {
         get { return _propDeltaEventValueFrom2; }
         set
         {
            _propDeltaEventValueFrom2 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventValueFrom2));
         }
      }

      private double _propDeltaEventValueTo2;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropDeltaEventValueTo2
      {
         get { return _propDeltaEventValueTo2; }
         set
         {
            _propDeltaEventValueTo2 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventValueTo2));
         }
      }

      private double _propDeltaEventValueChange2;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropDeltaEventValueChange2
      {
         get { return _propDeltaEventValueChange2; }
         set
         {
            _propDeltaEventValueChange2 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventValueChange2));
         }
      }


      private bool _propDeltaEventActive3;
      [DataMember]
      [DefaultValue(false)]
      public bool PropDeltaEventActive3
      {
         get { return _propDeltaEventActive3; }
         set
         {
            _propDeltaEventActive3 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventActive3));
         }
      }

      private double _propDeltaEventValueFrom3;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropDeltaEventValueFrom3
      {
         get { return _propDeltaEventValueFrom3; }
         set
         {
            _propDeltaEventValueFrom3 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventValueFrom3));
         }
      }

      private double _propDeltaEventValueTo3;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropDeltaEventValueTo3
      {
         get { return _propDeltaEventValueTo3; }
         set
         {
            _propDeltaEventValueTo3 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventValueTo3));
         }
      }

      private double _propDeltaEventValueChange3;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropDeltaEventValueChange3
      {
         get { return _propDeltaEventValueChange3; }
         set
         {
            _propDeltaEventValueChange3 = value;
            ModifiedProperties.Add(nameof(PropDeltaEventValueChange3));
         }
      }

      #endregion Delta Event

      #endregion Measurement

      #region Service

      private bool _propServiceActive;
      /// <summary>Instandhaltung aktiv</summary>
      [DataMember]
      [DefaultValue(false)]
      public bool PropServiceActive
      {
         get { return _propServiceActive; }
         set
         {
            _propServiceActive = value;
            ModifiedProperties.Add(nameof(PropServiceActive));
         }
      }

      // Bereich Instandhaltung

      private ExtVarDefines.ServiceType _propServiceType;
      /// <summary>Inst-Typ; 0 kein, 1 Binär, 2 Laufzeit, 3 Schaltspiele </summary>
      [DataMember]
      [DefaultValue(0)]
      [JsonConverter(typeof(StringEnumConverter))]
      public ExtVarDefines.ServiceType PropServiceType
      {
         get { return _propServiceType; }
         set
         {
            _propServiceType = value;
            ModifiedProperties.Add(nameof(PropServiceType));
         }
      }

      private ExtVarDefines.ServiceUnit _propServiceUnit;
      /// <summary>Einheit der Instandhaltungsvariablen</summary>
//      [DefaultValue(ExtVarDefines.ServiceUnit.Seconds)]
      [DataMember]
      [DefaultValue(0)]
      [JsonConverter(typeof(StringEnumConverter))]
      public ExtVarDefines.ServiceUnit PropServiceUnit
      {
         get { return _propServiceUnit; }
         set
         {
            _propServiceUnit = value;
            ModifiedProperties.Add(nameof(PropServiceUnit));
         }
      }

      private double _propServiceOverflowValue;
      /// <summary>Überlaufwert des Instandhaltungszählers</summary>             
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropServiceOverflowValue
      {
         get { return _propServiceOverflowValue; }
         set
         {
            _propServiceOverflowValue = value;
            ModifiedProperties.Add(nameof(PropServiceOverflowValue));
         }
      }

      #endregion Service

      #endregion IExtVarObject

   }
}
