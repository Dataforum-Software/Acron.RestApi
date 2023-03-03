using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.GlobalDataDefines
{
   public class ArrayHeader : IArrayHeader
   {
      /// <summary>
      /// 0, Array ist leer >>> ENDE
      /// 1, Array hat Elemente
      /// </summary>      
      public bool HasData { get; set; } = false;

      /// <summary>
      /// 0, unsortiert
      /// 1, sortiert
      /// </summary>      
      public bool IsSorted { get; set; } = false;

      /// <summary>
      /// Anzahl der Elemente im Array
      /// </summary>
      public uint ElementCount { get; set; }

      /// <summary>
      /// Länge in Bytes eines Elementes
      /// </summary>
      public uint StructSize { get; set; }

      /// <summary>
      /// Länge der ArrayDaten = ElementCount * StructSize
      /// </summary>
      public uint ArrayDataLen
      {
         get
         {
            if (!HasData)
               return 0;

            return ElementCount * StructSize;
         }
      }
   }
}
