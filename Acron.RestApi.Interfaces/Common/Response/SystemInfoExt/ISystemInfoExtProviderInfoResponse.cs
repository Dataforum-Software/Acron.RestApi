using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Response.SystemInfoExt
{
   public interface ISystemInfoExtProviderInfoResponse
   {
      [SwaggerSchema("Unique provider ID")]
      [SwaggerExampleValue(4)]
      ushort ProviderNumber { get; }

      [SwaggerSchema("Name of the provider")]
      [SwaggerExampleValue("Provider 1")]
      string PartnerName { get; }

      [SwaggerSchema("TCP/IP adress of the provider")]
      [SwaggerExampleValue("MyPC")]
      string PartnerAddress { get; }

      [SwaggerSchema("Name of redundant provider")]
      [SwaggerExampleValue("Provider 2")]
      string RedundantPartnerName { get; }

      [SwaggerSchema("TCP/IP adress of redundant provider")]
      [SwaggerExampleValue("MyPC")]
      string RedundantPartnerAddress { get; }

      [SwaggerSchema("Status of provider")]
      [SwaggerExampleValue("PROVIDER_NOT_RUNNING")]
      ProviderStatusType ProviderStatus { get; }

      [SwaggerSchema("Indicates whether the provider is running and if it was started as a service or an application.")]
      [SwaggerExampleValue("AC_SERVICE_RUNNING_APPLICATION")]
      TProgStatus ProviderServerStatus { get; }

      [SwaggerSchema("Timestamp of last provided value")]
      [SwaggerExampleValue("2024-06-17T08:31:19+02:00")]
      DateTime LastValueTime { get; }

      [SwaggerSchema($"{nameof(LastValueTime)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2024-06-17T07:22:37")]
      string LastValueTime_FORMATTED {  get; }
   }

}
