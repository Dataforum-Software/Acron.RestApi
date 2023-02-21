using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for provider drivers
   /// </summary>
   public interface IProviderDriverObject : IBaseObject
   {
      /// <summary>
      /// Provides the driver version (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the driver version (from the TDriverInfo structure).")]
      [SwaggerExampleValue("9.4")]
      string PropVersion
      {
         get;
      }

      /// <summary>
      /// Provides the description for this driver (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the description for this driver (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      string PropDescription
      {
         get;
      }

      /// <summary>
      /// Provides the description for the first driver parameter (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the description for the first driver parameter (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      string PropParam1Text
      {
         get;
      }

      /// <summary>
      /// Provides the default value for the first driver parameter (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the default value for the first driver parameter (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      string PropParam1Default
      {
         get;
      }

      /// <summary>
      /// Provides the description for the second driver parameter (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the description for the second driver parameter (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      string PropParam2Text
      {
         get;
      }

      /// <summary>
      /// Provides the default value for the second driver parameter (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the default value for the second driver parameter (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      string PropParam2Default
      {
         get;
      }

      /// <summary>
      /// Provides the description for the third driver parameter (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the description for the third driver parameter (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      string PropParam3Text
      {
         get;
      }

      /// <summary>
      /// Provides the deafault value for the third driver parameter (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the deafault value for the third driver parameter (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      string PropParam3Default
      {
         get;
      }

      /// <summary>
      /// Provides the description for the fourth driver parameter (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the description for the fourth driver parameter (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      string PropParam4Text
      {
         get;
      }

      /// <summary>
      /// Provides the default value for the fourth driver parameter (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the default value for the fourth driver parameter (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      string PropParam4Default
      {
         get;
      }

      /// <summary>
      /// Provides the drivers predefined reading interval  (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the drivers predefined reading interval  (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      int PropReadingInterval
      {
         get;
      }

      /// <summary>
      /// Provides the drivers predefined start delay (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the drivers predefined start delay (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      int PropStartupDelayTime
      {
         get;
      }

      /// <summary>
      /// Provides the drivers connection type (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the drivers connection type (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      char PropConnectionType
      {
         get;
      }

      /// <summary>
      /// Provides the drivers transfer type (from the TDriverInfo structure).
      /// </summary>
      /// 
      [SwaggerSchema("Provides the drivers transfer type (from the TDriverInfo structure).")]
      [SwaggerExampleValue("")]
      char PropTransferType
      {
         get;
      }

   }
}