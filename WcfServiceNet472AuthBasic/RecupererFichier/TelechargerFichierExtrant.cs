using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceNet472AuthBasic.RecupererFichier
{
    [DataContract]
    public class TelechargerFichierExtrant
    {
        [DataMember]
        public System.Guid NoRSI { get; set; }
        [DataMember]
        public string NomFichier { get; set; }
        [DataMember]
        public string Etape { get; set; }
        [DataMember]
        public byte[] Fichier { get; set; }
        [DataMember]
        public string Categorie { get; set; }
        [DataMember]
        public byte[] Signature { get; set; }
        [DataMember]
        public System.DateTime DateDepot { get; set; }
        [DataMember]
        public ReponseService ReponseService { get; set; }

    }
}