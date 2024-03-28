using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceNet472AuthBasic.RecupererFichier
{
    [DataContract]
    public class TelechargerFichierIntrant
    {
        [DataMember]
        public System.Guid IdPartenaire { get; set; }

        [DataMember]
        public System.Guid NoRSI { get; set; }

        [DataMember]
        public string CodEtape { get; set; }

        [DataMember]
        public string NomFichier { get; set; }

        [DataMember]
        public string CodCategorie { get; set; }



    }
}