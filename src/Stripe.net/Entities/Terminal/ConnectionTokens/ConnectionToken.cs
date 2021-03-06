namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ConnectionToken : StripeEntity, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}
