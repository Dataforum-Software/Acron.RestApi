using Acron.RestApi.DataContracts.Data.GlobalDataDefines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Frontend.Models
{
   internal class VisualisationHelper
   {
      #region ctor
      public VisualisationHelper()
      {
         _timeStamp = DateTime.Now;
         IValue = 0;
         _minValue = 0;
         _maxValue = 0;
      }
      #endregion

      #region Values
      public DateTime _timeStamp;
      private double _iValue;
      private double _maxValue;
      #endregion

      #region AccessResults
      public DateTime TimesStamp
      {
         get { return _timeStamp + TimeZoneInfo.Local.GetUtcOffset(DateTime.Now); }
         set
         {
            _timeStamp = value;
         }
      }
      public double IValue
      {
         get { return _iValue; }
         set
         {
            _iValue = value;
         }
      }
      public double? NullableIValue
      {
         get
         {
            if (_iValue == GlobalDataDef.NO_VALID)
               return null;
            else
               return _iValue;
         }
         set
         {
            if (value.HasValue)
               _iValue = value.Value;
            else
               _iValue = GlobalDataDef.NO_VALID;
         }
      }


      private double _minValue;
      public double MinValue
      {
         get
         {
            return _minValue;
         }
         set { _minValue = value; }
      }
      public double? NullableMinValue
      {
         get
         {
            if (_minValue == GlobalDataDef.NO_VALID)
               return null;
            else
               return _minValue;
         }
         set
         {
            if (value.HasValue)
               _minValue = value.Value;
            else
               _minValue = GlobalDataDef.NO_VALID;
         }
      }
      public double MaxValue
      {
         get { return _maxValue; }
         set
         {
            _maxValue=value;
         }
      }

      public double? NullableMaxValue
      {
         get
         {
            if (_maxValue == GlobalDataDef.NO_VALID)
               return null;
            else
            {
               return _maxValue;
            }
         }
         set
         {
            if (value.HasValue)
               _maxValue = value.Value;
            else
               _maxValue = GlobalDataDef.NO_VALID;
         }
      }
      #endregion
   }
}
