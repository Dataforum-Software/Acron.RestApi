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
   public class UpdatePvCalcObjectRequestResource : UpdatePvBaseObjectRequestResource, IUpdatePvCalcObjectRequestResource
   {
      #region cTor

      public UpdatePvCalcObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.VgCalc)
      { }

      /// <summary>
      /// Für Ableitungen von PvCalc
      /// </summary>
      /// <param name="typeCode"></param>
      public UpdatePvCalcObjectRequestResource(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      #endregion cTor

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropCalculationType = PvCalcDefines.CalculationType.Standard;

         this.PropFormulaEdit = "1";

         this.PropSourceVal = PvBaseDefines.ValueType.Interval1;

         #region Process for RG-Live 

         this.PropCompressionProcessRangeFrom = BaseObjectDefines.NO_VALID;
         this.PropCompressionProcessRangeTo = BaseObjectDefines.NO_VALID;

         #endregion Process for RG-Live 

         this.PropCompressionIntervalMethod = PvBaseDefines.CompMethod.AverageWeighted;
         this.PropCompressionDayMethod = PvBaseDefines.CompMethod.Average;
         this.PropCompressionMonthMethod = PvBaseDefines.CompMethod.Average;
         this.PropCompressionYearMethod = PvBaseDefines.CompMethod.Average;
      }

      #region IVgCalcObject

      private PvCalcDefines.CalculationType _propCalculationType;
      /// <summary>
      /// Unter-Typ der RG - Standard, Temporär, LIVE
      /// </summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvCalcDefines.CalculationType PropCalculationType
      {
         get { return _propCalculationType; }
         set
         {
            _propCalculationType = value;
            ModifiedProperties.Add(nameof(PropCalculationType));
         }
      }


      ///// <summary> Erste aktive Stufe - Datenherkunft </summary>
      //protected PvBaseDefines.ValueType PropCompressionDataSource
      //{
      //   get { return (PvBaseDefines.ValueType)GetPropertyValue<int>(PropKeyCompressionDataSource); }
      //   set
      //   {
      //      PvBaseDefines.ValueType oldValue = PropCompressionDataSource;
      //      SetPropertyValue<int>(PropKeyCompressionDataSource, (int)value);
      //      NotifyBaseObjectPropertyChanged<PvBaseDefines.ValueType>(nameof(PropCompressionDataSource), oldValue, value);
      //   }
      //}

      private PvBaseDefines.ValueType _propSourceVal;
      /// <summary> Ausgangswerte der Berechnung </summary>
      [DataMember]
      [DefaultValue(PvBaseDefines.ValueType.Interval1)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.ValueType PropSourceVal
      {
         get { return _propSourceVal; }
         set
         {
            _propSourceVal = value;
            ModifiedProperties.Add(nameof(PropSourceVal));
         }
      }


      // ***
      // Redundante Information - wird durch kleinste aktive Verdichtungsstufe festgelegt
      // ***

      //private PvBaseDefines.ValueResult _propResultVal;

      ///// <summary> Ergebnis der Berechnung </summary>
      //[DataMember]
      //[DefaultValue(PvBaseDefines.ValueResult.Interval)]
      //public PvBaseDefines.ValueResult PropResultVal 
      //{
      //   get { return _propResultVal; }
      //   set
      //   {
      //      _propResultVal = value;
      //      ModifiedProperties.Add(nameof(PropResultVal));
      //   }
      //}

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

      #region Process for RG-Live 

      private bool _propCompressionProcessActive;
      /// <summary>
      /// Auswertestufe 'Prozess'
      /// </summary>
      [DataMember]
      [DefaultValue(false)]
      public bool PropCompressionProcessActive
      {
         get { return _propCompressionProcessActive; }
         set
         {
            _propCompressionProcessActive = value;
            ModifiedProperties.Add(nameof(PropCompressionProcessActive));
         }
      }


      private double _propCompressionProcessRangeFrom;
      /// <summary> Prozessswerte GW von</summary>
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionProcessRangeFrom
      {
         get { return _propCompressionProcessRangeFrom; }
         set
         {
            _propCompressionProcessRangeFrom = value;
            ModifiedProperties.Add(nameof(PropCompressionProcessRangeFrom));
         }
      }


      private double _propCompressionProcessRangeTo;
      /// <summary> Prozesswerte GW bis</summary>
      [DataMember]
      [DefaultValue(BaseObjectDefines.NO_VALID)]
      public double PropCompressionProcessRangeTo
      {
         get { return _propCompressionProcessRangeTo; }
         set
         {
            _propCompressionProcessRangeTo = value;
            ModifiedProperties.Add(nameof(PropCompressionProcessRangeTo));
         }
      }


      private string _propCompressionProcessUnitFormula;
      /// <summary>Prozess Einheitsformel</summary>
      [DataMember]
      [DefaultValue("")]
      public string PropCompressionProcessUnitFormula
      {
         get { return _propCompressionProcessUnitFormula; }
         set
         {
            _propCompressionProcessUnitFormula = value;
            ModifiedProperties.Add(nameof(PropCompressionProcessUnitFormula));
         }
      }


      private int _propCompressionProcessNk;
      /// <summary> Prozesswerte NK</summary>
      [DataMember]
      [DefaultValue(0)]
      [Range(-9, 9)]
      public int PropCompressionProcessNk
      {
         get { return _propCompressionProcessNk; }
         set
         {
            _propCompressionProcessNk = value;
            ModifiedProperties.Add(nameof(PropCompressionProcessNk));
         }
      }


      #endregion Process for RG-Live 

      private PvBaseDefines.CompMethod _propCompressionIntervalMethod;
      /// <summary> Intervallkompression Methode</summary>
      [DataMember]
      [DefaultValue(PvBaseDefines.CompMethod.AverageWeighted)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.CompMethod PropCompressionIntervalMethod
      {
         get { return _propCompressionIntervalMethod; }
         set
         {
            _propCompressionIntervalMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionIntervalMethod));
         }
      }


      private PvBaseDefines.CompMethod _propCompressionDayMethod;
      /// <summary> Tageskompression Methode</summary>
      [DataMember]
      [DefaultValue(PvBaseDefines.CompMethod.Average)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.CompMethod PropCompressionDayMethod
      {
         get { return _propCompressionDayMethod; }
         set
         {
            _propCompressionDayMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionDayMethod));
         }
      }


      private int _propCompressionDayFloatSeconds;
      /// <summary> Tageskompression Sekunden für gleitende Tageswerte</summary>
      [DataMember]
      [DefaultValue(0)]
      public int PropCompressionDayFloatSeconds
      {
         get { return _propCompressionDayFloatSeconds; }
         set
         {
            _propCompressionDayFloatSeconds = value;
            ModifiedProperties.Add(nameof(PropCompressionDayFloatSeconds));
         }
      }


      private PvBaseDefines.CompMethod _propCompressionMonthMethod;
      /// <summary> Monatskompression Methode</summary>
      [DataMember]
      [DefaultValue(PvBaseDefines.CompMethod.Average)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.CompMethod PropCompressionMonthMethod
      {
         get { return _propCompressionMonthMethod; }
         set
         {
            _propCompressionMonthMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionMonthMethod));
         }
      }


      private int _propCompressionMonthFloatSeconds;
      /// <summary> Monatskompression Sekunden für gleitende Tageswerte</summary>
      [DataMember]
      [DefaultValue(0)]
      public int PropCompressionMonthFloatSeconds
      {
         get { return _propCompressionMonthFloatSeconds; }
         set
         {
            _propCompressionMonthFloatSeconds = value;
            ModifiedProperties.Add(nameof(PropCompressionMonthFloatSeconds));
         }
      }


      private PvBaseDefines.CompMethod _propCompressionYearMethod;
      /// <summary> Jahreskompression Methode</summary>
      [DataMember]
      [DefaultValue(PvBaseDefines.CompMethod.Average)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.CompMethod PropCompressionYearMethod
      {
         get { return _propCompressionYearMethod; }
         set
         {
            _propCompressionYearMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionYearMethod));
         }
      }

      #endregion IVgCalcObject

   }
}
