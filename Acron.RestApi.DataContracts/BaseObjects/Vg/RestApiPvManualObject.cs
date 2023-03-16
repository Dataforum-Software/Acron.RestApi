using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiPvManualObject : RestApiPvManualAutoBaseObject, IPvManualObject
   {
      #region cTor

      public RestApiPvManualObject()
         : base(BaseObjectDefines.RestObjectTypeCode.VgHand)
      { }

      public RestApiPvManualObject(object source)
         : base(source)
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

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IPvManualObject iPvHand = baseObject as IPvManualObject;

         this.PropHandValueTimeStamps.Clear();

         foreach(KeyValuePair<int,int> kvp in iPvHand.PropHandValueTimeStamps)
         {
            this.PropHandValueTimeStamps.Add(kvp.Key, kvp.Value);
         }

         this.PropHValUseKey = iPvHand.PropHValUseKey;
         this.PropIdExternalVariable = iPvHand.PropIdExternalVariable;
         this.PropHedit = iPvHand.PropHedit;
         this.PropHvalKey = iPvHand.PropHvalKey;

         this.PropCompressionIntervalMethod = iPvHand.PropCompressionIntervalMethod;
         this.PropCompressionDayMethod = iPvHand.PropCompressionDayMethod;
         this.PropCompressionMonthMethod = iPvHand.PropCompressionMonthMethod;
         this.PropCompressionYearMethod = iPvHand.PropCompressionYearMethod;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreatePvManualObjectRequestResource iPvHand = baseObject as ICreatePvManualObjectRequestResource;

         this.PropHandValueTimeStamps.Clear();

         foreach (KeyValuePair<int, int> kvp in iPvHand.PropHandValueTimeStamps)
         {
            this.PropHandValueTimeStamps.Add(kvp.Key, kvp.Value);
         }

         this.PropHValUseKey = iPvHand.PropHValUseKey;
         this.PropIdExternalVariable = iPvHand.PropIdExternalVariable;
         this.PropHedit = iPvHand.PropHedit;
         this.PropHvalKey = iPvHand.PropHvalKey;

         this.PropCompressionIntervalMethod = iPvHand.PropCompressionIntervalMethod;
         this.PropCompressionDayMethod = iPvHand.PropCompressionDayMethod;
         this.PropCompressionMonthMethod = iPvHand.PropCompressionMonthMethod;
         this.PropCompressionYearMethod = iPvHand.PropCompressionYearMethod;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdatePvManualObjectRequestResource iPvHand = baseObject as IUpdatePvManualObjectRequestResource;

         this.PropHandValueTimeStamps.Clear();

         foreach (KeyValuePair<int, int> kvp in iPvHand.PropHandValueTimeStamps)
         {
            this.PropHandValueTimeStamps.Add(kvp.Key, kvp.Value);
         }

         this.PropHValUseKey = iPvHand.PropHValUseKey;
         this.PropIdExternalVariable = iPvHand.PropIdExternalVariable;
         this.PropHedit = iPvHand.PropHedit;
         this.PropHvalKey = iPvHand.PropHvalKey;

         this.PropCompressionIntervalMethod = iPvHand.PropCompressionIntervalMethod;
         this.PropCompressionDayMethod = iPvHand.PropCompressionDayMethod;
         this.PropCompressionMonthMethod = iPvHand.PropCompressionMonthMethod;
         this.PropCompressionYearMethod = iPvHand.PropCompressionYearMethod;

         return true;
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