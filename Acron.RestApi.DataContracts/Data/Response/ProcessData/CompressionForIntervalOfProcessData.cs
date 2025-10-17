using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.ProcessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData
{
   [DataContract]
   public class CompressionForIntervalOfProcessData : ICompressionForIntervalOfProcessData<CompressionForIntervalOfProcessDataFlag>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public string ShortName { get; set; }

      [DataMember]
      public CompressionForIntervalOfProcessDataFlag ICOMPDAT_FLAG { get; set; }

      [DataMember]
      [FormatDoubleMarker(nameof(ICOMPDAT_IVAL_FORMATTED), ValueFormatType.Process)]
      public double ICOMPDAT_IVAL { get; set; }
      [DataMember]
      public string ICOMPDAT_IVAL_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(ICOMPDAT_PSUM_FORMATTED), ValueFormatType.Process)]
      public double ICOMPDAT_PSUM { get; set; }
      [DataMember]
      public string ICOMPDAT_PSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(ICOMPDAT_PSIGMA_FORMATTED), ValueFormatType.Process)]
      public float ICOMPDAT_PSIGMA { get; set; }
      [DataMember]
      public string ICOMPDAT_PSIGMA_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(ICOMPDAT_PPERC15_FORMATTED), ValueFormatType.Process)]
      public float ICOMPDAT_PPERC15 { get; set; }
      [DataMember]
      public string ICOMPDAT_PPERC15_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(ICOMPDAT_PPERC85_FORMATTED), ValueFormatType.Process)]
      public float ICOMPDAT_PPERC85 { get; set; }
      [DataMember]
      public string ICOMPDAT_PPERC85_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(ICOMPDAT_PMIN_FORMATTED), ValueFormatType.Process)]
      public double ICOMPDAT_PMIN { get; set; }
      [DataMember]
      public string ICOMPDAT_PMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(ICOMPDAT_PMINTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime ICOMPDAT_PMINTM { get; set; }
      [DataMember]
      public string ICOMPDAT_PMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(ICOMPDAT_PMAX_FORMATTED), ValueFormatType.Process)]
      public double ICOMPDAT_PMAX { get; set; }
      [DataMember]
      public string ICOMPDAT_PMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(ICOMPDAT_PMAXTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime ICOMPDAT_PMAXTM { get; set; }
      [DataMember]
      public string ICOMPDAT_PMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(ICOMPDAT_PMINLIM_FORMATTED))]
      public uint ICOMPDAT_PMINLIM { get; set; }
      [DataMember]
      public string ICOMPDAT_PMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(ICOMPDAT_PMAXLIM_FORMATTED))]
      public uint ICOMPDAT_PMAXLIM { get; set; }
      [DataMember]
      public string ICOMPDAT_PMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(ICOMPDAT_PCOUNT_FORMATTED))]
      public uint ICOMPDAT_PCOUNT { get; set; }
      [DataMember]
      public string ICOMPDAT_PCOUNT_FORMATTED { get; set; }
   }
}
