using Swashbuckle.AspNetCore.Annotations;
using System.Diagnostics.Tracing;
using static Acron.RestApi.Interfaces.BaseObjects.AlertDefines;
using static Acron.RestApi.Interfaces.BaseObjects.EventDefines;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Base interface for event objects
   /// </summary>
   public interface IEventBaseObject : IBaseObject
   {
   }

}
