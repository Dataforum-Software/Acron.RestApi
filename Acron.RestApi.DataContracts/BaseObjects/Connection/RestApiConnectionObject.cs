using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiConnectionObject : RestApiBaseObject, IConnectionObject
   {
      #region cTor

      public RestApiConnectionObject()
         : base(BaseObjectDefines.RestObjectTypeCode.Connection)
      { }

      public RestApiConnectionObject(object source)
         : base(source)
      { }

      #endregion cTor

      /// <summary>
      /// Übernimmt alle Interface-Props aus dem BO in das aktuelle RestApi-BO
      /// </summary>
      /// <param name="baseObject">BO mit zu mappenden Eigenschaften</param>
      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IConnectionObject iCon = baseObject as IConnectionObject;

         this.PropLoginName = iCon.PropLoginName;
         this.PropServer = iCon.PropServer;
         this.PropPort = iCon.PropPort;
         this.PropConnectedSyncInterval = iCon.PropConnectedSyncInterval;
         this.PropDisconnectedSyncInterval = iCon.PropDisconnectedSyncInterval;
         this.PropFormatStringShort = iCon.PropFormatStringShort;
         this.PropFormatStringLong = iCon.PropFormatStringLong;
         this.PropNotOnServerPrefix = iCon.PropNotOnServerPrefix;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreateConnectionObjectRequestResource iCon = baseObject as ICreateConnectionObjectRequestResource;

         this.PropLoginName = iCon.PropLoginName;
         this.PropServer = iCon.PropServer;
         this.PropPort = iCon.PropPort;
         this.PropConnectedSyncInterval = iCon.PropConnectedSyncInterval;
         this.PropDisconnectedSyncInterval = iCon.PropDisconnectedSyncInterval;
         this.PropFormatStringShort = iCon.PropFormatStringShort;
         this.PropFormatStringLong = iCon.PropFormatStringLong;
         this.PropNotOnServerPrefix = iCon.PropNotOnServerPrefix;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdateConnectionObjectRequestResource iCon = baseObject as IUpdateConnectionObjectRequestResource;

         this.PropLoginName = iCon.PropLoginName;
         this.PropServer = iCon.PropServer;
         this.PropPort = iCon.PropPort;
         this.PropConnectedSyncInterval = iCon.PropConnectedSyncInterval;
         this.PropDisconnectedSyncInterval = iCon.PropDisconnectedSyncInterval;
         this.PropFormatStringShort = iCon.PropFormatStringShort;
         this.PropFormatStringLong = iCon.PropFormatStringLong;
         this.PropNotOnServerPrefix = iCon.PropNotOnServerPrefix;

         return true;
      }

      /// <summary>
      /// Füllt dieses RestApi-BO mit Default-Werten
      /// </summary>
      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropLoginName = string.Empty;
         this.PropServer = string.Empty;
         this.PropPort = ConnectionDefines.DefaultPort;
         this.PropConnectedSyncInterval = ConnectionDefines.DefaultConnectedSyncInterval;
         this.PropDisconnectedSyncInterval = ConnectionDefines.DefaultDisconnectedSyncInterval;
         this.PropFormatStringShort = ConnectionDefines.DefaultFormatShort;
         this.PropFormatStringLong = ConnectionDefines.DefaultFormatLong;
         this.PropNotOnServerPrefix = "x";
      }

      #region IConnectionObject

      private string _propServer;

      /// <summary>
      ///Addresse des Servers
      /// </summary>
      [DataMember]
      [DefaultValue("")]
      public string PropServer
      {
         get { return _propServer; }
         set
         {
            _propServer = value;
            ModifiedProperties.Add(nameof(PropServer));
         }
      }


      private uint _propPort;

      /// <summary>
      ///Port des Servers
      /// </summary>
      [DataMember]
      [DefaultValue(0)]
      public uint PropPort
      {
         get { return _propPort; }
         set
         {
            _propPort = value;
            ModifiedProperties.Add(nameof(PropPort));
         }
      }

      private string _propLoginName;

      /// <summary>
      /// Login-Name
      /// </summary>
      [DataMember]
      [DefaultValue("")]
      public string PropLoginName
      {
         get { return _propLoginName; }
         set
         {
            _propLoginName = value;
            ModifiedProperties.Add(nameof(PropLoginName));
         }
      }

      private uint _propConnectedSyncInterval;

      /// <summary>
      /// Pollingintervall für verbundene Anlagen
      /// </summary>
      [DataMember]
      public uint PropConnectedSyncInterval
      {
         get { return _propConnectedSyncInterval; }
         set
         {
            _propConnectedSyncInterval = value;
            ModifiedProperties.Add(nameof(PropConnectedSyncInterval));
         }
      }

      private uint _propDisconnectedSyncInterval;

      /// <summary>
      /// Pollingintervall für nicht verbundene Anlagen
      /// </summary>
      [DataMember]
      public uint PropDisconnectedSyncInterval
      {
         get { return _propDisconnectedSyncInterval; }
         set
         {
            _propDisconnectedSyncInterval = value;
            ModifiedProperties.Add(nameof(PropDisconnectedSyncInterval));
         }
      }

      private string _propFormatStringShort;
      /// <summary>
      ///Bildungsregel Identifikation der VG-Externals
      /// </summary>
      [DataMember]
      public string PropFormatStringShort
      {
         get { return _propFormatStringShort; }
         set
         {
            _propFormatStringShort = value;
            ModifiedProperties.Add(nameof(PropFormatStringShort));
         }
      }

      private string _propFormatStringLong;
      /// <summary>
      ///Bildungsregel Bezeichnung der VG-Externals
      /// </summary>
      [DataMember]
      public string PropFormatStringLong
      {
         get { return _propFormatStringLong; }
         set
         {
            _propFormatStringLong = value;
            ModifiedProperties.Add(nameof(PropFormatStringLong));
         }
      }

      private string _propNotOnServerPrefix;
      /// <summary>
      /// Marker für in der Quellanlage nicht (mehr) vorhandene / kontaktierbare ExtVars
      /// </summary>
      [DataMember]
      public string PropNotOnServerPrefix 
      {
         get { return _propNotOnServerPrefix; }
         set
         {
            _propNotOnServerPrefix = value;
            ModifiedProperties.Add(nameof(PropNotOnServerPrefix));
         }
      }

      #endregion IConnectionObject

   }
}