using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.Serialization;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdatePvBaseObjectRequestResource : UpdateBaseObjectRequestResource, IUpdatePvBaseObjectRequestResource
   {
      #region cTor

      public UpdatePvBaseObjectRequestResource(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      #endregion cTor

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropFormatVal = PvBaseDefines.ValueFormat.Numerical;
         this.PropFormatTime = PvBaseDefines.TimeFormat.DayMonthYear;
         this.PropGvalMin = BaseObjectDefines.NO_VALID;
         this.PropGvalMax = BaseObjectDefines.NO_VALID;

         this.PropCompressionIntervalPercentil = BaseObjectDefines.NO_VALID;
         this.PropCompressionIntervalRangeFrom = BaseObjectDefines.NO_VALID;
         this.PropCompressionIntervalRangeTo = BaseObjectDefines.NO_VALID;
         this.PropCompressionIntervalUsedIntervals = 0;

         this.PropCompressionDayUsedInterval = 2;
         this.PropCompressionDayPercentil = BaseObjectDefines.NO_VALID;
         this.PropCompressionDayRangeFrom = BaseObjectDefines.NO_VALID;
         this.PropCompressionDayRangeTo = BaseObjectDefines.NO_VALID;

         this.PropCompressionMonthPercentil = BaseObjectDefines.NO_VALID;
         this.PropCompressionMonthRangeFrom = BaseObjectDefines.NO_VALID;
         this.PropCompressionMonthRangeTo = BaseObjectDefines.NO_VALID;

         this.PropCompressionYearPercentil = BaseObjectDefines.NO_VALID;
         this.PropCompressionYearRangeFrom = BaseObjectDefines.NO_VALID;
         this.PropCompressionYearRangeTo = BaseObjectDefines.NO_VALID;

         // Mindestens eines der Providing-Flags MUSS gesetzt sein
         this.PropProvidingValue = true;

         this.PropProvidingDialogDay = true;
         this.PropProvidingDialogMonth = true;
         this.PropProvidingDialogYear = true;

         // Den Rest sauber initialisieren
         this.PropFloatingDayValue = 0;

         this.PropProvidingSum = false;
         this.PropProvidingMinMax = false;
         this.PropProvidingSDeviation = false;
         this.PropProvidingPercentil = false;
         this.PropProvidingMDays = false;
         this.PropProvidingFloatDayval = false;
         this.PropProvidingWWW = false;
         this.PropProvidingLimits = false;
         this.PropProvidingCoding = false;
         this.PropProvidingMultiserver = false;
         this.PropProvidingOpcDde = false;

         this.PropProvidingReleased = false;
         this.PropProvidingValKeys = false;

         this.PropValKeys = new Dictionary<double, string>();

         this.PropDifferentUnitAndLimit = false;
         this.PropQuitValChanges = 0;
      }

      #region IPvBaseObject

      [DataMember]
      [DefaultValue("")]
      [MinLength(1)]
      [MaxLength(60)]
      public override string ShortName
      {
         get => base.ShortName;
         set => base.ShortName = value;
      }

      [DataMember]
      [DefaultValue("")]
      [MinLength(1)]
      [MaxLength(96)]
      public override string LongName
      {
         get => base.LongName;
         set => base.LongName = value;
      }

      private string _propKey;
      [DataMember]
      [DefaultValue("")]
      public string PropKey
      {
         get { return _propKey; }
         set
         {
            _propKey = value;
            ModifiedProperties.Add(nameof(PropKey));
         }
      }

      private PvBaseDefines.ValueFormat _propFormatVal;
      [DataMember]
      [DefaultValue(0)]
      [Range(0, 2)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.ValueFormat PropFormatVal
      {
         get { return _propFormatVal; }
         set
         {
            _propFormatVal = value;
            ModifiedProperties.Add(nameof(PropFormatVal));
         }
      }

      private PvBaseDefines.TimeFormat _propFormatTime;
      [DataMember]
      [DefaultValue(PvBaseDefines.TimeFormat.DayMonthYear)]
      [Range(0, 2)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.TimeFormat PropFormatTime
      {
         get { return _propFormatTime; }
         set
         {
            _propFormatTime = value;
            ModifiedProperties.Add(nameof(PropFormatTime));
         }
      }

      private int _propNk;
      [DataMember]
      [DefaultValue(0)]
      [Range(-9, 9)]
      public int PropNk
      {
         get { return _propNk; }
         set
         {
            _propNk = value;
            ModifiedProperties.Add(nameof(PropNk));
         }
      }

      private string _propUnitFormula;
      [DataMember]
      [DefaultValue("")]
      public string PropUnitFormula
      {
         get { return _propUnitFormula; }
         set
         {
            _propUnitFormula = value;
            ModifiedProperties.Add(nameof(PropUnitFormula));
         }
      }

      private string _propComment;
      [DataMember]
      [DefaultValue("")]
      [MaxLength(1024)]
      public string PropComment
      {
         get { return _propComment; }
         set
         {
            _propComment = value;
            ModifiedProperties.Add(nameof(PropComment));
         }
      }

      private double _propGvalMin;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropGvalMin
      {
         get { return _propGvalMin; }
         set
         {
            _propGvalMin = value;
            ModifiedProperties.Add(nameof(PropGvalMin));
         }
      }

      private double _propGvalMax;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropGvalMax
      {
         get { return _propGvalMax; }
         set
         {
            _propGvalMax = value;
            ModifiedProperties.Add(nameof(PropGvalMax));
         }
      }

      private bool _propCalculateUnits;
      [DataMember]
      [DefaultValue(false)]
      public bool PropCalculateUnits
      {
         get { return _propCalculateUnits; }
         set
         {
            _propCalculateUnits = value;
            ModifiedProperties.Add(nameof(PropCalculateUnits));
         }
      }

      #region Interval

      private bool _propCompressionIntervalActive;
      [DataMember]
      [DefaultValue(false)]
      public bool PropCompressionIntervalActive
      {
         get { return _propCompressionIntervalActive; }
         set
         {
            _propCompressionIntervalActive = value;
            ModifiedProperties.Add(nameof(PropCompressionIntervalActive));
         }
      }

      private uint _propCompressionIntervalUsedIntervals;
      [DataMember]
      [DefaultValue(0)]
      public uint PropCompressionIntervalUsedIntervals
      {
         get { return _propCompressionIntervalUsedIntervals; }
         set
         {
            _propCompressionIntervalUsedIntervals = value;
            ModifiedProperties.Add(nameof(PropCompressionIntervalUsedIntervals));
         }
      }

      private double _propCompressionIntervalRangeFrom;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionIntervalRangeFrom
      {
         get { return _propCompressionIntervalRangeFrom; }
         set
         {
            _propCompressionIntervalRangeFrom = value;
            ModifiedProperties.Add(nameof(PropCompressionIntervalRangeFrom));
         }
      }

      private double _propCompressionIntervalRangeTo;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionIntervalRangeTo
      {
         get { return _propCompressionIntervalRangeTo; }
         set
         {
            _propCompressionIntervalRangeTo = value;
            ModifiedProperties.Add(nameof(PropCompressionIntervalRangeTo));
         }
      }

      private string _propCompressionIntervalUnitFormula;
      [DataMember]
      [DefaultValue("")]
      public string PropCompressionIntervalUnitFormula
      {
         get { return _propCompressionIntervalUnitFormula; }
         set
         {
            _propCompressionIntervalUnitFormula = value;
            ModifiedProperties.Add(nameof(PropCompressionIntervalUnitFormula));
         }
      }

      private int _propCompressionIntervalNk;
      [DataMember]
      [DefaultValue(0)]
      [Range(-9, 9)]
      public int PropCompressionIntervalNk
      {
         get { return _propCompressionIntervalNk; }
         set
         {
            _propCompressionIntervalNk = value;
            ModifiedProperties.Add(nameof(PropCompressionIntervalNk));
         }
      }

      private double _propCompressionIntervalPercentil;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionIntervalPercentil
      {
         get { return _propCompressionIntervalPercentil; }
         set
         {
            _propCompressionIntervalPercentil = value;
            ModifiedProperties.Add(nameof(PropCompressionIntervalPercentil));
         }
      }

      #endregion Interval

      #region Day

      private bool _propCompressionDayActive;
      [DataMember]
      [DefaultValue(false)]
      public bool PropCompressionDayActive
      {
         get { return _propCompressionDayActive; }
         set
         {
            _propCompressionDayActive = value;
            ModifiedProperties.Add(nameof(PropCompressionDayActive));
         }
      }

      private uint _propCompressionDayUsedInterval;
      [DataMember]
      [DefaultValue(2)]
      public uint PropCompressionDayUsedInterval
      {
         get { return _propCompressionDayUsedInterval; }
         set
         {
            _propCompressionDayUsedInterval = value;
            ModifiedProperties.Add(nameof(PropCompressionDayUsedInterval));
         }
      }

      private double _propCompressionDayRangeFrom;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionDayRangeFrom
      {
         get { return _propCompressionDayRangeFrom; }
         set
         {
            _propCompressionDayRangeFrom = value;
            ModifiedProperties.Add(nameof(PropCompressionDayRangeFrom));
         }
      }

      private double _propCompressionDayRangeTo;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionDayRangeTo
      {
         get { return _propCompressionDayRangeTo; }
         set
         {
            _propCompressionDayRangeTo = value;
            ModifiedProperties.Add(nameof(PropCompressionDayRangeTo));
         }
      }

      private string _propCompressionDayUnitFormula;
      [DataMember]
      [DefaultValue("")]
      public string PropCompressionDayUnitFormula
      {
         get { return _propCompressionDayUnitFormula; }
         set
         {
            _propCompressionDayUnitFormula = value;
            ModifiedProperties.Add(nameof(PropCompressionDayUnitFormula));
         }
      }

      private int _propCompressionDayNk;
      [DataMember]
      [DefaultValue(0)]
      [Range(-9, 9)]
      public int PropCompressionDayNk
      {
         get { return _propCompressionDayNk; }
         set
         {
            _propCompressionDayNk = value;
            ModifiedProperties.Add(nameof(PropCompressionDayNk));
         }
      }

      private double _propCompressionDayPercentil;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionDayPercentil
      {
         get { return _propCompressionDayPercentil; }
         set
         {
            _propCompressionDayPercentil = value;
            ModifiedProperties.Add(nameof(PropCompressionDayPercentil));
         }
      }

      #endregion Day

      #region Month

      private bool _propCompressionMonthActive;
      [DataMember]
      [DefaultValue(false)]
      public bool PropCompressionMonthActive
      {
         get { return _propCompressionMonthActive; }
         set
         {
            _propCompressionMonthActive = value;
            ModifiedProperties.Add(nameof(PropCompressionMonthActive));
         }
      }

      private double _propCompressionMonthRangeFrom;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionMonthRangeFrom
      {
         get { return _propCompressionMonthRangeFrom; }
         set
         {
            _propCompressionMonthRangeFrom = value;
            ModifiedProperties.Add(nameof(PropCompressionMonthRangeFrom));
         }
      }

      private double _propCompressionMonthRangeTo;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionMonthRangeTo
      {
         get { return _propCompressionMonthRangeTo; }
         set
         {
            _propCompressionMonthRangeTo = value;
            ModifiedProperties.Add(nameof(PropCompressionMonthRangeTo));
         }
      }

      private string _propCompressionMonthUnitFormula;
      [DataMember]
      [DefaultValue("")]
      public string PropCompressionMonthUnitFormula
      {
         get { return _propCompressionMonthUnitFormula; }
         set
         {
            _propCompressionMonthUnitFormula = value;
            ModifiedProperties.Add(nameof(PropCompressionMonthUnitFormula));
         }
      }

      private int _propCompressionMonthNk;
      [DataMember]
      [DefaultValue(0)]
      [Range(-9, 9)]
      public int PropCompressionMonthNk
      {
         get { return _propCompressionMonthNk; }
         set
         {
            _propCompressionMonthNk = value;
            ModifiedProperties.Add(nameof(PropCompressionMonthNk));
         }
      }

      private double _propCompressionMonthPercentil;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionMonthPercentil
      {
         get { return _propCompressionMonthPercentil; }
         set
         {
            _propCompressionMonthPercentil = value;
            ModifiedProperties.Add(nameof(PropCompressionMonthPercentil));
         }
      }

      #endregion Month

      #region Year

      private bool _propCompressionYearActive;
      [DataMember]
      [DefaultValue(false)]
      public bool PropCompressionYearActive
      {
         get { return _propCompressionYearActive; }
         set
         {
            _propCompressionYearActive = value;
            ModifiedProperties.Add(nameof(PropCompressionYearActive));
         }
      }

      private double _propCompressionYearRangeFrom;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionYearRangeFrom
      {
         get { return _propCompressionYearRangeFrom; }
         set
         {
            _propCompressionYearRangeFrom = value;
            ModifiedProperties.Add(nameof(PropCompressionYearRangeFrom));
         }
      }

      private double _propCompressionYearRangeTo;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionYearRangeTo
      {
         get { return _propCompressionYearRangeTo; }
         set
         {
            _propCompressionYearRangeTo = value;
            ModifiedProperties.Add(nameof(PropCompressionYearRangeTo));
         }
      }

      private string _propCompressionYearUnitFormula;
      [DataMember]
      [DefaultValue("")]
      public string PropCompressionYearUnitFormula
      {
         get { return _propCompressionYearUnitFormula; }
         set
         {
            _propCompressionYearUnitFormula = value;
            ModifiedProperties.Add(nameof(PropCompressionYearUnitFormula));
         }
      }

      private int _propCompressionYearNk;
      [DataMember]
      [DefaultValue(0)]
      [Range(-9, 9)]
      public int PropCompressionYearNk
      {
         get { return _propCompressionYearNk; }
         set
         {
            _propCompressionYearNk = value;
            ModifiedProperties.Add(nameof(PropCompressionYearNk));
         }
      }

      private double _propCompressionYearPercentil;
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionYearPercentil
      {
         get { return _propCompressionYearPercentil; }
         set
         {
            _propCompressionYearPercentil = value;
            ModifiedProperties.Add(nameof(PropCompressionYearPercentil));
         }
      }

      #endregion Year

      #region Providing

      private int _propFloatingDayValue;
      [DataMember]
      [DefaultValue(0)]
      [Range(0, 370)]
      public int PropFloatingDayValue
      {
         get { return _propFloatingDayValue; }
         set
         {
            _propFloatingDayValue = value;
            ModifiedProperties.Add(nameof(PropFloatingDayValue));
         }
      }

      private bool _propProvidingValue;
      [DataMember]
      [DefaultValue(true)]
      public bool PropProvidingValue
      {
         get { return _propProvidingValue; }
         set
         {
            _propProvidingValue = value;
            ModifiedProperties.Add(nameof(PropProvidingValue));
         }
      }

      private bool _propProvidingSum;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingSum
      {
         get { return _propProvidingSum; }
         set
         {
            _propProvidingSum = value;
            ModifiedProperties.Add(nameof(PropProvidingSum));
         }
      }

      private bool _propProvidingMinMax;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingMinMax
      {
         get { return _propProvidingMinMax; }
         set
         {
            _propProvidingMinMax = value;
            ModifiedProperties.Add(nameof(PropProvidingMinMax));
         }
      }

      private bool _propProvidingSDeviation;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingSDeviation
      {
         get { return _propProvidingSDeviation; }
         set
         {
            _propProvidingSDeviation = value;
            ModifiedProperties.Add(nameof(PropProvidingSDeviation));
         }
      }

      private bool _propProvidingPercentil;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingPercentil
      {
         get { return _propProvidingPercentil; }
         set
         {
            _propProvidingPercentil = value;
            ModifiedProperties.Add(nameof(PropProvidingPercentil));
         }
      }

      private bool _propProvidingMDays;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingMDays
      {
         get { return _propProvidingMDays; }
         set
         {
            _propProvidingMDays = value;
            ModifiedProperties.Add(nameof(PropProvidingMDays));
         }
      }

      private bool _propProvidingFloatDayval;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingFloatDayval
      {
         get { return _propProvidingFloatDayval; }
         set
         {
            _propProvidingFloatDayval = value;
            ModifiedProperties.Add(nameof(PropProvidingFloatDayval));
         }
      }

      private bool _propProvidingWWW;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingWWW
      {
         get { return _propProvidingWWW; }
         set
         {
            _propProvidingWWW = value;
            ModifiedProperties.Add(nameof(PropProvidingWWW));
         }
      }

      private bool _propProvidingLimits;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingLimits
      {
         get { return _propProvidingLimits; }
         set
         {
            _propProvidingLimits = value;
            ModifiedProperties.Add(nameof(PropProvidingLimits));
         }
      }

      private bool _propProvidingCoding;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingCoding
      {
         get { return _propProvidingCoding; }
         set
         {
            _propProvidingCoding = value;
            ModifiedProperties.Add(nameof(PropProvidingCoding));
         }
      }

      private bool _propProvidingMultiserver;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingMultiserver
      {
         get { return _propProvidingMultiserver; }
         set
         {
            _propProvidingMultiserver = value;
            ModifiedProperties.Add(nameof(PropProvidingMultiserver));
         }
      }

      private bool _propProvidingOpcDde;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingOpcDde
      {
         get { return _propProvidingOpcDde; }
         set
         {
            _propProvidingOpcDde = value;
            ModifiedProperties.Add(nameof(PropProvidingOpcDde));
         }
      }

      private bool _propProvidingDialogDay;
      [DataMember]
      [DefaultValue(true)]
      public bool PropProvidingDialogDay
      {
         get { return _propProvidingDialogDay; }
         set
         {
            _propProvidingDialogDay = value;
            ModifiedProperties.Add(nameof(PropProvidingDialogDay));
         }
      }

      private bool _propProvidingDialogMonth;
      [DataMember]
      [DefaultValue(true)]
      public bool PropProvidingDialogMonth
      {
         get { return _propProvidingDialogMonth; }
         set
         {
            _propProvidingDialogMonth = value;
            ModifiedProperties.Add(nameof(PropProvidingDialogMonth));
         }
      }

      private bool _propProvidingDialogYear;
      [DataMember]
      [DefaultValue(true)]
      public bool PropProvidingDialogYear
      {
         get { return _propProvidingDialogYear; }
         set
         {
            _propProvidingDialogYear = value;
            ModifiedProperties.Add(nameof(PropProvidingDialogYear));
         }
      }

      private bool _propProvidingReleased;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingReleased
      {
         get { return _propProvidingReleased; }
         set
         {
            _propProvidingReleased = value;
            ModifiedProperties.Add(nameof(PropProvidingReleased));
         }
      }

      private bool _propProvidingValKeys;
      [DataMember]
      [DefaultValue(false)]
      public bool PropProvidingValKeys
      {
         get { return _propProvidingValKeys; }
         set
         {
            _propProvidingValKeys = value;
            ModifiedProperties.Add(nameof(PropProvidingValKeys));
         }
      }

      #endregion Providing

      #region ValKeys

      private Dictionary<double, string> _propValKeys = new Dictionary<double, string>();

      [DataMember]
      public Dictionary<double, string> PropValKeys
      {
         get { return _propValKeys; }
         set
         {
            _propValKeys = value;
            ModifiedProperties.Add(nameof(PropValKeys));
         }
      }

      #endregion ValKeys

      private bool _propDifferentUnitAndLimit;
      [DataMember]
      [DefaultValue(false)]
      public bool PropDifferentUnitAndLimit
      {
         get { return _propDifferentUnitAndLimit; }
         set
         {
            _propDifferentUnitAndLimit = value;
            ModifiedProperties.Add(nameof(PropDifferentUnitAndLimit));
         }
      }

      private PvBaseDefines.QuitValueChanges _propQuitValChanges;
      [DataMember]
      [DefaultValue(0)]
      [Range(0, 2)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.QuitValueChanges PropQuitValChanges
      {
         get { return _propQuitValChanges; }
         set
         {
            _propQuitValChanges = value;
            ModifiedProperties.Add(nameof(PropQuitValChanges));
         }
      }

      #endregion IPvBaseObject

   }
}
