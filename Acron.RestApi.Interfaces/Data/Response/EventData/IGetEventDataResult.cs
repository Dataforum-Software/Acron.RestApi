using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
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
      EVENT_OK = 0,
      EVENT_PARA = 1,
      EVENT_READFAILED = 2,
      EVENT_READMAX = 3,
      EVENT_READCANCELD = 4,
      EVENT_SERVERERROR = 5,
   };

   [Flags]
   public enum EventBaseFlags
   {
      EBASE_MILLISEC_FROM = 0x1, //Genauigkeit der Start und Stoppwerte
      EBASE_MILLISEC_TO = 0x2,
      EBASE_SANCTION = 0x4,   //Zwangsschließung
      EBASE_INVALID = 0x8, //üngültiges Event, hat nicht's mit gelöschten Events's an der Hacke
      EBASE_CONVERTED_83 = 0x10,	//Id wurde zu 83 konvertiert- nur für den Notfall
   }

   [Flags]
   public enum EventFlags
   {
      EVENT_DEL = 0x1,     //Event ist gelöscht
      EVENT_FORMCALC = 0x2,      //Event fiel bei Filter durch (EFormCalc)
      EVENT_OPEN = 0x4,    //Subevent kommt von eimem offenen Event
      EVENT_HAND = 0x8,    //Event wurde manuell angelegt
      EVENT_MARK = 0x10		//beliebige Markierung eines Events
   }

   public enum EventCellTypes : short
   {
      CELL_UNKNOWN = 0,
      CELL_DATE = 1,
      CELL_TIME = 2,
      CELL_BATCHID = 3,
      CELL_DURATION = 4,
      CELL_BCOUNT = 5,
      CELL_TEXT = 6,
      CELL_VGBATCH = 8,
      CELL_OVER = 9,
      CELL_INPUT = 10,
      CELL_CALC = 11,
      CELL_PSTAMP = 12, //Zeitstempel für Prozessdaten
      CELL_ISTAMP1 = 13, //Zeitstempel für Intervalldaten(Hauptintervall)
      CELL_ISTAMP2 = 14, //Zeitstempel für Intervalldaten(Nebenintervall)
   };

   public enum EventCellKeys
   {
      CELLKEY_UNKNOWN = 0,
      CELLKEY_START = 1,
      CELLKEY_STOP = 2,
      CELLKEY_STAT = 3,
   };

   public enum ID_GEN_TYPE : short
   {
      ID_BAUTOVG = 0,
      ID_BHAND = 1,
      ID_BACRON = 2
   };

   public enum ProcessVariableValueTypes
   {
      VG_DAT_UNKNOWN = -1,

      VG_PDAT_PFLAG = 0,
      VG_PDAT_PTIME = 1,
      VG_PDAT_PVAL = 2,
      VG_PDAT_PMIN = 3,
      VG_PDAT_PMAX = 4,

      VG_IDAT_IFLAG = 5,
      VG_IDAT_ITIME = 6,
      VG_IDAT_IVAL = 7,
      VG_IDAT_PSUM = 8,
      VG_IDAT_PSIGMA = 9,
      VG_IDAT_PPERC15 = 10,
      VG_IDAT_PPERC85 = 11,
      VG_IDAT_PMIN = 12,
      VG_IDAT_PMINTM = 13,
      VG_IDAT_PMAX = 14,
      VG_IDAT_PMAXTM = 15,
      VG_IDAT_PMINLIM = 16,
      VG_IDAT_PMAXLIM = 17,
      VG_IDAT_PCOUNT = 18,

      VG_DDAT_DFLAG = 19,
      VG_DDAT_DTIME = 20,
      VG_DDAT_DVAL = 21,
      VG_DDAT_DVALTM = 22,
      VG_DDAT_DVALAVG = 23,
      VG_DDAT_PSUM = 24,
      VG_DDAT_PMIN = 25,
      VG_DDAT_PMINTM = 26,
      VG_DDAT_PMAX = 27,
      VG_DDAT_PMAXTM = 28,
      VG_DDAT_PMINLIM = 29,
      VG_DDAT_PMAXLIM = 30,
      VG_DDAT_PCOUNT = 31,
      VG_DDAT_ISUM = 32,
      VG_DDAT_ISIGMA = 33,
      VG_DDAT_IPERC15 = 34,
      VG_DDAT_IPERC85 = 35,
      VG_DDAT_IMIN = 36,
      VG_DDAT_IMINTM = 37,
      VG_DDAT_IMAX = 38,
      VG_DDAT_IMAXTM = 39,
      VG_DDAT_IMINLIM = 40,
      VG_DDAT_IMAXLIM = 41,
      VG_DDAT_ICOUNT = 42,

      VG_MDAT_FLAG = 43,
      VG_MDAT_MTIME = 44,
      VG_MDAT_MVAL = 45,
      VG_MDAT_MVALTM = 46,
      VG_MDAT_MVAL1 = 47,
      VG_MDAT_MVAL1TM = 48,
      VG_MDAT_MVAL2 = 49,
      VG_MDAT_MVAL2TM = 50,
      VG_MDAT_MVAL3 = 51,
      VG_MDAT_MVAL3TM = 52,
      VG_MDAT_PSUM = 53,
      VG_MDAT_PMIN = 54,
      VG_MDAT_PMINTM = 55,
      VG_MDAT_PMAX = 56,
      VG_MDAT_PMAXTM = 57,
      VG_MDAT_PMINLIM = 58,
      VG_MDAT_PMAXLIM = 59,
      VG_MDAT_PCOUNT = 60,
      VG_MDAT_ISUM = 61,
      VG_MDAT_IMIN = 62,
      VG_MDAT_IMINTM = 63,
      VG_MDAT_IMAX = 64,
      VG_MDAT_IMAXTM = 65,
      VG_MDAT_IMINLIM = 66,
      VG_MDAT_IMAXLIM = 67,
      VG_MDAT_ICOUNT = 68,
      VG_MDAT_DSUM = 69,
      VG_MDAT_DSIGMA = 70,
      VG_MDAT_DPERC15 = 71,
      VG_MDAT_DPERC85 = 72,
      VG_MDAT_DMIN = 73,
      VG_MDAT_DMINTM = 74,
      VG_MDAT_DMAX = 75,
      VG_MDAT_DMAXTM = 76,
      VG_MDAT_DMINLIM = 77,
      VG_MDAT_DMAXLIM = 78,
      VG_MDAT_DCOUNT = 79,

      VG_YDAT_FLAG = 80,
      VG_YDAT_YTIME = 81,
      VG_YDAT_YVAL = 82,
      VG_YDAT_YVALTM = 83,
      VG_YDAT_YVAL1 = 84,
      VG_YDAT_YVAL1TM = 85,
      VG_YDAT_YVAL2 = 86,
      VG_YDAT_YVAL2TM = 87,
      VG_YDAT_YVAL3 = 88,
      VG_YDAT_YVAL3TM = 89,
      VG_YDAT_PSUM = 90,
      VG_YDAT_PMIN = 91,
      VG_YDAT_PMINTM = 92,
      VG_YDAT_PMAX = 93,
      VG_YDAT_PMAXTM = 94,
      VG_YDAT_PMINLIM = 95,
      VG_YDAT_PMAXLIM = 96,
      VG_YDAT_PCOUNT = 97,
      VG_YDAT_ISUM = 98,
      VG_YDAT_IMIN = 99,
      VG_YDAT_IMINTM = 100,
      VG_YDAT_IMAX = 101,
      VG_YDAT_IMAXTM = 102,
      VG_YDAT_IMINLIM = 103,
      VG_YDAT_IMAXLIM = 104,
      VG_YDAT_ICOUNT = 105,
      VG_YDAT_DSUM = 106,
      VG_YDAT_DMIN = 107,
      VG_YDAT_DMINTM = 108,
      VG_YDAT_DMAX = 109,
      VG_YDAT_DMAXTM = 110,
      VG_YDAT_DMINLIM = 111,
      VG_YDAT_DMAXLIM = 112,
      VG_YDAT_DCOUNT = 113,
      VG_YDAT_MSUM = 114,
      VG_YDAT_MSIGMA = 115,
      VG_YDAT_MPERC15 = 116,
      VG_YDAT_MPERC85 = 117,
      VG_YDAT_MMIN = 118,
      VG_YDAT_MMINTM = 119,
      VG_YDAT_MMAX = 120,
      VG_YDAT_MMAXTM = 121,
      VG_YDAT_MMINLIM = 122,
      VG_YDAT_MMAXLIM = 123,
      VG_YDAT_MCOUNT = 124,

      VG_VALKEY = 125,
   };

   public enum EventCellFlags : short
   {
      CELL_NORMAL = 0,
      CELL_REPLACED = 2
   };

}
