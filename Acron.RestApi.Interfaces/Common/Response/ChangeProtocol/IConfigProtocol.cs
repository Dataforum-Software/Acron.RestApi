using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Response.ChangeProtocol
{
   public interface IConfigProtocol
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

      [SwaggerSchema("Name of the changed property according to the general naming scheme Type -> Area -> Name")]
      [SwaggerExampleValue("umValue.ConfiSetType.Plant")]
      string PropertyName { get; set; }

      [SwaggerSchema("Key of the object")]
      [SwaggerExampleValue("umValue.ConfiSetType.Plant")]
      string ObjectKey { get; set; }

      [SwaggerSchema("acron module id")]
      [SwaggerExampleValue(ACRON_MODULE.ACMOD_DESIGNER)]
      string Module { get; set; }

      [SwaggerSchema("Kind or type of the action")]
      [SwaggerExampleValue(ACP_STATE.ACP_STATE_ACTION)]
      string ActionType { get; set; }

      [SwaggerSchema("Old value which has been overwritten")]
      [SwaggerExampleValue("14.7")]
      string OldValue { get; set; }

      [SwaggerSchema("New value")]
      [SwaggerExampleValue("17.8")]
      string NewValue { get; set; }

      [SwaggerSchema("Id of corresponding dialog")]
      [SwaggerExampleValue(5)]
      string Dialog { get; set; }

      [SwaggerSchema("Id of corresponding page")]
      [SwaggerExampleValue(5)]
      string Page { get; set; }

      [SwaggerSchema("Id of corresponding field")]
      [SwaggerExampleValue(5)]
      string Field { get; set; }

      [SwaggerSchema("Type of the archive")]
      [SwaggerExampleValue(ArchiveType.ACPDAT_PRO)]
      ArchiveType ArchiveType { get; set; }

      [SwaggerSchema("Kind or type of the protocol")]
      string ProtocolType { get; set; }

      [SwaggerSchema("Only show this Protocol in Detailed Reports")]
      [SwaggerExampleValue(true)]
      bool DetailOnly { get; set; }

   }

   public enum ACRON_MODULE : short
   {
      [SwaggerEnumInfo("Unknown Module")]
      ACMOD_UNKNOWN = 0,
      [SwaggerEnumInfo("acron Designer")]
      ACMOD_DESIGNER = 1,
      [SwaggerEnumInfo("acron Reporter")]
      ACMOD_REPORTER = 10,
      [SwaggerEnumInfo("acron Graph")]
      ACMOD_GRAPH = 11,
      [SwaggerEnumInfo("acron Service")]
      ACMOD_SERVICE = 12,
      [SwaggerEnumInfo("acron Alert")]
      ACMOD_ALERT = 13,
      [SwaggerEnumInfo("acron Visu")]
      ACMOD_VISU = 14,
      [SwaggerEnumInfo("acron Collect")]
      ACMOD_COLLECT = 15,
      [SwaggerEnumInfo("acron Job")]
      ACMOD_JOB = 16,
      [SwaggerEnumInfo("acron Sim")]
      ACMOD_SIM = 17,
      [SwaggerEnumInfo("acron Safe")]
      ACMOD_SAFE = 18,
      [SwaggerEnumInfo("acron TEIS")]
      ACMOD_TEIS = 19,
      [SwaggerEnumInfo("acron NWBA")]
      ACMOD_NWBA = 20,
      [SwaggerEnumInfo("acron ODBC")]
      ACMOD_ODBC = 21,
      [SwaggerEnumInfo("acron Import")]
      ACMOD_IMPORT = 50,
      [SwaggerEnumInfo("acron PROT")]
      ACMOD_PROT = 51,
      [SwaggerEnumInfo("acron DLG")]
      ACMOD_DLG = 52,
      [SwaggerEnumInfo("acron Test")]
      ACMOD_TEST = 54,
      [SwaggerEnumInfo("acron API")]
      ACMOD_API = 55,
      [SwaggerEnumInfo("acron RestAPI")]
      ACMOD_WEBAPI = 56,

   };

   public enum ACP_STATE : short
   {
      [SwaggerEnumInfo("Not initialized")]
      ACP_STATE_UNKNOWN = 0,     

      [SwaggerEnumInfo("Dataset was written and no old value was given.")]
      ACP_STATE_NEWDATA = 1,     

      [SwaggerEnumInfo("Dataset was deleted and no new value was given.")]
      ACP_STATE_DELDATA = 2,     

      [SwaggerEnumInfo("Dataset was changed")]
      ACP_STATE_CHANGEDDATA = 3, 

      [SwaggerEnumInfo("Dialog was changed (only up to acron 7.x)")]
      ACP_STATE_DIALCHANGED = 4, 

      [SwaggerEnumInfo("Logout/Login event")]
      ACP_STATE_LOGOUT = 5, 

      [SwaggerEnumInfo("Program start")]
      ACP_STATE_PROGSTART = 6,      

      [SwaggerEnumInfo("Access was denied")]
      ACP_STATE_ACCESS_DENIED = 7,  

      [SwaggerEnumInfo("Access was granted")]
      ACP_STATE_ACCESS_GRANTED = 8,

      [SwaggerEnumInfo("Access was denied")]
      ACP_STATE_MULTIKEY_NEWDATA = 11,    

      [SwaggerEnumInfo("Multikey position was deleted. No new value was set.")]
      ACP_STATE_MULTIKEY_DELDATA = 12,  

      [SwaggerEnumInfo("Multikey position was changed")]
      ACP_STATE_MULTIKEY_CHANGEDDATA = 13,

      [SwaggerEnumInfo("User action")]
      ACP_STATE_ACTION = 14,                

      [SwaggerEnumInfo("User action with parameter passing")]
      ACP_STATE_ACTION_PARAM = 15,

      [SwaggerEnumInfo("Special case for template configuration")]
      ACP_STATE_MODELOPEN = 916,

      [SwaggerEnumInfo("Special case for template configuration")]
      ACP_STATE_COLCHANGED = 922,

      [SwaggerEnumInfo("Special case for template configuration")]
      ACP_STATE_LAYOUTCHANGE = 923,
   }
}
