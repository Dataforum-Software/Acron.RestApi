using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.EventData
{
   public interface IGetEventDataResult<T, U, V, W, X> where T : IEventItem<U, V, W, X> where U : IEventSubItem<V, W, X> where V : IEventCell where W : IEventDataItem<X> where X : IEventDataCell
   {
      [SwaggerSchema("Status of the event")]
      [SwaggerExampleValue(EventErrorType.EVENT_OK)]
      EventErrorType EventStatus { get; set; }

      [SwaggerSchema("List of event data items")]
      [SwaggerExampleValue(typeof(IEventItem<IEventSubItem<IEventCell, IEventDataItem<IEventDataCell>, IEventDataCell>, IEventCell, IEventDataItem<IEventDataCell>, IEventDataCell>))]
      List<T> EventItems { get; set; }
   }


   public enum EventErrorType
   {
      [EnumMember]
      [SwaggerEnumInfo("Event status is ok")]
      EVENT_OK = 0,
      [EnumMember]
      [SwaggerEnumInfo("Event parameters are invalid")]
      EVENT_PARA = 1,
      [EnumMember]
      [SwaggerEnumInfo("Event read failed")]
      EVENT_READFAILED = 2,
      [EnumMember]
      [SwaggerEnumInfo("Event read exceeded maximum number of events")]
      EVENT_READMAX = 3,
      [EnumMember]
      [SwaggerEnumInfo("Event read was cancelled")]
      EVENT_READCANCELD = 4,
      [EnumMember]
      [SwaggerEnumInfo("Server error occurred while reading event")]
      EVENT_SERVERERROR = 5,
   };

   [Flags]
   public enum EventBaseFlags
   {
      [EnumMember]
      [SwaggerEnumInfo("Accuracy of start values in milliseconds")]
      EBASE_MILLISEC_FROM = 0x1,
      [EnumMember]
      [SwaggerEnumInfo("Accuracy of stop values in milliseconds")]
      EBASE_MILLISEC_TO = 0x2,
      [EnumMember]
      [SwaggerEnumInfo("Event was closed by force")]
      EBASE_SANCTION = 0x4,
      [EnumMember]
      [SwaggerEnumInfo("Invalid event, has nothing to do with deleted events")]
      EBASE_INVALID = 0x8,
      [EnumMember]
      [SwaggerEnumInfo("Id was converted during acron plant update to version 8.3 - only for emergency")]
      EBASE_CONVERTED_83 = 0x10,
   }

   [Flags]
   public enum EventFlags
   {
      [EnumMember]
      [SwaggerEnumInfo("Event is deleted")]
      EVENT_DEL = 0x1,
      [EnumMember]
      [SwaggerEnumInfo("Event passed filter")]
      EVENT_FORMCALC = 0x2,
      [EnumMember]
      [SwaggerEnumInfo("Subevent comes from an open event")]
      EVENT_OPEN = 0x4,
      [EnumMember]
      [SwaggerEnumInfo("Event was created manually")]
      EVENT_HAND = 0x8,
      [EnumMember]
      [SwaggerEnumInfo("Event has any marking")]
      EVENT_MARK = 0x10
   }

   public enum EventCellTypes : short
   {
      [EnumMember]
      [SwaggerEnumInfo("Unknown cell type")]
      CELL_UNKNOWN = 0,
      [EnumMember]
      [SwaggerEnumInfo("Date cell type")]
      CELL_DATE = 1,
      [EnumMember]
      [SwaggerEnumInfo("Time cell type")]
      CELL_TIME = 2,
      [EnumMember]
      [SwaggerEnumInfo("Batch ID cell type")]
      CELL_BATCHID = 3,
      [EnumMember]
      [SwaggerEnumInfo("Duration cell type")]
      CELL_DURATION = 4,
      [EnumMember]
      [SwaggerEnumInfo("Batrch count cell type")]
      CELL_BCOUNT = 5,
      [EnumMember]
      [SwaggerEnumInfo("Text cell type")]
      CELL_TEXT = 6,
      [EnumMember]
      [SwaggerEnumInfo("^Process value batch cell type")]
      CELL_VGBATCH = 8,
      [EnumMember]
      [SwaggerEnumInfo("Overwritten value cell type")]
      CELL_OVER = 9,
      [EnumMember]
      [SwaggerEnumInfo("Input value cell type")]
      CELL_INPUT = 10,
      [EnumMember]
      [SwaggerEnumInfo("Calculated value cell type")]
      CELL_CALC = 11,
      [EnumMember]
      [SwaggerEnumInfo("Timestamp for process values cell type")]
      CELL_PSTAMP = 12, //Zeitstempel für Prozessdaten
      [EnumMember]
      [SwaggerEnumInfo("Timestamp for interval data (main interval) cell type")]
      CELL_ISTAMP1 = 13, //Zeitstempel für Intervalldaten(Hauptintervall)
      [EnumMember]
      [SwaggerEnumInfo("Timestamp for interval data (secondary interval) cell type")]
      CELL_ISTAMP2 = 14, //Zeitstempel für Intervalldaten(Nebenintervall)
   };

   public enum EventCellKeys
   {
      [EnumMember]
      [SwaggerEnumInfo("Unknown cell key")]
      CELLKEY_UNKNOWN = 0,
      [EnumMember]
      [SwaggerEnumInfo("Start cell key")]
      CELLKEY_START = 1,
      [EnumMember]
      [SwaggerEnumInfo("Stop cell key")]
      CELLKEY_STOP = 2,
      [EnumMember]
      [SwaggerEnumInfo("Status cell key")]
      CELLKEY_STAT = 3,
   };

   public enum ID_GEN_TYPE : short
   {
      [EnumMember]
      [SwaggerEnumInfo("Automatic event generation from process values")]
      ID_BAUTOVG = 0,
      [EnumMember]
      [SwaggerEnumInfo("Manual event generation")]
      ID_BHAND = 1,
      [EnumMember]
      [SwaggerEnumInfo("Event generation by acron")]
      ID_BACRON = 2
   };

   public enum ProcessVariableValueTypes
   {
      [EnumMember]
      [SwaggerEnumInfo("Unknown value type")]
      VG_DAT_UNKNOWN = -1,

      [EnumMember]
      [SwaggerEnumInfo("Process  flags")]
      VG_PDAT_PFLAG = 0,

      [EnumMember]
      [SwaggerEnumInfo("Process time")]
      VG_PDAT_PTIME = 1,
      [EnumMember]
      [SwaggerEnumInfo("Process value")]
      VG_PDAT_PVAL = 2,
      [EnumMember]
      [SwaggerEnumInfo("Process value minimum")]
      VG_PDAT_PMIN = 3,
      [EnumMember]
      [SwaggerEnumInfo("Process value maximum")]
      VG_PDAT_PMAX = 4,

      [EnumMember]
      [SwaggerEnumInfo("Interval data - Flags")]
      VG_IDAT_IFLAG = 5,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - Timestamp")]
      VG_IDAT_ITIME = 6,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - Value")]
      VG_IDAT_IVAL = 7,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - Sum of process values")]
      VG_IDAT_PSUM = 8,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - Standard deviation of process values")]
      VG_IDAT_PSIGMA = 9,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - 15th percentile of process values")]
      VG_IDAT_PPERC15 = 10,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - 85th percentile of process values")]
      VG_IDAT_PPERC85 = 11,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - Minimum of process values")]
      VG_IDAT_PMIN = 12,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - Time of minimum process value")]
      VG_IDAT_PMINTM = 13,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - Maximum of process values")]
      VG_IDAT_PMAX = 14,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - Time of maximum process value")]
      VG_IDAT_PMAXTM = 15,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - Minimum limit violations of process values")]
      VG_IDAT_PMINLIM = 16,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - Maximum limit violations of process values")]
      VG_IDAT_PMAXLIM = 17,
      [EnumMember]
      [SwaggerEnumInfo("Interval data - Count of process values")]
      VG_IDAT_PCOUNT = 18,

      [EnumMember]
      [SwaggerEnumInfo("Day data - Flags")]
      VG_DDAT_DFLAG = 19,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Timestamp")]
      VG_DDAT_DTIME = 20,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Value")]
      VG_DDAT_DVAL = 21,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Specific time stamp of each value according to compression type")]
      VG_DDAT_DVALTM = 22,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Average value")]
      VG_DDAT_DVALAVG = 23,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Sum of process values")]
      VG_DDAT_PSUM = 24,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Minimum of process values")]
      VG_DDAT_PMIN = 25,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Time of minimum process value")]
      VG_DDAT_PMINTM = 26,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Maximum of process values")]
      VG_DDAT_PMAX = 27,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Time of maximum process value")]
      VG_DDAT_PMAXTM = 28,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Minimum range limit shortfalls of process values")]
      VG_DDAT_PMINLIM = 29,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Maximum range limit shortfalls of process values")]
      VG_DDAT_PMAXLIM = 30,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Number of process values")]
      VG_DDAT_PCOUNT = 31,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Sum of interval values")]
      VG_DDAT_ISUM = 32,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Standard deviation of interval values")]
      VG_DDAT_ISIGMA = 33,
      [EnumMember]
      [SwaggerEnumInfo("Day data - 15th percentile of interval values")]
      VG_DDAT_IPERC15 = 34,
      [EnumMember]
      [SwaggerEnumInfo("Day data - 85th percentile of interval values")]
      VG_DDAT_IPERC85 = 35,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Minimum of interval values")]
      VG_DDAT_IMIN = 36,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Time of minimum interval value")]
      VG_DDAT_IMINTM = 37,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Maximum of interval values")]
      VG_DDAT_IMAX = 38,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Time of maximum interval value")]
      VG_DDAT_IMAXTM = 39,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Minimum range limit shortfalls of interval values")]
      VG_DDAT_IMINLIM = 40,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Maximum range limit shortfalls of interval values")]
      VG_DDAT_IMAXLIM = 41,
      [EnumMember]
      [SwaggerEnumInfo("Day data - Number of interval values")]
      VG_DDAT_ICOUNT = 42,

      [EnumMember]
      [SwaggerEnumInfo("Month data - Flags")]
      VG_MDAT_FLAG = 43,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Timestamp")]
      VG_MDAT_MTIME = 44,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Value")]
      VG_MDAT_MVAL = 45,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Specific time stamp of each value according to compression type")]
      VG_MDAT_MVALTM = 46,
      [EnumMember]
      [SwaggerEnumInfo("Month data - second special monthly value according to compression type")]
      VG_MDAT_MVAL1 = 47,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Specific time stamp of second special monthly value according to compression type")]
      VG_MDAT_MVAL1TM = 48,
      [EnumMember]
      [SwaggerEnumInfo("Month data - third special monthly value according to compression type")]
      VG_MDAT_MVAL2 = 49,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Specific time stamp of third special monthly value according to compression type")]
      VG_MDAT_MVAL2TM = 50,
      [EnumMember]
      [SwaggerEnumInfo("Month data - fourth special monthly value according to compression type")]
      VG_MDAT_MVAL3 = 51,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Specific time stamp of fourth special monthly value according to compression type")]
      VG_MDAT_MVAL3TM = 52,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Sum of process values")]
      VG_MDAT_PSUM = 53,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Minimum of process values")]
      VG_MDAT_PMIN = 54,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Time of minimum process value")]
      VG_MDAT_PMINTM = 55,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Maximum of process values")]
      VG_MDAT_PMAX = 56,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Time of maximum process value")]
      VG_MDAT_PMAXTM = 57,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Minimum range limit shortfalls of process values")]
      VG_MDAT_PMINLIM = 58,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Maximum range limit shortfalls of process values")]
      VG_MDAT_PMAXLIM = 59,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Number of process values")]
      VG_MDAT_PCOUNT = 60,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Sum of interval values")]
      VG_MDAT_ISUM = 61,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Minimum of interval values")]
      VG_MDAT_IMIN = 62,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Time of minimum interval value")]
      VG_MDAT_IMINTM = 63,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Maximum of interval values")]
      VG_MDAT_IMAX = 64,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Time of maximum interval value")]
      VG_MDAT_IMAXTM = 65,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Minimum range limit shortfalls of interval values")]
      VG_MDAT_IMINLIM = 66,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Maximum range limit shortfalls of interval values")]
      VG_MDAT_IMAXLIM = 67,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Number of interval values")]
      VG_MDAT_ICOUNT = 68,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Sum of daily values")]
      VG_MDAT_DSUM = 69,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Standard deviation of daily values")]
      VG_MDAT_DSIGMA = 70,
      [EnumMember]
      [SwaggerEnumInfo("Month data - 15th percentile of daily values")]
      VG_MDAT_DPERC15 = 71,
      [EnumMember]
      [SwaggerEnumInfo("Month data - 85th percentile of daily values")]
      VG_MDAT_DPERC85 = 72,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Minimum of daily values")]
      VG_MDAT_DMIN = 73,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Time of minimum daily value")]
      VG_MDAT_DMINTM = 74,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Maximum of daily values")]
      VG_MDAT_DMAX = 75,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Time of maximum daily value")]
      VG_MDAT_DMAXTM = 76,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Minimum range limit shortfalls of daily values")]
      VG_MDAT_DMINLIM = 77,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Maximum range limit shortfalls of daily values")]
      VG_MDAT_DMAXLIM = 78,
      [EnumMember]
      [SwaggerEnumInfo("Month data - Number of daily values")]
      VG_MDAT_DCOUNT = 79,

      [EnumMember]
      [SwaggerEnumInfo("Year data - Flags")]
      VG_YDAT_FLAG = 80,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Timestamp")]
      VG_YDAT_YTIME = 81,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Value")]
      VG_YDAT_YVAL = 82,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Specific time stamp of each value according to compression type")]
      VG_YDAT_YVALTM = 83,
      [EnumMember]
      [SwaggerEnumInfo("Year data - second special yearly value according to compression type")]
      VG_YDAT_YVAL1 = 84,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Specific time stamp of second special yearly value according to compression type")]
      VG_YDAT_YVAL1TM = 85,
      [EnumMember]
      [SwaggerEnumInfo("Year data - third special yearly value according to compression type")]
      VG_YDAT_YVAL2 = 86,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Specific time stamp of third special yearly value according to compression type")]
      VG_YDAT_YVAL2TM = 87,
      [EnumMember]
      [SwaggerEnumInfo("Year data - fourth special yearly value according to compression type")]
      VG_YDAT_YVAL3 = 88,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Specific time stamp of fourth special yearly value according to compression type")]
      VG_YDAT_YVAL3TM = 89,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Sum of process values")]
      VG_YDAT_PSUM = 90,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Minimum of process values")]
      VG_YDAT_PMIN = 91,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Time of minimum process value")]
      VG_YDAT_PMINTM = 92,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Maximum of process values")]
      VG_YDAT_PMAX = 93,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Time of maximum process value")]
      VG_YDAT_PMAXTM = 94,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Minimum range limit shortfalls of process values")]
      VG_YDAT_PMINLIM = 95,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Maximum range limit shortfalls of process values")]
      VG_YDAT_PMAXLIM = 96,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Number of process values")]
      VG_YDAT_PCOUNT = 97,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Sum of interval values")]
      VG_YDAT_ISUM = 98,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Minimum of interval values")]
      VG_YDAT_IMIN = 99,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Time of minimum interval value")]
      VG_YDAT_IMINTM = 100,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Maximum of interval values")]
      VG_YDAT_IMAX = 101,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Time of maximum interval value")]
      VG_YDAT_IMAXTM = 102,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Minimum range limit shortfalls of interval values")]
      VG_YDAT_IMINLIM = 103,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Maximum range limit shortfalls of interval values")]
      VG_YDAT_IMAXLIM = 104,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Number of interval values")]
      VG_YDAT_ICOUNT = 105,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Sum of daily values")]
      VG_YDAT_DSUM = 106,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Standard deviation of daily values")]
      VG_YDAT_DMIN = 107,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Time of minimum daily value")]
      VG_YDAT_DMINTM = 108,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Maximum of daily values")]
      VG_YDAT_DMAX = 109,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Time of maximum daily value")]
      VG_YDAT_DMAXTM = 110,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Minimum range limit shortfalls of daily values")]
      VG_YDAT_DMINLIM = 111,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Maximum range limit shortfalls of daily values")]
      VG_YDAT_DMAXLIM = 112,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Number of daily values")]
      VG_YDAT_DCOUNT = 113,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Sum of monthly values")]
      VG_YDAT_MSUM = 114,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Standard deviation of monthly values")]
      VG_YDAT_MSIGMA = 115,
      [EnumMember]
      [SwaggerEnumInfo("Year data - 15th percentile of monthly values")]
      VG_YDAT_MPERC15 = 116,
      [EnumMember]
      [SwaggerEnumInfo("Year data - 85th percentile of monthly values")]
      VG_YDAT_MPERC85 = 117,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Minimum of monthly values")]
      VG_YDAT_MMIN = 118,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Time of minimum monthly value")]
      VG_YDAT_MMINTM = 119,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Maximum of monthly values")]
      VG_YDAT_MMAX = 120,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Time of maximum monthly value")]
      VG_YDAT_MMAXTM = 121,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Minimum range limit shortfalls of monthly values")]
      VG_YDAT_MMINLIM = 122,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Maximum range limit shortfalls of monthly values")]
      VG_YDAT_MMAXLIM = 123,
      [EnumMember]
      [SwaggerEnumInfo("Year data - Number of monthly values")]
      VG_YDAT_MCOUNT = 124,

      [EnumMember]
      [SwaggerEnumInfo("Value key")]
      VG_VALKEY = 125,
   };

   public enum EventCellFlags : short
   {
      [EnumMember]
      [SwaggerEnumInfo("Normal cell")]
      CELL_NORMAL = 0,
      [EnumMember]
      [SwaggerEnumInfo("Cell value was replaced")]
      CELL_REPLACED = 2
   };

}
