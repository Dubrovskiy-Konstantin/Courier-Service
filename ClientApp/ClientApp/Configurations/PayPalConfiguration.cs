using Microsoft.Extensions.Configuration;
using PayPal.Api;
using System.Collections.Generic;

namespace ClientApp.Configurations
{
    public static class PayPalConfiguration
    {
        public static readonly string ClientId;
        public static readonly string ClientSecret;

        static PayPalConfiguration()
        {
            var config = GetConfig();
            ClientId = config["clientId"];
            ClientSecret = config["clientSecret"];
        }

        public static Dictionary<string, string> GetConfig() => 
            new Dictionary<string, string>()
            {
                {"clientId", "ARy3M7Kq23Fbtkl-5NgqhKbXEQFPHlOO9c4A8fgwsHx-L0Gn_S7oQAtC7DP9a2ObYaeUEDPp3prPsGxQ" },
                {"clientSecret", "EPv9c6DmS7jELM-r17GuD4urEJ1r20ntzeATbDuQN8-BLybyBC3p9_j0OckMW2KfEyKRkVITlCDY7Tad" }
            };


        public static APIContext GetAPIContext()
        {
            var apiContext = new APIContext(GetAccessToken());
            apiContext.Config = GetConfig();

            return apiContext;
        }

        private  static string GetAccessToken() => new OAuthTokenCredential(ClientId, ClientSecret, GetConfig()).GetAccessToken();
    }
}