﻿using Acron.RestApi.BaseObjects;
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
   public class UpdatePvAutoObjectRequestResource : UpdatePvManualAutoBaseObjectRequestResource, IUpdatePvAutoObjectRequestResource
   {
      #region cTor

      public UpdatePvAutoObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.VgAuto)
      { }

      #endregion cTor

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropFormulaEdit = "1";

         this.PropRepValMinLimit = BaseObjectDefines.NO_VALID;
         this.PropRepValMinLimitType = PvAutoDefines.ReplacementType.FixValue;
         this.PropRepValMaxLimit = BaseObjectDefines.NO_VALID;
         this.PropRepValMaxLimitType = PvAutoDefines.ReplacementType.FixValue;
         this.PropRepValLoss = BaseObjectDefines.NO_VALID;
         this.PropRepValLossType = PvAutoDefines.ReplacementType.FixValue;

         this.PropCompressionIntervalMethod = PvAutoDefines.CompIntervalMethod.AverageWeighted;
         this.PropCompressionDayMethod = PvAutoDefines.CompDayMethod.Average;
         this.PropCompressionMonthMethod = PvAutoDefines.CompMonthMethod.Average;
         this.PropCompressionYearMethod = PvAutoDefines.CompYearMethod.Average;
      }


      #region IVgAutoObject

      #region General

      private string _propFormulaEdit;
      /// <summary> Formel der VG </summary>
      [DataMember]
      [DefaultValue("1")]
      [MaxLength(2498)]
      public string PropFormulaEdit
      {
         get { return _propFormulaEdit; }
         set
         {
            _propFormulaEdit = value;
            ModifiedProperties.Add(nameof(PropFormulaEdit));
         }
      }

      private bool _propReplacementMinLimit;
      /// <summary>Ersatzwert bei Messwertunterschreitung - Aktiv ?</summary>
      [DataMember]
      [DefaultValue(false)]
      public bool PropReplacementMinLimit
      {
         get { return _propReplacementMinLimit; }
         set
         {
            _propReplacementMinLimit = value;
            ModifiedProperties.Add(nameof(PropReplacementMinLimit));
         }
      }


      private double _propRepValMinLimit;
      /// <summary>Ersatzwert bei Messwertunterschreitung</summary>
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropRepValMinLimit
      {
         get { return _propRepValMinLimit; }
         set
         {
            _propRepValMinLimit = value;
            ModifiedProperties.Add(nameof(PropRepValMinLimit));
         }
      }


      private PvAutoDefines.ReplacementType _propRepValMinLimitType;
      /// <summary>Ersatzwert bei Messwertunterschreitung - Wertetyp</summary>
      [DataMember]
      [DefaultValue(0)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvAutoDefines.ReplacementType PropRepValMinLimitType
      {
         get { return _propRepValMinLimitType; }
         set
         {
            _propRepValMinLimitType = value;
            ModifiedProperties.Add(nameof(PropRepValMinLimitType));
         }
      }


      private bool _propReplacementMaxLimit;
      /// <summary>Ersatzwert bei Messwertüberschreitung - Aktiv ?</summary>
      [DataMember]
      [DefaultValue(false)]
      public bool PropReplacementMaxLimit
      {
         get { return _propReplacementMaxLimit; }
         set
         {
            _propReplacementMaxLimit = value;
            ModifiedProperties.Add(nameof(PropReplacementMaxLimit));
         }
      }


      private double _propRepValMaxLimit;
      /// <summary>Ersatzwert bei Messwertüberschreitung</summary>
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropRepValMaxLimit
      {
         get { return _propRepValMaxLimit; }
         set
         {
            _propRepValMaxLimit = value;
            ModifiedProperties.Add(nameof(PropRepValMaxLimit));
         }
      }


      private PvAutoDefines.ReplacementType _propRepValMaxLimitType;
      /// <summary>Ersatzwert bei Messwertüberschreitung - Wertetyp</summary>
      [DataMember]
      [DefaultValue(0)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvAutoDefines.ReplacementType PropRepValMaxLimitType
      {
         get { return _propRepValMaxLimitType; }
         set
         {
            _propRepValMaxLimitType = value;
            ModifiedProperties.Add(nameof(PropRepValMaxLimitType));
         }
      }


      private bool _propReplacementLoss;
      /// <summary>Ersatzwert bei Ausfall - Aktiv ?</summary>
      [DataMember]
      [DefaultValue(false)]
      public bool PropReplacementLoss
      {
         get { return _propReplacementLoss; }
         set
         {
            _propReplacementLoss = value;
            ModifiedProperties.Add(nameof(PropReplacementLoss));
         }
      }


      private double _propRepValLoss;
      /// <summary>Ersatzwert bei Ausfall</summary>
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropRepValLoss
      {
         get { return _propRepValLoss; }
         set
         {
            _propRepValLoss = value;
            ModifiedProperties.Add(nameof(PropRepValLoss));
         }
      }


      private PvAutoDefines.ReplacementType _propRepValLossType;
      /// <summary>Ersatzwert bei Ausfall - Wertetyp</summary>
      [DataMember]
      [DefaultValue(0)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvAutoDefines.ReplacementType PropRepValLossType
      {
         get { return _propRepValLossType; }
         set
         {
            _propRepValLossType = value;
            ModifiedProperties.Add(nameof(PropRepValLossType));
         }
      }


      #endregion General

      #region Interval

      private PvAutoDefines.CompIntervalMethod _propCompressionIntervalMethod;
      /// <summary> Intervallkompression Methode</summary>
      [DataMember]
      [DefaultValue(24)] // Average Weighted
      [JsonConverter(typeof(StringEnumConverter))]
      public PvAutoDefines.CompIntervalMethod PropCompressionIntervalMethod
      {
         get { return _propCompressionIntervalMethod; }
         set
         {
            _propCompressionIntervalMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionIntervalMethod));
         }
      }


      #endregion Interval

      #region Tag

      private PvAutoDefines.CompDayMethod _propCompressionDayMethod;
      /// <summary> Tageskompression Methode</summary>
      [DataMember]
      [DefaultValue(7)] // Average
      [JsonConverter(typeof(StringEnumConverter))]
      public PvAutoDefines.CompDayMethod PropCompressionDayMethod
      {
         get { return _propCompressionDayMethod; }
         set
         {
            _propCompressionDayMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionDayMethod));
         }
      }

      #endregion Tag

      #region Monat

      private PvAutoDefines.CompMonthMethod _propCompressionMonthMethod;
      /// <summary> Monatskompression Methode</summary>
      [DataMember]
      [DefaultValue(7)] // Average
      [JsonConverter(typeof(StringEnumConverter))]
      public PvAutoDefines.CompMonthMethod PropCompressionMonthMethod
      {
         get { return _propCompressionMonthMethod; }
         set
         {
            _propCompressionMonthMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionMonthMethod));
         }
      }

      #endregion Monat

      #region Jahr

      private PvAutoDefines.CompYearMethod _propCompressionYearMethod;
      /// <summary> Jahreskompression Methode</summary>
      [DataMember]
      [DefaultValue(7)] // Average
      [JsonConverter(typeof(StringEnumConverter))]
      public PvAutoDefines.CompYearMethod PropCompressionYearMethod
      {
         get { return _propCompressionYearMethod; }
         set
         {
            _propCompressionYearMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionYearMethod));
         }
      }

      #endregion Jahr

      #endregion IVgAutoObject
   }
}
