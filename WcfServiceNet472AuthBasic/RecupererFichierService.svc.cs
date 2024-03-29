using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceNet472AuthBasic.RecupererFichier;

namespace WcfServiceNet472AuthBasic
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "RecupererFichierService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez RecupererFichierService.svc ou RecupererFichierService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class RecupererFichierService : IRecupererFichier
    {


        public TelechargerFichierExtrant TelechargerFichier(TelechargerFichierIntrant intrant)
        {
            var extrant = new TelechargerFichierExtrant { Categorie = "Une categorie" };

            var webOperationContext = WebOperationContext.Current;
            var securityContext = ServiceSecurityContext.Current;

            try
            {
                var chemin = AppDomain.CurrentDomain.BaseDirectory;
                chemin += "bin\\Fichiers\\Test-Fichier.docx";

                byte[] bytes = System.IO.File.ReadAllBytes(chemin);

                extrant.Fichier = bytes;
            }
            catch (Exception ex)
            {

                throw;
            }



            return extrant; 
        }
    }
}
