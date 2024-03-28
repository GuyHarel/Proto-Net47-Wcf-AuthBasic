using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceNet472AuthBasic.RecupererFichier
{

    [DataContract]
    public class Reponse
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Message { get; set; }


    }
}