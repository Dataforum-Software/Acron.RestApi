using Acron.RestApi.Interfaces.BaseObjects;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiPlantObject : RestApiBaseObject, IPlantObject
   {
      #region cTor

      public RestApiPlantObject()
         : base(BaseObjectDefines.RestObjectTypeCode.Plant)
      { }

      public RestApiPlantObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         // Falls 'RestTypeCode' nicht passt - siehe Eigenschaft "RestTypeCode" in BaseObject_IBaseObject

         IPlantObject iplant = baseObject as IPlantObject;

         this.PropVersion = iplant.PropVersion;
         this.PropOffsetHours = iplant.PropOffsetHours;
         this.PropOffsetDays = iplant.PropOffsetDays;
         this.PropOffsetMonths = iplant.PropOffsetMonths;

         this.PropCompIVal1 = iplant.PropCompIVal1;
         this.PropCompIVal2 = iplant.PropCompIVal2;
         this.PropCompIVal3 = iplant.PropCompIVal3;
         this.PropCompIVal4 = iplant.PropCompIVal4;
         this.PropCompIVal5 = iplant.PropCompIVal5;
         this.PropCompIVal6 = iplant.PropCompIVal6;
         this.PropCompIVal7 = iplant.PropCompIVal7;
         this.PropCompIVal8 = iplant.PropCompIVal8;

         return true;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         PropOffsetHours = 0;
         PropOffsetDays = 0;
         PropOffsetMonths = 0;

         PropCompIVal1 = null;
         PropCompIVal2 = null;
         PropCompIVal3 = null;
         PropCompIVal4 = null;
         PropCompIVal5 = null;
         PropCompIVal6 = null;
         PropCompIVal7 = null;
         PropCompIVal8 = null;

      }

      #region IPlantObject

      private string _propVersion;

      /// <summary> Version der Anlage </summary>
      [DataMember]
      public string PropVersion 
      {
         get { return _propVersion; }
         private set 
         {
            _propVersion = value;
            ModifiedProperties.Add(nameof(PropVersion));
         }
      }

      private uint _propOffsetHours = 0;
      /// <summary>
      /// Datenoffset in Stunden
      /// </summary>
      [DataMember]
      public uint PropOffsetHours
      {
         get { return _propOffsetHours; }
         set
         {
            _propOffsetHours = value;
            ModifiedProperties.Add(nameof(PropOffsetHours));
         }
      }

      private uint _propOffsetDays = 0;
      /// <summary>
      /// Datenoffset in Tagen
      /// </summary>
      [DataMember]
      public uint PropOffsetDays
      {
         get { return _propOffsetDays; }
         set
         {
            _propOffsetDays = value;
            ModifiedProperties.Add(nameof(PropOffsetDays));
         }
      }

      private uint _propOffsetMonths = 0;
      /// <summary>
      /// Datenoffset in Monaten
      /// </summary>
      [DataMember]
      public uint PropOffsetMonths
      {
         get { return _propOffsetMonths; }
         set
         {
            _propOffsetMonths = value;
            ModifiedProperties.Add(nameof(PropOffsetMonths));
         }
      }


      private ICompIval _compIval1 = null;
      private ICompIval _compIval2 = null;
      private ICompIval _compIval3 = null;
      private ICompIval _compIval4 = null;
      private ICompIval _compIval5 = null;
      private ICompIval _compIval6 = null;
      private ICompIval _compIval7 = null;
      private ICompIval _compIval8 = null;

      /// <summary> Compression interval 1 or null</summary>
      /// <remarks> Implementation of IPlantObject </remarks>
      [DataMember]
      public ICompIval PropCompIVal1
      {
         get { return _compIval1; }
         private set
         {
            _compIval1 = value;
            ModifiedProperties.Add(nameof(PropCompIVal1));
         }
      }

      /// <summary> Compression interval 2 or null</summary>
      /// <remarks> Implementation of IPlantObject </remarks>
      [DataMember]
      public ICompIval PropCompIVal2
      {
         get { return _compIval2; }
         private set
         {
            _compIval2 = value;
            ModifiedProperties.Add(nameof(PropCompIVal2));
         }
      }

      /// <summary> Compression interval 3 or null</summary>
      /// <remarks> Implementation of IPlantObject </remarks>
      [DataMember]
      public ICompIval PropCompIVal3
      {
         get { return _compIval3; }
         private set
         {
            _compIval3 = value;
            ModifiedProperties.Add(nameof(PropCompIVal3));
         }
      }

      /// <summary> Compression interval 4 or null</summary>
      /// <remarks> Implementation of IPlantObject </remarks>
      [DataMember]
      public ICompIval PropCompIVal4
      {
         get { return _compIval4; }
         private set
         {
            _compIval4 = value;
            ModifiedProperties.Add(nameof(PropCompIVal4));
         }
      }

      /// <summary> Compression interval 5 or null</summary>
      /// <remarks> Implementation of IPlantObject </remarks>
      [DataMember]
      public ICompIval PropCompIVal5
      {
         get { return _compIval5; }
         private set
         {
            _compIval5 = value;
            ModifiedProperties.Add(nameof(PropCompIVal5));
         }
      }

      /// <summary> Compression interval 6 or null</summary>
      /// <remarks> Implementation of IPlantObject </remarks>
      [DataMember]
      public ICompIval PropCompIVal6
      {
         get { return _compIval6; }
         private set
         {
            _compIval6 = value;
            ModifiedProperties.Add(nameof(PropCompIVal6));
         }
      }

      /// <summary> Compression interval 7 or null</summary>
      /// <remarks> Implementation of IPlantObject </remarks>
      [DataMember]
      public ICompIval PropCompIVal7
      {
         get { return _compIval7; }
         private set
         {
            _compIval7 = value;
            ModifiedProperties.Add(nameof(PropCompIVal7));
         }
      }

      /// <summary> Compression interval 8 or null</summary>
      /// <remarks> Implementation of IPlantObject </remarks>
      [DataMember]
      public ICompIval PropCompIVal8
      {
         get { return _compIval8; }
         private set
         {
            _compIval8 = value;
            ModifiedProperties.Add(nameof(PropCompIVal8));
         }
      }


      #endregion IPlantObject
   }
}
