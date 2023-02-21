﻿using Acron.RestApi.Interfaces.Configuration.Request;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request
{
   [DataContract]
   public class DeleteRequestResource : IDeleteRequestResource
   {
      [DataMember]
      [Required]
      public int? BaseObjectID { get; set; }
   }
}