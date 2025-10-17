using Acron.RestApi.Interfaces.Data.Request.ServiceData;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace Acron.RestApi.Interfaces.Data.Response.ServiceData
{
    public interface IRepairData
    {
      [SwaggerSchema("Name of the service")]
      [SwaggerExampleValue("Serv1")]
      string ServiceName { get; set; }

      [SwaggerSchema("ID of the service")]
      [SwaggerExampleValue("600200001")]
      string ServiceId { get; set; }

      [SwaggerSchema("Flag that determines whether repairs or services are returned")]
      [SwaggerExampleValue(ServiceHistoryFlags.Hist_Repairs)]
      ServiceHistoryFlags ServiceHistoryFlag { get; set; }

      [SwaggerSchema("Type of the repair")]
      [SwaggerExampleValue(1)]
      int RepairType { get; set; }

      [SwaggerSchema("Type of the service action (maintenance, activation, deactivation)")]
      int Type { get; set; }

      [SwaggerSchema("Time of the service action")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime Time { get; set; }

      [SwaggerSchema($"{nameof(Time)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string Time_FORMATTED { get; set; }

      [SwaggerSchema("Operation time since the last maintenance in seconds")]
      [SwaggerExampleValue(17)]
      uint OperationTime { get; set; }

      [SwaggerSchema("Runtime since the last maintenance in seconds")]
      [SwaggerExampleValue(19)]
      uint RunTime { get; set; }

      [SwaggerSchema("Switching cycles time since the last maintenance")]
      [SwaggerExampleValue(19)]
      uint SwitchingCyclesTime { get; set; }

      [SwaggerSchema("Total sum of operation time")]
      [SwaggerExampleValue(430)]
      uint OperationTimeSum { get; set; }

      [SwaggerSchema("Total sum of runtime")]
      [SwaggerExampleValue(441)]
      uint RunTimeSum { get; set; }

      [SwaggerSchema("Total sum of switching cycle time")]
      [SwaggerExampleValue(781)]
      uint SwitchingCyclesTimeSum { get; set; }

      [SwaggerSchema("Maintenance interval for operations")]
      [SwaggerExampleValue(1000)]
      uint OperationTimeInterval { get; set; }

      [SwaggerSchema("Maintenance interval for runtime")]
      [SwaggerExampleValue(1000)]
      uint RunTimeInterval { get; set; }

      [SwaggerSchema("Maintenance interval for runtime")]
      [SwaggerExampleValue(1000)]
      uint SwitchingCyclesTimeInterval { get; set; }

      [SwaggerSchema("Printing time of last maintenance")]
      [SwaggerExampleValue(1000)]
      DateTime PrintTime { get; set; }

      [SwaggerSchema($"{nameof(PrintTime)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string PrintTime_FORMATTED { get; set; }

      [SwaggerSchema("User who maintains this object")]
      [SwaggerExampleValue("User1")]
      string User { get; set; }

      [SwaggerSchema("Comment 1 of the user")]
      [SwaggerExampleValue("Comment1")]
      string Comment1 { get; set; }

      [SwaggerSchema("Comment 2 of the user")]
      [SwaggerExampleValue("Comment2")]
      string Comment2 { get; set; }

      [SwaggerSchema("Comment 3 of the user")]
      [SwaggerExampleValue("Comment3")]
      string Comment3 { get; set; }

      [SwaggerSchema("Assigned document 1")]
      [SwaggerExampleValue("Document1")]
      string Document1 { get; set; }

      [SwaggerSchema("Assigned document 2")]
      [SwaggerExampleValue("Document2")]
      string Document2 { get; set; }

      [SwaggerSchema("Assigned document 3")]
      [SwaggerExampleValue("Document3")]
      string Document3 { get; set; }

      [SwaggerSchema("Duration of the maintenance")]
      [SwaggerExampleValue("Document3")]
      uint MaintenanceDuration { get; set; }

      [SwaggerSchema("Cost of the maintenance")]
      [SwaggerExampleValue(499.99)]
      double Cost { get; set; }

      [SwaggerSchema($"{nameof(Cost)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("499,99")]
      string Cost_FORMATTED { get; set; }
   }
}
