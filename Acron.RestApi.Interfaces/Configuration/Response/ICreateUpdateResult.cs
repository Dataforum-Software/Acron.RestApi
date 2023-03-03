using System.Collections.Generic;
using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public enum CrUpdState : int
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


   public interface ICreateUpdateResult
   {
      [SwaggerSchema("Object state after operation")]
      [SwaggerExampleValue(CrUpdState.Success)]
      CrUpdState State { get; }

      [SwaggerSchema("User friendly error information")]
      [SwaggerExampleValue("Example error message")]
      string ErrorText { get;  }

      [SwaggerSchema("Type of ACRON base object")]
      [SwaggerExampleValue("1001")]
      BaseObjectDefines.RestObjectTypeCode RestTypeCode { get; }

      [SwaggerSchema("Numerical ID of parent object")]
      [SwaggerExampleValue(0)]
      int IdParent { get; }

      [SwaggerSchema("Numerical ID of ACRON base object")]
      [SwaggerExampleValue("300000000")]
      int Id { get; }

      [SwaggerSchema("Base object identification")]
      [SwaggerExampleValue("")]
      string ShortName { get; }

      [SwaggerSchema("Base object designation")]
      [SwaggerExampleValue("Process variables")]
      string LongName { get; }
   }

   public interface ICreateUpdateResultList<T> where T : ICreateUpdateResult
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
      [SwaggerExampleValue(typeof(ICreateUpdateResult))]
      IEnumerable<T> Data { get; }
   }

}