using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   public interface IWriteHandValRawDataAndInfos<FlagType> where FlagType : IWriteHandValRawDataAndInfoFlag
   {
      public DateTime TimeStamp { get; set; }
      public WriteHandValRawDataAndInfoTypes ProvalType { get; }
      public short MilliSeconds { get; set; }
      public double Value { get; set; } //Wenn ProvalType = Numeric
      public string StringValue { get; set; } //Wenn ProvalType = Text

      FlagType ProInfoFlag { get; set; }
      string Key { get; set; }  //Optionaler Schlüssel 9 Unicode Zeichen
   }

   public enum WriteHandValRawDataAndInfoTypes : short
   {
      Numeric = 0,
      Text = 1,
   }

}
