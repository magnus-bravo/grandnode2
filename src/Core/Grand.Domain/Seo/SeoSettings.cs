﻿using Grand.Domain.Configuration;
using System.Collections.Generic;

namespace Grand.Domain.Seo
{
    /// <summary>
    /// SEO settings
    /// </summary>
    public class SeoSettings : ISettings
    {
        public SeoSettings()
        {
            ReservedEntityUrlSlugs = new List<string>();
        }

        /// <summary>
        /// Page title separator
        /// </summary>
        public string PageTitleSeparator { get; set; }

        /// <summary>
        /// Page itle SEO adjustment
        /// </summary>
        public bool PageTitleSeoAdjustment { get; set; }

        /// <summary>
        /// Default title
        /// </summary>
        public string DefaultTitle { get; set; }
        /// <summary>
        /// Default META keywords
        /// </summary>
        public string DefaultMetaKeywords { get; set; }
        /// <summary>
        /// Default META description
        /// </summary>
        public string DefaultMetaDescription { get; set; }
        /// <summary>
        /// A value indicating whether product META descriptions will be generated automatically (if not entered)
        /// </summary>
        public bool GenerateProductMetaDescription { get; set; }
        /// <summary>
        /// A value indicating whether we should conver non-wetern chars to western ones
        /// </summary>
        public bool ConvertNonWesternChars { get; set; }

        /// <summary>
        /// A value indicating to conver non-wetern chars to western ones
        /// </summary>
        public string SeoCharConversion { get; set; }

        /// <summary>
        /// A value indicating whether unicode chars are allowed
        /// </summary>
        public bool AllowSlashChar { get; set; }

        /// <summary>
        /// A value indicating whether unicode chars are allowed
        /// </summary>
        public bool AllowUnicodeCharsInUrls { get; set; }
        /// <summary>
        /// A value indicating whether canonical URL tags should be used
        /// </summary>
        public bool CanonicalUrlsEnabled { get; set; }        

        /// <summary>
        /// A value indicating whether Twitter META tags should be generated
        /// </summary>
        public bool TwitterMetaTags { get; set; }
        /// <summary>
        /// A value indicating whether Open Graph META tags should be generated
        /// </summary>
        public bool OpenGraphMetaTags { get; set; }
        /// <summary>
        /// Gets or sets a picture identifier of the store picture. If 0, then the default one will be used
        /// </summary>
        public string StorePictureId { get; set; }
        /// <summary>
        /// Slugs (sename) reserved for some other needs
        /// </summary>
        public List<string> ReservedEntityUrlSlugs { get; set; }

        /// <summary>
        /// Custom tags in the head section
        /// </summary>
        public string CustomHeadTags { get; set; }

    }
}