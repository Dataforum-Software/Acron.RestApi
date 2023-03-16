using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using Acron.RestApi.Interfaces.Data.Response.ProcessData;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using Acron.RestApi.DataContracts.Data.Response.ProcessData.TData;
using System.Linq;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData
{

   [DataContract]
   public class ProcessDataBase : IProcessDataBase<TDataBase, TDataBitArrayNum, TDataBitArrayString>
   {
      [DataMember]
      [JsonProperty(Order = 1)]
      /// <summary>
      /// ObjectID. Müssen wir noch in den 'neue Welt'-Nummernkreis heben. Daher public set
      /// </summary>
      public uint PVID { get; set; }

      [DataMember]
      [JsonProperty(Order = 2)]
      /// <summary>
      /// ShortName
      /// </summary>
      public string ShortName { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      [JsonProperty(Order = 3)]
      [DefaultValue(-1)]
      /// <summary>
      /// Datentyp
      /// </summary>
      public DataTypes DataType { get; set; }

      [DataMember]
      [JsonProperty(Order = 4)]
      public float PercentageReplacement { get; set; } = 0;

      [DataMember]
      [JsonProperty(Order = 5)]
      /// <summary>
      /// Vorgängerwert
      /// </summary>
      public TDataBase PredecessorValue { get; set; }

      [DataMember]
      [JsonProperty(Order = 6)]
      [DefaultValue(-1)]
      public int ValuesElementCount
      {
         get
         {
            if (Values == null || !Values.Any())
               return 0;

            return Values.Count;
         }
      }

      [DataMember]
      [JsonProperty(Order = 7)]
      /// <summary>
      /// Werte
      /// </summary>
      public List<TDataBase> Values { get; set; }

      [DataMember]
      [JsonProperty(Order = 8)]
      [DefaultValue(-1)]
      public int MinimaElementCount
      {
         get
         {
            if (Minima == null || !Minima.Any())
               return 0;

            return Minima.Count;
         }
      }

      [DataMember]
      [JsonProperty(Order = 9)]
      /// <summary>
      /// Minima
      /// </summary>
      public List<TDataBase> Minima { get; set; }

      [DataMember]
      [JsonProperty(Order = 10)]
      [DefaultValue(-1)]
      public int MaximaElementCount
      {
         get
         {
            if (Maxima == null || !Maxima.Any())
               return 0;

            return Maxima.Count;
         }
      }

      [DataMember]
      [JsonProperty(Order = 11)]
      /// <summary>
      /// Maxima
      /// </summary>
      public List<TDataBase> Maxima { get; set; }
   }
}
