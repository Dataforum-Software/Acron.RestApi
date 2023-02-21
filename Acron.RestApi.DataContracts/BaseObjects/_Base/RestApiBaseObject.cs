using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Acron.RestApi.Interfaces.BaseObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiBaseObject : IBaseObject
   {
      #region cTor

      public RestApiBaseObject()
      {
         throw new NotImplementedException("DO NOT USE THIS cTor - MISSING TYPECODE!!");
      }

      public RestApiBaseObject(BaseObjectDefines.RestObjectTypeCode typeCode)
      {
         _restTypeCode = typeCode;

         setDefaultValues();

         ModifiedProperties.Clear();
      }

      public RestApiBaseObject(object source)
      {
         setDefaultValues();

         _sourceBaseObject = source;

         memberMapper(source);

         ModifiedProperties.Clear();
      }

      #endregion cTor

      protected virtual void setDefaultValues()
      {
         this.Id = -1;
      }

      protected virtual void memberMapper(object baseObject)
      {
         IBaseObject iBase = _sourceBaseObject as IBaseObject;

         _restTypeCode = iBase.RestTypeCode;

         this.Id = iBase.Id;
         this.IdParent = iBase.IdParent;
         this.Position = iBase.Position;
         this.ShortName = iBase.ShortName;
         this.LongName = iBase.LongName;

         if (iBase.ReferencedIBaseObjects != null)
            _referencedIds = iBase.ReferencedIBaseObjects.ToList();
      }

      protected object _sourceBaseObject=null;

      private List<string> _modifiedProperties = null;
      public List<string> ModifiedProperties 
      {
         get 
         {
            if (_modifiedProperties == null)
               _modifiedProperties = new List<string>();

            return _modifiedProperties;
         }
      }

      #region IBaseObject

      private BaseObjectDefines.RestObjectTypeCode _restTypeCode = BaseObjectDefines.RestObjectTypeCode.Unknown;

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public BaseObjectDefines.RestObjectTypeCode RestTypeCode
      {
         get { return _restTypeCode; }
      }

      private int _idParent;

      /// <summary>
      /// ID des übergeordneten Objekts oder 0 für höchste Ebene
      /// </summary>
      [DataMember]
      [DefaultValue(0)]
      public int IdParent 
      {
         get { return _idParent; }
         set 
         {
            _idParent = value;
            ModifiedProperties.Add(nameof(IdParent));
         }
      }

      private int _id;

      /// <summary>
      /// Eindeutige ID des ACRON-BOs
      /// </summary>
      [DataMember]
      public int Id 
      {
         get { return _id; }
         set
         {
            _id = value;
            ModifiedProperties.Add(nameof(Id));
         }
      }

      private int _position;
      /// <summary>
      /// Position innerhalb einer Gruppe
      /// </summary>
      [DataMember]
      public int Position 
      {
         get { return _position; }
         set
         {
            _position = value;
            ModifiedProperties.Add(nameof(Position));
         }
      }

      private string _shortName;

      /// <summary>
      /// Identifikation des BOs
      /// </summary>
      [DataMember]
      [DefaultValue("")]
      public virtual string ShortName 
      {
         get { return _shortName; }
         set
         {
            _shortName = value;
            ModifiedProperties.Add(nameof(ShortName));
         }
      }

      private string _longName;
      /// <summary>
      /// Bezeichnung des BOs
      /// </summary>
      [DataMember]
      [DefaultValue("")]
      public virtual string LongName 
      {
         get { return _longName; }
         set
         {
            _longName = value;
            ModifiedProperties.Add(nameof(LongName));
         }
      }

      private List<int> _referencedIds = null;
      /// <summary>
      /// Alle direkt untergeordneten BOs
      /// </summary>
      [DataMember]
      public IEnumerable<int> ReferencedIBaseObjects
      {
         get { return _referencedIds; }
      }

      #endregion IBaseObject

   }
}
