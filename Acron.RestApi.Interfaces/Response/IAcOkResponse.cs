using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IAcOkResponse<T> : IApiControllerResponseBase, IResult<T>
   {
   }
}
