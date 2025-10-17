using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Response.ChangeProtocol
{
   public interface IDataProtocol
   {
      [SwaggerSchema("Time the change was made at")]
      [SwaggerExampleValue("2022-02-17T10:45:00+2")]
      DateTime Time { get; set; }

      [SwaggerSchema($"{nameof(Time)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2022-02-17T08:45:00")]
      string Time_FORMATTED { get; set; }

      [SwaggerSchema("The user who made the changes")]
      [SwaggerExampleValue("acron")]
      string User { get; set; }

      [SwaggerSchema("Id of corresponding dialog")]
      [SwaggerExampleValue(5)]
      string Dialog { get; set; }

      [SwaggerSchema("Id of corresponding page")]
      [SwaggerExampleValue(5)]
      string Page { get; set; }

      [SwaggerSchema("Id of corresponding field")]
      [SwaggerExampleValue(5)]
      string Field { get; set; }

      [SwaggerSchema("Kind or type of the action")]
      [SwaggerExampleValue(ACP_STATE.ACP_STATE_ACTION)]
      string ActionType { get; set; }

      [SwaggerSchema("Key of the object")]
      [SwaggerExampleValue("umValue.ConfiSetType.Plant")]
      string ObjectKey { get; set; }

      [SwaggerSchema("Kind or type of the action")]
      [SwaggerExampleValue(ACP_STATE.ACP_STATE_ACTION)]
      ACP_STATE Status { get; set; }

      [SwaggerSchema("acron module id")]
      [SwaggerExampleValue(ACRON_MODULE.ACMOD_DESIGNER)]
      string Module { get; set; }

      [SwaggerSchema("Old value which has been overwritten")]
      [SwaggerExampleValue("14.7")]
      string OldValue { get; set; }

      [SwaggerSchema("New value")]
      [SwaggerExampleValue("17.8")]
      string NewValue { get; set; }

      [SwaggerSchema("Time of data")]
      [SwaggerExampleValue("17.8")]
      DateTime TimestampData { get; set; }

      [SwaggerSchema($"{nameof(TimestampData)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2022-02-17T10:45:00+2")]
      string TimestampData_FORMATTED { get; set; }

      [SwaggerSchema("Type of the archive")]
      [SwaggerExampleValue(ArchiveType.ACPDAT_PRO)]
      ArchiveType ArchiveType { get; set; }

      [SwaggerSchema("Kind or type of the protocol")]
      string ProtocolType { get; set; }

      [SwaggerSchema("Only show this Protocol in Detailed Reports")]
      [SwaggerExampleValue(true)]
      bool DetailOnly { get; set; }
   }

   public enum ArchiveType : short
   {
      UNKNOWN = 0,
      ACPDAT_PRO = 400,
      ACPDAT_INTER1 = 401,
      ACPDAT_INTER2 = 402,
      ACPDAT_DAY = 403,
      ACPDAT_WEEK = 404,
      ACPDAT_MON = 405,
      ACPDAT_YEAR = 406,
      ACPDAT_INTER3 = 407,
      ACPDAT_INTER4 = 408,
      ACPDAT_INTER5 = 409,
      ACPDAT_INTER6 = 410,
      ACPDAT_INTER7 = 411,
      ACPDAT_INTER8 = 412,

   }
}
