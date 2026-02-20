using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.EventData
{
   public interface IGetEventDataRequestResource<T> where T : IEventSelectionParameters
   {
      [SwaggerSchema("List of objects which each contain selection parameters for a singular event and it's batches")]
      [SwaggerExampleValue(typeof(IEventSelectionParameters))]
      List<T> EventSelectionParameters { get; set; }

      [SwaggerSchema("Event sort order")]
      [SwaggerExampleValue(EventSortOrder.CFG_NEWOLD)]
      EventSortOrder EventsOrder { get; set; }


      [SwaggerSchema("Steps sort order")]
      [SwaggerExampleValue(EventSortOrder.CFG_OLDNEW)]
      EventSortOrder StepsOrder { get; set; }
   }

   public enum EventSortOrder
   {
      [EnumMember]
      [SwaggerEnumInfo("Don't sort")]
      NONE = -1, 
      [EnumMember]
      [SwaggerEnumInfo("Sort events and steps by configuration in ascending order")]
      CFG_OLDNEW = 0,
      [EnumMember]
      [SwaggerEnumInfo("Sort events and steps by configuration in descending order")]
      CFG_NEWOLD = 1,
      [EnumMember]
      [SwaggerEnumInfo("Sort events and steps chronologically in ascending order")]
      OLDNEW = 2,
      [EnumMember]
      [SwaggerEnumInfo("Sort events and steps chronologically in descending order")]
      NEWOLD = 3,

   };

   public enum EventFilters
   {
      [EnumMember]
      [SwaggerEnumInfo("No filter")]
      ALL = 0,
      [EnumMember]
      [SwaggerEnumInfo("Only closed events")]
      CLOSED = 1,
      [EnumMember]
      [SwaggerEnumInfo("Only open events")]
      OPEN = 2,
      [EnumMember]
      [SwaggerEnumInfo("Only events starting within the time range")]
      STARTING = 3,
      [EnumMember]
      [SwaggerEnumInfo("Only events ending within the time range")]
      ENDING = 4,
   };

   [Flags]
   public enum ReadOptions
   {
      [EnumMember]
      [SwaggerEnumInfo("No options set")]
      NONE = 0x0,
      [EnumMember]
      [SwaggerEnumInfo("Read cell values")]
      READ_CELL = 0x1,
      [EnumMember]
      [SwaggerEnumInfo("Read sub values")]
      READ_SUB = 0x2,
      [EnumMember]
      [SwaggerEnumInfo("Read cell and sub values")]
      READ_CELL_SUB = 0x3,
      [EnumMember]
      [SwaggerEnumInfo("Auto delete read data after reading")]
      AUTODEL = 0x8,
      [EnumMember]
      [SwaggerEnumInfo("Read cell values and auto delete after reading")]
      READ_CELL_AUTODEL = 0x9,
      [EnumMember]
      [SwaggerEnumInfo("Read sub values and auto delete after reading")]
      READ_SUB_AUTODEL = 0x10,
      [EnumMember]
      [SwaggerEnumInfo("Read cell and sub values and auto delete after reading")]
      READ_CELL_SUB_AUTODEL = 0x11,
   };

}
