﻿using Swashbuckle.AspNetCore.Annotations;
using System;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for auto variables
   /// </summary>
   public interface IPvAutoObject : IPvManualAutoBaseObject
   {
      #region General

      /// <summary> Formula of the process variable </summary>
      [SwaggerSchema("Formula of the process variable")]
      [SwaggerExampleValue("Füllstand KT20IL001")]
      string PropFormulaEdit { get; set; }

      /// <summary>Substitute value in case of measurement value underrun - active?</summary>
      [SwaggerSchema("Substitute value in case of measurement value underrun - active?")]
      [SwaggerExampleValue("false")]
      bool PropReplacementMinLimit { get; set; }

      /// <summary>Substitute value in case of measurement value underrun</summary>
      [SwaggerSchema("Substitute value in case of measurement value underrun")]
      [SwaggerExampleValue("0.0")]
      double PropRepValMinLimit { get; set; }

      /// <summary>Substitute value in case of measurement value underrun - value type</summary>
      [SwaggerSchema("Substitute value in case of measurement value underrun - value type")]
      [SwaggerExampleValue("FixValue")]
      PvAutoDefines.ReplacementType PropRepValMinLimitType { get; set; }

      /// <summary>Substitute value in case of measurement value overrun - active?</summary>
      [SwaggerSchema("Substitute value in case of measurement value overrun - active?")]
      [SwaggerExampleValue("false")]
      bool PropReplacementMaxLimit { get; set; }

      /// <summary>Substitute value in case of measurement value overrun</summary>
      [SwaggerSchema("Substitute value in case of measurement value overrun")]
      [SwaggerExampleValue("2.0")]
      double PropRepValMaxLimit { get; set; }

      /// <summary>Substitute value in case of measurement value overrun - Wertetyp</summary>
      [SwaggerSchema("Substitute value in case of measurement value overrun - Wertetyp")]
      [SwaggerExampleValue("LastValue")]
      PvAutoDefines.ReplacementType PropRepValMaxLimitType { get; set; }

      /// <summary>Substitute value in case of failure - active?</summary>
      [SwaggerSchema("Substitute value in case of failure - active?")]
      [SwaggerExampleValue("false")]
      bool PropReplacementLoss { get; set; }

      /// <summary>Substitute value in case of failure</summary>
      [SwaggerSchema("Substitute value in case of failure")]
      [SwaggerExampleValue("100")]
      double PropRepValLoss { get; set; }

      /// <summary>Substitute value in case of failure - value type</summary>
      [SwaggerSchema("Substitute value in case of failure - value type")]
      [SwaggerExampleValue("LastValue")]
      PvAutoDefines.ReplacementType PropRepValLossType { get; set; }

      #endregion General

      #region Interval

      /// <summary> Interval compression method</summary>
      [SwaggerSchema("Interval compression method")]
      [SwaggerExampleValue("AverageWeighted = PvBaseDefines.CompMethod.AverageWeighted,")]
      PvAutoDefines.CompIntervalMethod PropCompressionIntervalMethod { get; set; }

      #endregion Interval

      #region Tag

      /// <summary> Compression method - Day </summary>
      [SwaggerSchema("Compression method - Day")]
      [SwaggerExampleValue("Average = PvBaseDefines.CompMethod.Average,")]
      PvAutoDefines.CompDayMethod PropCompressionDayMethod { get; set; }

      #endregion Tag

      #region Monat

      /// <summary> Compression method - Month </summary>
      [SwaggerSchema("Compression method - Month")]
      [SwaggerExampleValue(" Average = PvBaseDefines.CompMethod.Average,")]
      PvAutoDefines.CompMonthMethod PropCompressionMonthMethod { get; set; }

      #endregion Monat

      #region Jahr

      /// <summary> Compression method - Year </summary>
      [SwaggerSchema("Compression method - Year")]
      [SwaggerExampleValue(" Average = PvBaseDefines.CompMethod.Average,")]
      PvAutoDefines.CompYearMethod PropCompressionYearMethod { get; set; }

      #endregion Jahr

   }

   public static class PvAutoDefines 
   {
      /// <summary> Substitute value activation</summary>
      [Flags]
      public enum ValueReplacement : uint
      {
         /// <summary> Failure </summary>
         MissingValue = 0x1,
         /// <summary> Overrun </summary>
         OverValue = 0x2,
         /// <summary> Underrun </summary>
         UnderValue = 0x4,
      }

      public enum ReplacementType : int
      {
         /// <summary> Fixed value </summary>
         FixValue = 0,
         /// <summary> Last value </summary>
         LastValue = 1,
      }

      /// <summary> Compression methods interval </summary>
      public enum CompIntervalMethod : int
      {
         /// <summary>Arithmetic mean</summary>
         Average = PvBaseDefines.CompMethod.Average,
         /// <summary>Logarithmic mean</summary>
         AverageLog = PvBaseDefines.CompMethod.AverageLog,
         /// <summary>Last value</summary>
         Last = PvBaseDefines.CompMethod.Last,
         /// <summary>First value</summary>
         First = PvBaseDefines.CompMethod.First,
         /// <summary>Frequency</summary>
         Frequency = PvBaseDefines.CompMethod.Frequency,
         /// <summary>Sum</summary>
         Sum = PvBaseDefines.CompMethod.Sum,
         /// <summary>Median</summary>
         Median = PvBaseDefines.CompMethod.Median,
         /// <summary>Percentile value</summary>
         Percentil = PvBaseDefines.CompMethod.Percentil,
         /// <summary>Standard deviation</summary>
         Sigma = PvBaseDefines.CompMethod.Sigma,
         /// <summary>Standard deviation sample</summary>
         SigmaSample = PvBaseDefines.CompMethod.SigmaSample,
         /// <summary>Weighted arithmetic mean</summary>
         AverageWeighted = PvBaseDefines.CompMethod.AverageWeighted,
         /// <summary> Concatenate (link the individual texts to a character string) </summary>
         Link = PvBaseDefines.CompMethod.Link,
         /// <summary> Concatenate (link the individual texts to a character string without duplicates) </summary>
         LinkWithoutDuplicates = PvBaseDefines.CompMethod.LinkWithoutDuplicates,
      }

      /// <summary> Compression methods day </summary>
      public enum CompDayMethod : int
      {
         /// <summary>Arithmetic mean</summary>
         Average = PvBaseDefines.CompMethod.Average,
         /// <summary>Logarithmic mean</summary>
         AverageLog = PvBaseDefines.CompMethod.AverageLog,
         /// <summary>Last value</summary>
         Last = PvBaseDefines.CompMethod.Last,
         /// <summary>First value</summary>
         First = PvBaseDefines.CompMethod.First,
         /// <summary>Frequency</summary>
         Frequency = PvBaseDefines.CompMethod.Frequency,
         /// <summary>Sum</summary>
         Sum = PvBaseDefines.CompMethod.Sum,
         /// <summary>Median</summary>
         Median = PvBaseDefines.CompMethod.Median,
         /// <summary>Percentile value</summary>
         Percentil = PvBaseDefines.CompMethod.Percentil,
         /// <summary>Standard deviation</summary>
         Sigma = PvBaseDefines.CompMethod.Sigma,
         /// <summary>Standard deviation sample</summary>
         SigmaSample = PvBaseDefines.CompMethod.SigmaSample,
         /// <summary> Concatenate (link the individual texts to a character string) </summary>
         Link = PvBaseDefines.CompMethod.Link,
         /// <summary> Concatenate (link the individual texts to a character string without duplicates) </summary>
         LinkWithoutDuplicates = PvBaseDefines.CompMethod.LinkWithoutDuplicates,
      }

      /// <summary> Compression methods month </summary>
      public enum CompMonthMethod : int
      {
         /// <summary>Arithmetic mean</summary>
         Average = PvBaseDefines.CompMethod.Average,
         /// <summary>Arithmetic mean in the range (5-95%)</summary>
         Average95 = PvBaseDefines.CompMethod.Average95,
         /// <summary>Logarithmic mean</summary>
         AverageLog = PvBaseDefines.CompMethod.AverageLog,
         /// <summary>Last value</summary>
         Last = PvBaseDefines.CompMethod.Last,
         /// <summary>First value</summary>
         First = PvBaseDefines.CompMethod.First,
         /// <summary>Frequency</summary>
         Frequency = PvBaseDefines.CompMethod.Frequency,
         /// <summary>Sum</summary>
         Sum = PvBaseDefines.CompMethod.Sum,
         /// <summary>Median</summary>
         Median = PvBaseDefines.CompMethod.Median,
         /// <summary>Percentile value</summary>
         Percentil = PvBaseDefines.CompMethod.Percentil,
         /// <summary>Standard deviation</summary>
         Sigma = PvBaseDefines.CompMethod.Sigma,
         /// <summary>Standard deviation sample</summary>
         SigmaSample = PvBaseDefines.CompMethod.SigmaSample,
         /// <summary> Concatenate (link the individual texts to a character string) </summary>
         Link = PvBaseDefines.CompMethod.Link,
         /// <summary> Concatenate (link the individual texts to a character string without duplicates) </summary>
         LinkWithoutDuplicates = PvBaseDefines.CompMethod.LinkWithoutDuplicates,
      }

      /// <summary> Compression methods year </summary>
      public enum CompYearMethod : int
      {
         /// <summary>Arithmetic mean</summary>
         Average = PvBaseDefines.CompMethod.Average,
         /// <summary>Logarithmic mean</summary>
         AverageLog = PvBaseDefines.CompMethod.AverageLog,
         /// <summary>Last value</summary>
         Last = PvBaseDefines.CompMethod.Last,
         /// <summary>First value</summary>
         First = PvBaseDefines.CompMethod.First,
         /// <summary>Frequency</summary>
         Frequency = PvBaseDefines.CompMethod.Frequency,
         /// <summary>Sum</summary>
         Sum = PvBaseDefines.CompMethod.Sum,
         /// <summary>Median</summary>
         Median = PvBaseDefines.CompMethod.Median,
         /// <summary>Percentile value</summary>
         Percentil = PvBaseDefines.CompMethod.Percentil,
         /// <summary>Standard deviation</summary>
         Sigma = PvBaseDefines.CompMethod.Sigma,
         /// <summary>Standard deviation sample</summary>
         SigmaSample = PvBaseDefines.CompMethod.SigmaSample,
         /// <summary> Concatenate (link the individual texts to a character string) </summary>
         Link = PvBaseDefines.CompMethod.Link,
         /// <summary> Concatenate (link the individual texts to a character string without duplicates) </summary>
         LinkWithoutDuplicates = PvBaseDefines.CompMethod.LinkWithoutDuplicates,
      }

      /// <summary> Constant for the substitute value - use the last value </summary>
      public const double UseLastValue = +1.1e+36f;

   }
}