using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources;
using Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static System.Net.Mime.MediaTypeNames;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiBaseObject : IBaseObject
   {
      #region cTor

      public RestApiBaseObject()
      {
         //throw new NotImplementedException("DO NOT USE THIS cTor - MISSING TYPECODE!!");
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

//         ModifiedProperties.Clear();
      }

      #endregion cTor

      protected virtual void setDefaultValues()
      {
         this.Id = -1;
      }

      protected virtual bool memberMapperBaseObject(object baseObject)
      {
         IBaseObject iBase = baseObject as IBaseObject;
         if (iBase == null)
            return false;

         _restTypeCode = iBase.RestTypeCode;

         this.Id = iBase.Id;
         this.IdParent = iBase.IdParent;
         this.Position = iBase.Position;
         this.ShortName = iBase.ShortName;
         this.LongName = iBase.LongName;

         if (iBase.ReferencedIBaseObjects != null && iBase.ReferencedIBaseObjects.Any())
         {
            //if ( ! lockReferences )
               _referencedIds = iBase.ReferencedIBaseObjects.ToList();
         }

         return true;
      }

      protected virtual bool memberMapperCreate(object baseObject)
      {
         ICreateBaseObjectRequestResource iCreate = baseObject as ICreateBaseObjectRequestResource;
         if (iCreate == null)
            return false;

         _restTypeCode = iCreate.RestTypeCode;

         this.Id = -1;

         this.IdParent = iCreate.IdParent;
         this.Position = iCreate.Position;
         this.ShortName = iCreate.ShortName;
         this.LongName = iCreate.LongName;

         if (iCreate.ReferencedIBaseObjects != null && iCreate.ReferencedIBaseObjects.Any())
            _referencedIds = iCreate.ReferencedIBaseObjects.ToList();

         return true;
      }

      protected virtual bool memberMapperUpdate(object baseObject)
      {
         IUpdateBaseObjectRequestResource iUpdate = baseObject as IUpdateBaseObjectRequestResource;

         if (iUpdate == null) 
            return false;

         _restTypeCode = iUpdate.RestTypeCode;

         this.Id = iUpdate.Id;
         this.IdParent = iUpdate.IdParent;
         this.Position = iUpdate.Position;
         this.ShortName = iUpdate.ShortName;
         this.LongName = iUpdate.LongName;

         if (iUpdate.ReferencedIBaseObjects != null && iUpdate.ReferencedIBaseObjects.Any())
            _referencedIds = iUpdate.ReferencedIBaseObjects.ToList();

         return true;
      }

      protected void memberMapper(object baseObject)
      {
         if (memberMapperBaseObject(baseObject))
         {
            ModifiedProperties.Clear();
            return;
         }

         if (memberMapperCreate(baseObject))
         {
            ModifiedProperties.Clear();

            CreateBaseObjectRequestResource createResource = baseObject as CreateBaseObjectRequestResource;

            //this.ModifiedPropertyNames = createResource.ModifiedPropertyNames;

            foreach(string propName in createResource.GetModifiedProperties())
            {
               this.ModifiedProperties.Add(propName);
            }

            return;
         }

         if (memberMapperUpdate(baseObject))
         {
            ModifiedProperties.Clear();

            UpdateBaseObjectRequestResource updateResource = baseObject as UpdateBaseObjectRequestResource;

            //this.ModifiedPropertyNames = updateResource.ModifiedPropertyNames;

            foreach (string propName in updateResource.GetModifiedProperties())
            {
               this.ModifiedProperties.Add(propName);
            }

            return;
         }
      }

      /// <summary>
      /// Modifiziert die Liste der Referenzen
      /// </summary>
      /// <param name="referencedIds">Neue Referenzliste</param>
      public void SetReferences(List<int> referencedIds)
      {
         if (referencedIds == null)
            return;

         if (_referencedIds != null && referencedIds.Count > _referencedIds.Count)
            return; // mehr Referenzen sind nicht zulässig

         _referencedIds = referencedIds;
      }

      protected object _sourceBaseObject=null;
      public object SourceBaseObject
      {
         get { return _sourceBaseObject; }
      }


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
      [DefaultValue(-1)]
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

      protected List<int> _referencedIds = null;
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
