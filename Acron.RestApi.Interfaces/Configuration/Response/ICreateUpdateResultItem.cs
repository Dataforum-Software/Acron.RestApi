using System.Collections.Generic;
using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public interface ICreateUpdateResult<T> where T : ICreateUpdateResultItem
   {

      /// <summary>
      /// Count of elements with succesful performed action
      /// </summary>
      [SwaggerSchema("Number of elements that were modified successfully")]
      [SwaggerExampleValue(5)]
      int CountSuccessfully { get; }

      /// <summary>
      /// Count of elements with failed action
      /// </summary>
      [SwaggerSchema("Number of elements that failed to be modified")]
      [SwaggerExampleValue(2)]
      int CountFailed { get; }

      [SwaggerSchema("Number of elements that were not processed, because the operation was aborted")]
      [SwaggerExampleValue(0)]
      int CountNotProcessed { get; }

      /// <summary>
      /// Item foreach handled element
      /// </summary>
      [SwaggerSchema("Detailed result for each element")]
      [SwaggerExampleValue(typeof(ICreateUpdateResultItem))]
      List<T> Data { get; }
   }


   public interface ICreateUpdateResultItem
   {
      [SwaggerSchema("Object state after operation")]
      [SwaggerExampleValue(CreateUpdateResultStates.Success)]
      CreateUpdateResultStates State { get; set; }

      [SwaggerSchema("User friendly error information")]
      [SwaggerExampleValue("Example error message")]
      string ErrorText { get; set; }

      [SwaggerSchema("Type of ACRON base object")]
      [SwaggerExampleValue("1001")]
      BaseObjectDefines.RestObjectTypeCode RestTypeCode { get; }

      [SwaggerSchema("Numerical ID of parent object")]
      [SwaggerExampleValue(0)]
      int IdParent { get; set; }

      [SwaggerSchema("Numerical ID of ACRON base object")]
      [SwaggerExampleValue("300000000")]
      int Id { get; set; }

      [SwaggerSchema("Base object identification")]
      [SwaggerExampleValue("")]
      string ShortName { get; set; }

      [SwaggerSchema("Base object designation")]
      [SwaggerExampleValue("Process variables")]
      string LongName { get; set; }
   }


   public enum CreateUpdateResultStates : int
   {
      /// <summary>Not set</summary>
      [SwaggerEnumInfo("Undefined")]
      Unknown = 0,

      /// <summary>Not handeled</summary>
      [SwaggerEnumInfo("Operation was aborted before the object was processed")]
      NotProcessed,

      /// <summary>Sucessful handeled</summary>
      [SwaggerEnumInfo("Operation successful on this object")]
      Success,

      /// <summary>Handeled with error</summary>
      [SwaggerEnumInfo("Operation failed for this object")]
      Error,
   }

}