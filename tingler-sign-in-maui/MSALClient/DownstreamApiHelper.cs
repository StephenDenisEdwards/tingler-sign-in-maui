namespace tingler_sign_in_maui.MSALClient
{
    public class DownstreamApiHelper
    {
        private string[] DownstreamApiScopes;
        public DownStreamApiConfig DownstreamApiConfig;
        private MSALClientHelper MSALClient;

        public DownstreamApiHelper(DownStreamApiConfig downstreamApiConfig, MSALClientHelper msalClientHelper)
        {
            if (msalClientHelper == null)
            {
                throw new ArgumentNullException(nameof(msalClientHelper));
            }

            this.DownstreamApiConfig = downstreamApiConfig;
            this.MSALClient = msalClientHelper;
            this.DownstreamApiScopes = this.DownstreamApiConfig.ScopesArray;
        }
    }
}
