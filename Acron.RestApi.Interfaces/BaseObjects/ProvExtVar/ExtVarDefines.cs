namespace Acron.RestApi.Interfaces.BaseObjects
{
   public static class ExtVarDefines
   {
      #region ExtVar

      /// <summary> Measurement archival - Type</summary>
      public enum MeasurementRecordingType : int
      {
         /// <summary>current value</summary>
         [SwaggerEnumInfo("Current value")]
         ActualValue = 0,

         /// <summary>mean value</summary>
         [SwaggerEnumInfo("Mean value")]
         MediumValue = 1,
      }

      /// <summary> Data types for measurement  - !!! Database connection to C/C++ !!!</summary>
      public enum DbpDataType : uint
      {
         /// <summary>Unknown - is invalid and must not be used</summary>
         [SwaggerEnumInfo("Invalid")]
         DbpUnknown = 0,

         /// <summary>4 Byte integer - unsigned</summary>
         [SwaggerEnumInfo("unsigned 4 Byte integer")]
         DbpInt4 = 3,

         /// <summary>4 Byte integer - signed</summary>
         [SwaggerEnumInfo("signed 4 Byte integer")]
         DbpSint4 = 9,

         /// <summary>2 Byte integer - unsigned</summary>
         [SwaggerEnumInfo("unsigned 2 Byte integer")]
         DbpInt2 = 2,

         /// <summary>2 Byte integer - signed</summary>
         [SwaggerEnumInfo("signed 2 Byte integer")]
         DbpSint2 = 8,

         /// <summary>Integer in the range  0 - 1 (DBP_INT1)</summary>
         [SwaggerEnumInfo("Integer 0 or 1")]
         DbpInt1 = 1,

         /// <summary>4 byte real</summary>
         [SwaggerEnumInfo("Signed floating point number, 7 significant digits")]
         DbpReal4 = 4,

         /// <summary>8 byte real</summary>
         [SwaggerEnumInfo("Signed floating point number, 14 significant digits")]
         DbpReal8 = 5,

         /// <summary>char arbitrary number of characters</summary>
         [SwaggerEnumInfo("Variable length string, ASCII encoding")]
         DbpChar = 13,

         /// <summary>wchar arbitrary number of characters</summary>
         [SwaggerEnumInfo("Variable length string, Unicode encoding")]
         DbpWchar = 14,

         /// <summary>char 16 characters</summary>
         [SwaggerEnumInfo("Fixed length string, 16 characters")]
         DbpChar16 = 6,

         /// <summary>char 64 characters</summary>
         [SwaggerEnumInfo("Fixed length string, 64 characters")]
         DbpChar64 = 7,

         /// <summary>char 128 characters</summary>
         [SwaggerEnumInfo("Fixed length string, 128 characters")]
         DbpChar128 = 10,

         /// <summary>char 256 characters</summary>
         [SwaggerEnumInfo("Fixed length string, 256 characters")]
         DbpChar256 = 11,

         /// <summary>char 512 characters</summary>
         [SwaggerEnumInfo("Fixed length string, 512 characters")]
         DbpChar512 = 12,

         /// <summary>Last value - always contains the last (==greatest) value, is invalid und must not be used</summary>
         [SwaggerEnumInfo("Deprecated")]
         DbpLastValue = 15,
      };

      /// <summary>
      /// Data types for maintenance - !!! Database connection to C/C++ !!!
      /// </summary>
      public enum ServiceType : int
      {
         /// <summary> Binary value </summary>
         [SwaggerEnumInfo("Binary value")]
         Impuls,

         /// <summary> Duration </summary>
         [SwaggerEnumInfo("Operation time")]
         Runtime,

         /// <summary> Switching cycles </summary>
         [SwaggerEnumInfo("Switching cycles")]
         Switches,
      }

      /// <summary>
      /// Unit service duration
      /// </summary>
      public enum ServiceUnit : int
      {
         /// <summary> Seconds </summary>
         [SwaggerEnumInfo("Value in seconds")]
         Seconds = 1,

         /// <summary> Minutes </summary>
         [SwaggerEnumInfo("Value in minutes")]
         Minutes = 2,

         /// <summary> Hours </summary>
         [SwaggerEnumInfo("Value in hours")]
         Hours = 3,

         /// <summary> Industrial minutes - hundredths of a minute </summary>
         [SwaggerEnumInfo("Value in hundredths of a minute")]
         IndustrialMinutes = 4,
      }

      #endregion ExtVar

   }
}
