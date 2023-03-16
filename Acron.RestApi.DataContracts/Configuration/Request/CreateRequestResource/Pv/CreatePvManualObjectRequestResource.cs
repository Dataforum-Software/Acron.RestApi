using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.Serialization;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Newtonsoft.Json;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreatePvManualObjectRequestResource : CreatePvManualAutoBaseObjectRequestResource, ICreatePvManualObjectRequestResource
   {
      #region cTor

      public CreatePvManualObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.VgHand)
      { }

      #endregion cTor

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropHedit = PvManualDefines.VgHValEdit.PerDay;

         this.PropCompressionIntervalMethod = PvManualDefines.CompIntervalMethod.AverageWeighted;
         this.PropCompressionDayMethod = PvManualDefines.CompDayMethod.Average;
         this.PropCompressionMonthMethod = PvManualDefines.CompMonthMethod.Average;
         this.PropCompressionYearMethod = PvManualDefines.CompYearMethod.Average;
      }

      #region IVgHandObject

      private Dictionary<int, int> _standardTimeStamps = null;

      [DataMember]
      public Dictionary<int, int> PropHandValueTimeStamps
      {
         get
         {
            if (_standardTimeStamps == null)
            {
               _standardTimeStamps = new Dictionary<int, int>();
               ModifiedProperties.Add(nameof(PropHandValueTimeStamps));
            }

            return _standardTimeStamps;
         }
         set
         {
            _standardTimeStamps = value;
            ModifiedProperties.Add(nameof(PropHandValueTimeStamps));
         }
      }

      private bool _propHValUseKey;
      [DataMember]
      [DefaultValue(false)]
      public bool PropHValUseKey
      {
         get { return _propHValUseKey; }
         set
         {
            _propHValUseKey = value;
            ModifiedProperties.Add(nameof(PropHValUseKey));
         }
      }

      private int _propIdExternalVariable;
      [DataMember]
      public int PropIdExternalVariable
      {
         get { return _propIdExternalVariable; }
         set
         {
            _propIdExternalVariable = value;
            ModifiedProperties.Add(nameof(PropIdExternalVariable));
         }
      }

      private PvManualDefines.VgHValEdit _propHedit;
      [DataMember]
      [DefaultValue(PvManualDefines.VgHValEdit.PerDay)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvManualDefines.VgHValEdit PropHedit
      {
         get { return _propHedit; }
         set
         {
            _propHedit = value;
            ModifiedProperties.Add(nameof(PropHedit));
         }
      }

      private string _propHvalKey;
      [DataMember]
      [DefaultValue("")]
      [MaxLength(10)]
      public string PropHvalKey
      {
         get { return _propHvalKey; }
         set
         {
            _propHvalKey = value;
            ModifiedProperties.Add(nameof(PropHvalKey));
         }
      }

      private PvManualDefines.CompIntervalMethod _propCompressionIntervalMethod;
      [DataMember]
      [DefaultValue(PvManualDefines.CompIntervalMethod.AverageWeighted)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvManualDefines.CompIntervalMethod PropCompressionIntervalMethod
      {
         get { return _propCompressionIntervalMethod; }
         set
         {
            _propCompressionIntervalMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionIntervalMethod));
         }
      }

      private PvManualDefines.CompDayMethod _propCompressionDayMethod;
      [DataMember]
      [DefaultValue(PvManualDefines.CompDayMethod.Average)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvManualDefines.CompDayMethod PropCompressionDayMethod
      {
         get { return _propCompressionDayMethod; }
         set
         {
            _propCompressionDayMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionDayMethod));
         }
      }

      private PvManualDefines.CompMonthMethod _propCompressionMonthMethod;
      [DataMember]
      [DefaultValue(PvManualDefines.CompMonthMethod.Average)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvManualDefines.CompMonthMethod PropCompressionMonthMethod
      {
         get { return _propCompressionMonthMethod; }
         set
         {
            _propCompressionMonthMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionMonthMethod));
         }
      }

      private PvManualDefines.CompYearMethod _propCompressionYearMethod;
      [DataMember]
      [DefaultValue(PvManualDefines.CompYearMethod.Average)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvManualDefines.CompYearMethod PropCompressionYearMethod
      {
         get { return _propCompressionYearMethod; }
         set
         {
            _propCompressionYearMethod = value;
            ModifiedProperties.Add(nameof(PropCompressionYearMethod));
         }
      }

      #endregion IVgHandObject

   }
}
