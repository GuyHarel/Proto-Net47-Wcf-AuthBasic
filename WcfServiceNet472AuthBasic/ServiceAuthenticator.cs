using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WcfServiceNet472AuthBasic
{
    public class ServiceAuthenticator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))

                throw new SecurityTokenException("Username and password required");

            if (!(userName == "util01" && password == "mdp01"))

                throw new FaultException(string.Format("Wrong username ({0}) or password ", userName));
        }
    }
}