﻿using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreatePvManualAutoBaseObjectRequestResource : CreatePvBaseObjectRequestResource, ICreatePvManualAutoBaseObjectRequestResource
   {
      #region cTor

      public CreatePvManualAutoBaseObjectRequestResource(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      #endregion cTor

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         // NO_VALID ist nicht gültig für Hand- und Auto-PVs
         this.PropMvalMin = -500.0f;
         this.PropMvalMax = 25000.0f;

         this.PropProMethod = PvManualAutoBaseDefines.CompMethodBase.None;
         this.PropProOverflow = BaseObjectDefines.NO_VALID;
         this.PropProDifferenceHandling = PvManualAutoBaseDefines.ProDifferenceHandling.All;
         this.PropProHysteresis = BaseObjectDefines.NO_VALID;
         this.PropProValidDifference = BaseObjectDefines.NO_VALID;
      }

      #region IPvManualAutoBaseObject

      private bool _propUseMilliseconds;
      [DataMember]
      [DefaultValue(false)]
      public bool PropUseMilliseconds
      {
         get { return _propUseMilliseconds; }
         set
         {
            _propUseMilliseconds = value;
            ModifiedProperties.Add(nameof(PropUseMilliseconds));
         }
      }

      private bool _propValueReAssess;
      [DataMember]
      [DefaultValue(false)]
      public bool PropValueReAssess
      {
         get { return _propValueReAssess; }
         set
         {
            _propValueReAssess = value;
            ModifiedProperties.Add(nameof(PropValueReAssess));
         }
      }

      private bool _propValueFillUp;
      [DataMember]
      [DefaultValue(false)]
      public bool PropValueFillUp
      {
         get { return _propValueFillUp; }
         set
         {
            _propValueFillUp = value;
            ModifiedProperties.Add(nameof(PropValueFillUp));
         }
      }

      private bool _propCounterManagement;
      [DataMember]
      [DefaultValue(false)]
      public bool PropCounterManagement
      {
         get { return _propCounterManagement; }
         set
         {
            _propCounterManagement = value;
            ModifiedProperties.Add(nameof(PropCounterManagement));
         }
      }

      private double _propMvalMin;
      [DataMember]
      [DefaultValue(-500.0)]
      public double PropMvalMin
      {
         get { return _propMvalMin; }
         set
         {
            _propMvalMin = value;
            ModifiedProperties.Add(nameof(PropMvalMin));
         }
      }

      private double _propMvalMax;
      [DataMember]
      [DefaultValue(25000.0)]
      public double PropMvalMax
      {
         get { return _propMvalMax; }
         set
         {
            _propMvalMax = value;
            ModifiedProperties.Add(nameof(PropMvalMax));
         }
      }

      private PvManualAutoBaseDefines.CompMethodBase _propProMethod;
      [DataMember]
      [DefaultValue(PvManualAutoBaseDefines.CompMethodBase.None)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvManualAutoBaseDefines.CompMethodBase PropProMethod
      {
         get { return _propProMethod; }
         set
         {
            _propProMethod = value;
            ModifiedProperties.Add(nameof(PropProMethod));
         }
      }

      private double _propProOverflow;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropProOverflow
      {
         get { return _propProOverflow; }
         set
         {
            _propProOverflow = value;
            ModifiedProperties.Add(nameof(PropProOverflow));
         }
      }

      private bool _propProPositiveDifference;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProPositiveDifference
      {
         get { return _propProPositiveDifference; }
         set
         {
            _propProPositiveDifference = value;
            ModifiedProperties.Add(nameof(PropProPositiveDifference));
         }
      }

      private PvManualAutoBaseDefines.ProDifferenceHandling _propProDifferenceHandling;
      [DataMember]
      [DefaultValue(PvManualAutoBaseDefines.ProDifferenceHandling.All)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvManualAutoBaseDefines.ProDifferenceHandling PropProDifferenceHandling
      {
         get { return _propProDifferenceHandling; }
         set
         {
            _propProDifferenceHandling = value;
            ModifiedProperties.Add(nameof(PropProDifferenceHandling));
         }
      }

      private double _propProHysteresis;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropProHysteresis
      {
         get { return _propProHysteresis; }
         set
         {
            _propProHysteresis = value;
            ModifiedProperties.Add(nameof(PropProHysteresis));
         }
      }

      private double _propProValidDifference;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropProValidDifference
      {
         get { return _propProValidDifference; }
         set
         {
            _propProValidDifference = value;
            ModifiedProperties.Add(nameof(PropProValidDifference));
         }
      }

      #endregion IPvManualAutoBaseObject

   }
}
