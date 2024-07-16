namespace PSC.CSharp.Library.LanguageData
{
    /// <summary>
    /// Class Language.
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Gets or sets the code in ISO 639-2 B.
        /// </summary>
        /// <value>The code in ISO 639-2 B format.</value>
        public string? Code6392B { get; set; }

        /// <summary>
        /// Gets or sets the code in ISO 639-2 T.
        /// </summary>
        /// <value>The code in ISO 639-2 T format.</value>
        public string? Code6392T { get; set; }

        /// <summary>
        /// Gets or sets the direction of the language (ltr or rtl)
        /// </summary>
        /// <value>The direction.</value>
        public string? Direction { get; set; }

        /// <summary>
        /// Gets or sets the name of the language.
        /// </summary>
        /// <value>The name of the language.</value>
        public string? LanguageName { get; set; }

        /// <summary>
        /// Gets or sets the language native.
        /// </summary>
        /// <value>The language native.</value>
        public string? LanguageNative { get; set; }

        /// <summary>
        /// Gets or sets the script.
        /// </summary>
        /// <value>The script.</value>
        public string? Script { get; set; }

        /// <summary>
        /// Gets or sets the short code.
        /// </summary>
        /// <value>The short code.</value>
        public string? ShortCode { get; set; }
    }
}