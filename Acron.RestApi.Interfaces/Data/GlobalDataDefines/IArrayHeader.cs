namespace Acron.RestApi.Interfaces.Data.GlobalDataDefines
{
   public interface IArrayHeader
   {
      bool HasData { get; }
      bool IsSorted { get; }

      uint ElementCount { get; }

      uint StructSize { get; }

      uint ArrayDataLen { get; }
   }
}
