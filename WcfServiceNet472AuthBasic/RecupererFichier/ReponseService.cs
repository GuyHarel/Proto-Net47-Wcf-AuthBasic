using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceNet472AuthBasic.RecupererFichier
{
    [DataContract]
    public class ReponseService
    {
        [DataMember]
        public string CodeRetour {  get; set; }
        [DataMember]
        public string MessageRe { get; set; }
        [DataMember]
        public Reponse[] ListeRaison { get; set; }
        [DataMember]
        public string Promoteur { get; set; }

    }
}