namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsBrandingOptions : INestedOptions
    {
        [JsonProperty("logo")]
        public string LogoFileId { get; set; }

        [JsonProperty("primary_color")]
        public string PrimaryColor { get; set; }
    }
}
