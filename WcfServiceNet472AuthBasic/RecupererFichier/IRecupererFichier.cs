using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceNet472AuthBasic.RecupererFichier
{
    [ServiceContract]
    public interface IRecupererFichier
    {
        [OperationContract]
        TelechargerFichierExtrant TelechargerFichier(TelechargerFichierIntrant intrant);
    }
}
