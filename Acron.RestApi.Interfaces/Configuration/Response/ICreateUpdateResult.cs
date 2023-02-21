using System.Collections.Generic;
using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public interface ICreateUpdateResult
   {
      [SwaggerSchema("An error occured while creating or updating this object")]
      [SwaggerExampleValue(false)]
      bool HasError { get;  }

      [SwaggerSchema("User friendly error information")]
      [SwaggerExampleValue("Example error message")]
      string ErrorText { get;  }

      [SwaggerSchema("Data parsed from request body")]
      [SwaggerExampleValue(typeof(IBaseObject))]
      IBaseObject RestApiObject { get; }

      [SwaggerSchema("Resulting state of object in plant configuration")]
      [SwaggerExampleValue(typeof(IBaseObject))]
      IBaseObject BaseObject { get; }

      [SwaggerSchema("List of property names that were modified in this operation")]
      [SwaggerExampleValue(nameof(IBaseObject.LongName))]
      List<string> UpdatedProperties { get; }
   }

   public interface ICreateUpdateResultList
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

      /// <summary>
      /// Item foreach handled element
      /// </summary>
      [SwaggerSchema("Detailed result for each element")]
      [SwaggerExampleValue(typeof(ICreateUpdateResult))]
      IEnumerable<ICreateUpdateResult> Data { get; }
   }

}