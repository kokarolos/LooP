using PayPal.Api;
using System.Collections.Generic;


namespace Loop.Entities.Concrete
{
    public class PayPalConfiguration
    {
        public readonly static string clientId;
        public readonly static string clientSecret;

        static PayPalConfiguration() 
        {
            var config = getconfig();
            clientId = "AbNxFG-ejBxFK796B8DuVaikZ0OoYE_YrgF1TNGrn_afcTcjfyBHej_IpLxN3fOyBDZOdTYqGO-vfR-D";
            clientSecret = "ED8pyzLaWuUr3VrRXPImZ7IQMUV1sF30TpPXmiG1DcmNtdEPNfuR644KOogcEnj4sAQsMxgHdIIXEhDK";
        }

        private static Dictionary<string,string> getconfig()
        {
            return ConfigManager.Instance.GetProperties();
        }

        private static string GetAccessToken() 
        {
            string accessToken= new OAuthTokenCredential(clientId,clientSecret,getconfig()).GetAccessToken();
            return accessToken;
        }

        public static APIContext GetAPIContext() 
        {
            APIContext aPIContext = new APIContext(GetAccessToken());
            aPIContext.Config = getconfig();
            return aPIContext;
        }
    }
}
