using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Base interface for auto and manual variable (Base only, no instances)
   /// </summary>
   public interface IPvManualAutoBaseObject : IPvBaseObject
   {
      /// <summary> Process values with milliseconds </summary>
      [SwaggerSchema("Process values with milliseconds")]
      [SwaggerExampleValue("false")]
      bool PropUseMilliseconds
      {
         get; set;
      }

      /// <summary> Perpetuate process values until the next change </summary>
      [SwaggerSchema("Perpetuate process values until the next change")]
      [SwaggerExampleValue("false")]
      bool PropValueReAssess
      {
         get; set;
      }

      /// <summary> Fill in missing process values for the day </summary>
      [SwaggerSchema("Fill in missing process values for the day")]
      [SwaggerExampleValue("false")]
      bool PropValueFillUp
      {
         get; set;
      }

      /// <summary> Meter management is active </summary>
      [SwaggerSchema("Meter management is active")]
      [SwaggerExampleValue("false")]
      bool PropCounterManagement
      {
         get; set;
      }

      /// <summary>Measurement range minimum</summary>
      [SwaggerSchema("Measurement range minimum")]
      [SwaggerExampleValue("1.0")]
      double PropMvalMin
      {
         get; set;
      }

      /// <summary>Measurement range maximum</summary>
      [SwaggerSchema("Measurement range maximum")]
      [SwaggerExampleValue("7.0")]
      double PropMvalMax
      {
         get; set;
      }

      /// <summary>Process data value handling</summary>
      [SwaggerSchema("Process data value handling")]
      [SwaggerExampleValue("Diff")]
      PvManualAutoBaseDefines.CompMethodBase PropProMethod
      {
         get; set;
      }

      /// <summary>Overflow value container content</summary>
      [SwaggerSchema("Overflow value container content")]
      [SwaggerExampleValue(0.0)]
      double PropProOverflow
      {
         get; set;
      }

      /// <summary>Difference to the previous value - Always nonnegative</summary>
      [SwaggerSchema("Difference to the previous value - Always non-negative")]
      [SwaggerExampleValue("false")]
      bool PropProPositiveDifference
      {
         get; set;
      }

      /// <summary>Processing of difference values </summary>
      [SwaggerSchema("Processing of difference values")]
      [SwaggerExampleValue("AbsoluteValue")]
      PvManualAutoBaseDefines.ProDifferenceHandling PropProDifferenceHandling
      {
         get; set;
      }

      /// <summary>Consumption from container contents  - Hysteresis</summary>
      [SwaggerSchema("Consumption from container contents  - Hysteresis")]
      [SwaggerExampleValue(0.0)]
      double PropProHysteresis
      {
         get; set;
      }

      /// <summary>Counter difference with variable overflow - Maximum difference to the previous value </summary>
      [SwaggerSchema("Counter difference with variable overflow - Maximum difference to the previous value")]
      [SwaggerExampleValue(0.0)]
      double PropProValidDifference
      {
         get; set;
      }

      //bool PvCounterSet(int index);
      //bool PvCounterGet(int index);
   }

   public static class PvManualAutoBaseDefines
   {
      /// <summary> Base value handling of values for auto and manual variables</summary>
      [SwaggerSchema("Value handling type")]
      public enum CompMethodBase : int
      {
         /// <summary>no value handling </summary>
         [SwaggerEnumInfo("No value handling")]
         None = 0,

         /// <summary>Difference to the previous value </summary>
         [SwaggerEnumInfo("Difference to previous value")]
         Diff = 1,

         /// <summary>Counter difference without overflow </summary>
         [SwaggerEnumInfo("Counter difference - no overflow")]
         CounterDiff = 2,

         /// <summary>Counter difference with overflow </summary>
         [SwaggerEnumInfo("Counter difference")]
         CounterDiffOverflow = 3,

         /// <summary>Consumption from container content </summary>
         [SwaggerEnumInfo("Consumption from container content")]
         Hyst = 4,

         /// <summary>Operating hours from the condition bit </summary>
         [SwaggerEnumInfo("Operating hours from condition bit")]
         ZuBit = 5,

         /// <summary>Integral</summary>
         [SwaggerEnumInfo("Integral")]
         Integral = 6,

         /// <summary>Predecessor</summary>
         [SwaggerEnumInfo("Predecessor value")]
         Predecessor = 30,
      }

      /// <summary>
      /// Value handling of difference values 
      /// </summary>
      [SwaggerSchema("Value handling of difference values")]
      public enum ProDifferenceHandling : int
      {
         /// <summary> Use all values </summary>
         [SwaggerEnumInfo("Use all values")]
         All = 0,

         /// <summary> Use absolute values </summary>
         [SwaggerEnumInfo("Use absolute values")]
         AbsoluteValue,

         /// <summary> Ignore negative differences </summary>
         [SwaggerEnumInfo("Ignore negative difference")]
         IgnoreNegative,
      }

   }
}
