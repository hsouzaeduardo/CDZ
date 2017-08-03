using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CDZ.Services.Modelos
{
    [DataContract]
    public class ResponseAtividades
    {
        [DataMember(Order = 10)]
        public string Id { get; set; }
        [DataMember(Order = 20)]
        public string NomeAtividade { get; set; }
        [DataMember(Order = 30)]
        public string DataCriacao { get; set; }
    }
}