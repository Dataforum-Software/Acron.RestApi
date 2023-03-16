using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdatePvExternalObjectRequestResource : UpdateBaseObjectRequestResource, IUpdatePvExternalObjectRequestResource
   {
      #region cTor

      public UpdatePvExternalObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.VgExternal)
      { }

      #endregion cTor

      #region IPvExternalObject

      /// <summary>
      /// Typ der Original-PV
      /// </summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvExternalDefines.VgExternalType PropExtType { get; internal set; }

      /// <summary>
      /// Id der Original-PV
      /// </summary>
      [DataMember]
      public int PropExtId { get; internal set; }

      /// <summary>
      /// Id der zugehörigen Connection
      /// </summary>
      [DataMember]
      public int PropConnectionId { get; internal set; }


      /// <summary>Schlüssel</summary>
      [DataMember]
      public string PropKey { get; internal set; }

      /// <summary>
      /// Unter-Typ der RG - Standard, Temporär, LIVE
      /// </summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvCalcDefines.CalculationType PropCalculationType { get; internal set; }

      /// <summary> Erste aktive Stufe - Datenherkunft </summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.ValueType PropCompressionDataSource { get; internal set; }

      #region RG-Live

      /// <summary>
      /// Auswertestufe 'Prozess'
      /// </summary>
      [DataMember]
      public bool PropCompressionProcessActive { get; internal set; }

      #endregion

      /// <summary>mögliche Handwerterfassung (tageweise, wochenweise,...)</summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvManualDefines.VgHValEdit PropHedit { get; internal set; }

      #region Interval

      /// <summary>
      /// Auswertestufe Interval
      /// </summary>
      [DataMember]
      public bool PropCompressionIntervalActive { get; internal set; }

      /// <summary> Intervallkompression Methode</summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.CompMethod PropCompressionIntervalMethod { get; internal set; }

      /// <summary> Intervallkompression verwendete Intervalle</summary>
      [DataMember]
      public uint PropCompressionIntervalUsedIntervals { get; internal set; }

      #endregion Interval

      #region Day

      /// <summary>
      /// Auswertestufe Tag
      /// </summary>
      [DataMember]
      public bool PropCompressionDayActive { get; internal set; }

      /// <summary> Tageskompression Methode</summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.CompMethod PropCompressionDayMethod { get; internal set; }

      #endregion Day

      #region Month

      /// <summary>
      /// Auswertestufe Monat
      /// </summary>
      [DataMember]
      public bool PropCompressionMonthActive { get; internal set; }

      /// <summary> Monatskompression Methode</summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.CompMethod PropCompressionMonthMethod { get; internal set; }

      #endregion Month

      #region Year

      /// <summary>
      /// Auswertestufe Jahr
      /// </summary>
      [DataMember]
      public bool PropCompressionYearActive { get; internal set; }

      /// <summary> Jahreskompression Methode</summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.CompMethod PropCompressionYearMethod { get; internal set; }

      #endregion Year

      /// <summary>Werteformat</summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.ValueFormat PropFormatVal { get; internal set; }

      /// <summary>Ausgabeformat von Werten vom Format Time</summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvBaseDefines.TimeFormat PropFormatTime { get; internal set; }

      #region Providing-Flags

      /// <summary>Anzahl der Tage bei Bereitstellung gleitender Tageswert</summary>
      [DataMember]
      public int PropFloatingDayValue { get; internal set; }

      /// <summary>Bereitstellung der Werte old:REP_VALUE</summary>
      [DataMember]
      public bool PropProvidingValue { get; internal set; }

      /// <summary>Bereitstellung von Summen old:REP_SUM</summary>
      [DataMember]
      public bool PropProvidingSum { get; internal set; }

      /// <summary>Bereitstellung von Minima und Maxima old:REP_MAXMIN</summary>
      [DataMember]
      public bool PropProvidingMinMax { get; internal set; }

      /// <summary>Bereitstellung Standardabweichung old:REP_SAVG</summary>
      [DataMember]
      public bool PropProvidingSDeviation { get; internal set; }

      /// <summary>Bereitstellung der Percentilwerte old:REP_PERCENTIL</summary>
      [DataMember]
      public bool PropProvidingPercentil { get; internal set; }

      /// <summary>Bereitstellung der Tage monatsweise für Jahresberichte old:REP_MDAYS</summary>
      [DataMember]
      public bool PropProvidingMDays { get; internal set; }

      /// <summary>Bereitstellung gleitender Tageswert old:REP_DAYFLOATAVG</summary>
      [DataMember]
      public bool PropProvidingFloatDayval { get; internal set; }

      /// <summary>Bereitstellung für das Internet old:WWW_USED</summary>
      [DataMember]
      public bool PropProvidingWWW { get; internal set; }

      /// <summary>Bereitstellung der Grenzwertverletzungen old:REP_OUTRANGE</summary>
      [DataMember]
      public bool PropProvidingLimits { get; internal set; }

      /// <summary>Bereitstellung der Verschlüsselung old:VG_CODED</summary>
      [DataMember]
      public bool PropProvidingCoding { get; internal set; }

      /// <summary>Bereitstellung für Multiserver</summary>
      [DataMember]
      public bool PropProvidingMultiserver { get; internal set; }

      /// <summary>Bereitstellung für OPC/DDE</summary>
      [DataMember]
      public bool PropProvidingOpcDde { get; internal set; }

      /// <summary>Bereitstellung im Dialog Tag old:DLG_DAY</summary>
      [DataMember]
      public bool PropProvidingDialogDay { get; internal set; }

      /// <summary>Bereitstellung im Dialog Monat old:DLG_MON</summary>
      [DataMember]
      public bool PropProvidingDialogMonth { get; internal set; }

      /// <summary>Bereitstellung im Dialog Jahr old:DLG_YEAR</summary>
      [DataMember]
      public bool PropProvidingDialogYear { get; internal set; }

      /// <summary>Bereitstellung der Freigabeverwaltung old:VG_RELEASE</summary>
      [DataMember]
      public bool PropProvidingReleased { get; internal set; }

      /// <summary>Bereitstellung Werteschlüssel old:VIEW_VGKEY</summary>
      [DataMember]
      public bool PropProvidingValKeys { get; internal set; }

      #endregion Providing-Flags

      #endregion IVgExternalObject

   }
}
