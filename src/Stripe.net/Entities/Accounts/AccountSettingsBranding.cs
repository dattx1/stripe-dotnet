namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsBranding : StripeEntity
    {
        #region Expandable Logo

        /// <summary>
        /// (ID of a <see cref="File"/>) A logo for this account (at least 128px x 128px).
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string LogoId { get; set; }

        /// <summary>
        /// (Expanded) A logo for this account (at least 128px x 128px).
        /// </summary>
        [JsonIgnore]
        public File Logo { get; set; }

        [JsonProperty("logo")]
        internal object InternalLogo
        {
            get
            {
                return this.Logo ?? (object)this.LogoId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.LogoId = s, o => this.Logo = o);
            }
        }
        #endregion

        [JsonProperty("primary_color")]
        public string PrimaryColor { get; set; }
    }
}
