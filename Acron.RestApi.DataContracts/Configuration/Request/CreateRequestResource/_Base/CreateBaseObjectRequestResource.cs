using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{

   [DataContract]
   public class CreateBaseObjectRequestResource : ICreateBaseObjectRequestResource
   {
      #region cTor

      public CreateBaseObjectRequestResource()
      {
      }

      public CreateBaseObjectRequestResource(BaseObjectDefines.RestObjectTypeCode typeCode)
      {
         _restTypeCode = typeCode;

         setDefaultValues();

         ModifiedProperties.Clear();
      }

      #endregion cTor

      protected virtual void setDefaultValues()
      {
         //this.Id = -1;
         this.Position = -1;
      }

      protected object _sourceBaseObject = null;

      private List<string> _modifiedProperties = null;
      protected List<string> ModifiedProperties
      {
         get
         {
            if (_modifiedProperties == null)
               _modifiedProperties = new List<string>();

            return _modifiedProperties;
         }
      }

      public List<string> GetModifiedProperties()
      {
         //if (ModifiedPropertyNames != null)
         //   return ModifiedPropertyNames as List<string>;

         return ModifiedProperties;
      }

      #region IBaseObject

      private BaseObjectDefines.RestObjectTypeCode _restTypeCode = BaseObjectDefines.RestObjectTypeCode.Unknown;

      [DataMember]
      [Required]
      [JsonConverter(typeof(StringEnumConverter))]
      public BaseObjectDefines.RestObjectTypeCode RestTypeCode
      {
         get { return _restTypeCode; }
         set { _restTypeCode = value; }
      }

      private int _idParent;

      /// <summary>
      /// ID des übergeordneten Objekts oder 0 für höchste Ebene
      /// </summary>
      [DataMember]
      [Required]
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

      //private int _id;

      ///// <summary>
      ///// Eindeutige ID des ACRON-BOs
      ///// </summary>
      //[DataMember]
      //public int Id
      //{
      //   get { return _id; }
      //   set
      //   {
      //      _id = value;
      //      ModifiedProperties.Add(nameof(Id));
      //   }
      //}

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

      protected string _shortName;

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

      protected string _longName;
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
      public List<int> ReferencedIBaseObjects
      {
         get { return _referencedIds; }
      }

      #endregion IBaseObject

   }
}
