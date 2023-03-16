using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Response;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IAcBadCreateUpdateResponse<T,U> : IAcBadRequestResponse, IResult<T> where T : ICreateUpdateResult<U> where U : ICreateUpdateResultItem
   {

   }
}
