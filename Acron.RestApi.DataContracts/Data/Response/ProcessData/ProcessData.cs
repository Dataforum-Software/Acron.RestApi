using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using Acron.RestApi.Interfaces.Data.Response.ProcessData;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using static Acron.RestApi.Interfaces.Data.Response.ProcessData.TData.ITDataBase;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData
{

   [DataContract]
   public class ProcessData : IProcessData
   {
      [DataMember]
      /// <summary>
      /// ObjectID. Müssen wir noch in den 'neue Welt'-Nummernkreis heben. Daher public set
      /// </summary>
      public uint PVID { get; set; }

      [DataMember]
      /// <summary>
      /// ShortName
      /// </summary>
      public string ShortName { get; set; }

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      /// <summary>
      /// Datentyp
      /// </summary>
      public DataTypes DataType { get; set; }

      public IArrayHeader ValuesArrayHeader { get; set; }

      [DataMember]
      /// <summary>
      /// Werte
      /// </summary>
      public List<ITDataBase> Values { get; set; }

      [DataMember]
      /// <summary>
      /// Vorgängerwert
      /// </summary>
      public ITDataBase PredecessorValue { get; set; }

      public IArrayHeader MinimaArrayHeader { get; set; }

      [DataMember]
      [DefaultValue(-1)]
      public int MinimaElementCount
      {
         get
         {
            if (MinimaArrayHeader == null)
               return 0;

            if (!MinimaArrayHeader.HasData)
               return 0;

            return (int)MinimaArrayHeader.ElementCount;
         }
      }

      [DataMember]
      /// <summary>
      /// Minima
      /// </summary>
      public List<ITDataBase> Minima { get;  set; }

      public IArrayHeader MaximaArrayHeader { get; set; }

      [DataMember]
      [DefaultValue(-1)]
      public int MaximaElementCount
      {
         get
         {
            if (MaximaArrayHeader == null)
               return 0;

            if (!MaximaArrayHeader.HasData)
               return 0;

            return (int)MaximaArrayHeader.ElementCount;
         }
      }

      [DataMember]
      /// <summary>
      /// Maxima
      /// </summary>
      public List<ITDataBase> Maxima { get; set; }

      [DataMember]
      public float PercentageReplacement { get; set; } = 0;

   }
}
