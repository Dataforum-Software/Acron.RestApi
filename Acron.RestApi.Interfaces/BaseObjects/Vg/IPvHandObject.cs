using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for manual variables
   /// </summary>
   public interface IPvManualObject : IPvManualAutoBaseObject
   {
      /// <summary>Manual value has the key VGHVAL_KEY</summary>
      [SwaggerSchema("Manual value has the key VGHVAL_KEY")]
      [SwaggerExampleValue("false")]
      bool PropHValUseKey
      {
         get; set;
      }

      /// <summary>
      /// Base object ID of the assigned external variable 
      /// </summary>
      [SwaggerSchema("Base object id of the assigned external variable")]
      [SwaggerExampleValue("104000026")]
      int PropIdExternalVariable
      {
         get; set;
      }

      /// <summary>Possible manual value capture (by the day, by the week, ...)</summary>
      [SwaggerSchema("Possible manual value capture (by the day, by the week, ...)")]
      [SwaggerExampleValue("PerDay")]
      PvManualDefines.VgHValEdit PropHedit
      {
         get; set;
      }

      /// <summary>Key to a manual value </summary>
      [SwaggerSchema("Key to a manual value")]
      [SwaggerExampleValue("")]
      string PropHvalKey
      {
         get; set;
      }

      /// <summary>Manual value times (there can be several )</summary>
      [SwaggerSchema("Manual value times (there can be several)")]
      [SwaggerExampleValue("(1,43200)")]
      Dictionary<int, int> PropHandValueTimeStamps
      {
         get; set;
      }

      /// <summary> Interval compression method</summary>
      [SwaggerSchema("Interval compression method")]
      [SwaggerExampleValue("Frequency = PvBaseDefines.CompMethod.Frequency")]
      PvManualDefines.CompIntervalMethod PropCompressionIntervalMethod
      {
         get; set;
      }

      /// <summary> Daily compression methode</summary>
      [SwaggerSchema("Daily compression method")]
      [SwaggerExampleValue("Average")]
      PvManualDefines.CompDayMethod PropCompressionDayMethod
      {
         get; set;
      }

      /// <summary> Monthly compression methode</summary>
      [SwaggerSchema("Monthly compression method")]
      [SwaggerExampleValue("Average")]
      PvManualDefines.CompMonthMethod PropCompressionMonthMethod
      {
         get; set;
      }

      /// <summary> Annual compression methode</summary>
      [SwaggerSchema("Annual compression methode")]
      [SwaggerExampleValue("Average")]
      PvManualDefines.CompYearMethod PropCompressionYearMethod
      {
         get; set;
      }

   }

   public static class PvManualDefines
   {
      /// <summary>Capture mode of manual values</summary>
      public enum VgHValEdit : int
      {
         /// <summary>Manual value recording on a daily basis (HEDIT_DAY)</summary>
         PerDay = 0,
         /// <summary>Manual value capture on a weekly basis (HEDIT_WEEK)</summary>
         PerWeek = 1,
         /// <summary>Manual valuation on a monthly basis (HEDIT_MON)</summary>
         PerMonth = 2,
         /// <summary>Manual value capture annually (HEDIT_YEAR)</summary>
         PerYear = 3,
      }

      /// <summary> Compression methods interval  </summary>
      public enum CompIntervalMethod : int
      {
         /// <summary>Arithmetic mean </summary>
         Average = PvBaseDefines.CompMethod.Average,
         /// <summary>Logarithmic mean </summary>
         AverageLog = PvBaseDefines.CompMethod.AverageLog,
         /// <summary>Last value</summary>
         Last = PvBaseDefines.CompMethod.Last,
         /// <summary>First value</summary>
         First = PvBaseDefines.CompMethod.First,
         /// <summary>Frequency </summary>
         Frequency = PvBaseDefines.CompMethod.Frequency,
         /// <summary>Sum</summary>
         Sum = PvBaseDefines.CompMethod.Sum,
         /// <summary>Median</summary>
         Median = PvBaseDefines.CompMethod.Median,
         /// <summary>Standard deviation </summary>
         Sigma = PvBaseDefines.CompMethod.Sigma,
         /// <summary>Standard deviation sample</summary>
         SigmaSample = PvBaseDefines.CompMethod.SigmaSample,
         /// <summary>Weighted mean</summary>
         AverageWeighted = PvBaseDefines.CompMethod.AverageWeighted,
         /// <summary> Concatenate (link the individual texts to a character string ) </summary>
         Link = PvBaseDefines.CompMethod.Link,
         /// <summary> Concatenate (link the individual texts to a character string - without duplicates) </summary>
         LinkWithoutDuplicates = PvBaseDefines.CompMethod.LinkWithoutDuplicates,
      }

      /// <summary> Compression methods day </summary>
      public enum CompDayMethod : int
      {
         /// <summary>Arithmetic mean </summary>
         Average = PvBaseDefines.CompMethod.Average,
         /// <summary>Logarithmic mean </summary>
         AverageLog = PvBaseDefines.CompMethod.AverageLog,
         /// <summary>Last value</summary>
         Last = PvBaseDefines.CompMethod.Last,
         /// <summary>First value</summary>
         First = PvBaseDefines.CompMethod.First,
         /// <summary>Frequency </summary>
         Frequency = PvBaseDefines.CompMethod.Frequency,
         /// <summary>Sum</summary>
         Sum = PvBaseDefines.CompMethod.Sum,
         /// <summary>Median</summary>
         Median = PvBaseDefines.CompMethod.Median,
         /// <summary>Percentile value</summary>
         Percentil = PvBaseDefines.CompMethod.Percentil,
         /// <summary>Standard deviation </summary>
         Sigma = PvBaseDefines.CompMethod.Sigma,
         /// <summary>Standard deviation sample</summary>
         SigmaSample = PvBaseDefines.CompMethod.SigmaSample,
         /// <summary> Concatenate (link the individual texts to a character string ) </summary>
         Link = PvBaseDefines.CompMethod.Link,
         /// <summary> Concatenate (link the individual texts to a character string - without duplicates) </summary>
         LinkWithoutDuplicates = PvBaseDefines.CompMethod.LinkWithoutDuplicates,
      }

      /// <summary> Compression methods month </summary>
      public enum CompMonthMethod : int
      {
         /// <summary>Arithmetic mean </summary>
         Average = PvBaseDefines.CompMethod.Average,
         /// <summary>Arithmetic mean in the range (5-95%)</summary>
         Average95 = PvBaseDefines.CompMethod.Average95,
         /// <summary>Logarithmic mean </summary>
         AverageLog = PvBaseDefines.CompMethod.AverageLog,
         /// <summary>Last value</summary>
         Last = PvBaseDefines.CompMethod.Last,
         /// <summary>First value</summary>
         First = PvBaseDefines.CompMethod.First,
         /// <summary>Frequency </summary>
         Frequency = PvBaseDefines.CompMethod.Frequency,
         /// <summary>Sum</summary>
         Sum = PvBaseDefines.CompMethod.Sum,
         /// <summary>Median</summary>
         Median = PvBaseDefines.CompMethod.Median,
         /// <summary>Percentile value</summary>
         Percentil = PvBaseDefines.CompMethod.Percentil,
         /// <summary>Standard deviation </summary>
         Sigma = PvBaseDefines.CompMethod.Sigma,
         /// <summary>Standard deviation sample</summary>
         SigmaSample = PvBaseDefines.CompMethod.SigmaSample,
         /// <summary> Concatenate (link the individual texts to a character string ) </summary>
         Link = PvBaseDefines.CompMethod.Link,
         /// <summary> Concatenate (link the individual texts to a character string - without duplicates) </summary>
         LinkWithoutDuplicates = PvBaseDefines.CompMethod.LinkWithoutDuplicates,
      }

      /// <summary> Compression methods year </summary>
      public enum CompYearMethod : int
      {
         /// <summary>Arithmetic mean </summary>
         Average = PvBaseDefines.CompMethod.Average,
         /// <summary>Logarithmic mean </summary>
         AverageLog = PvBaseDefines.CompMethod.AverageLog,
         /// <summary>Last value</summary>
         Last = PvBaseDefines.CompMethod.Last,
         /// <summary>First value</summary>
         First = PvBaseDefines.CompMethod.First,
         /// <summary>Frequency </summary>
         Frequency = PvBaseDefines.CompMethod.Frequency,
         /// <summary>Sum</summary>
         Sum = PvBaseDefines.CompMethod.Sum,
         /// <summary>Median</summary>
         Median = PvBaseDefines.CompMethod.Median,
         /// <summary>Percentile value</summary>
         Percentil = PvBaseDefines.CompMethod.Percentil,
         /// <summary>Standard deviation </summary>
         Sigma = PvBaseDefines.CompMethod.Sigma,
         /// <summary>Standard deviation sample</summary>
         SigmaSample = PvBaseDefines.CompMethod.SigmaSample,
         /// <summary> Concatenate (link the individual texts to a character string ) </summary>
         Link = PvBaseDefines.CompMethod.Link,
         /// <summary> Concatenate (link the individual texts to a character string - without duplicates) </summary>
         LinkWithoutDuplicates = PvBaseDefines.CompMethod.LinkWithoutDuplicates,
      }

   }
}
