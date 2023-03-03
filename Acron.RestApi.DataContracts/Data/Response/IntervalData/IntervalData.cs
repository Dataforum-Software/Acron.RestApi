using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Acron.RestApi.DataContracts.Data.Response.IntervalData
{
   [DataContract]
   public class IntervalData : IIntervalData
   {
      [DataMember]
      public uint PVID {get; set;}

      [DataMember]
      public string ShortName { get; set;}

      [DataMember]
      public List<IIntervalDataFlag> IDAT_FLAG { get; set; }

      [DataMember]
      [FormatDoubleListMarker(nameof(IDAT_IVAL_FORMATTED), ValueFormatType.Interval)]
      public List<double> IDAT_IVAL { get; set; }

      [DataMember]
      public List<string> IDAT_IVAL_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(IDAT_PSUM_FORMATTED), ValueFormatType.Process)]
      public List<double> IDAT_PSUM { get; set; }

      [DataMember]
      public List<string> IDAT_PSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(IDAT_PSIGMA_FORMATTED), ValueFormatType.Process)]
      public List<float> IDAT_PSIGMA { get; set; }

      [DataMember]
      public List<string> IDAT_PSIGMA_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(IDAT_PPERC15_FORMATTED), ValueFormatType.Process)]
      public List<float> IDAT_PPERC15 { get; set; }

      [DataMember]
      public List<string> IDAT_PPERC15_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(IDAT_PPERC85_FORMATTED), ValueFormatType.Process)]
      public List<float> IDAT_PPERC85 { get; set; }

      [DataMember]
      public List<string> IDAT_PPERC85_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(IDAT_PMIN_FORMATTED), ValueFormatType.Process)]
      public List<double> IDAT_PMIN { get; set; }

      [DataMember]
      public List<string> IDAT_PMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(IDAT_PMINTM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> IDAT_PMINTM { get; set; }

      [DataMember]
      public List<string> IDAT_PMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(IDAT_PMAX_FORMATTED), ValueFormatType.Process)]
      public List<double> IDAT_PMAX { get; set; }

      [DataMember]
      public List<string> IDAT_PMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(IDAT_PMAXTM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> IDAT_PMAXTM { get; set; }

      [DataMember]
      public List<string> IDAT_PMAXTM_FORMATTED { get; set; }

      [DataMember]
      public List<uint> IDAT_PMINLIM { get; set; }

      [DataMember]
      public List<uint> IDAT_PMAXLIM { get; set; }

      [DataMember]
      public List<uint> IDAT_PCOUNT { get; set; }
   }
}
