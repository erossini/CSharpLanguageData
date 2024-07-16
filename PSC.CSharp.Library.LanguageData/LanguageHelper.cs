using PSC.CSharp.Library.LanguageData.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PSC.CSharp.Library.LanguageData
{
    public class LanguageHelper
    {
        #region Variables

        /// <summary>
        /// The string file name
        /// </summary>
        private const string strFileName = "PSC.CSharp.Library.LanguageData.data.json";

        /// <summary>
        /// The countries
        /// </summary>
        private readonly IEnumerable<Language>? _languages;

        #endregion Variables

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryHelper"/> class.
        /// </summary>
        public LanguageHelper()
        {
            var json = GetJsonData(strFileName);
            _languages = JsonSerializer.Deserialize<List<Language>>(json);
        }

        /// <summary>
        /// Gets the name of the language.
        /// </summary>
        /// <param name="shortCode">The short code.</param>
        /// <returns>System.String.</returns>
        public string? GetData(string shortCode, LanguageCode languageCode = LanguageCode.LanguageName)
        {
            string? rtn = null;

            switch (languageCode)
            {
                case LanguageCode.Code6392B:
                    rtn = _languages?.FirstOrDefault(x => x.ShortCode == shortCode)?.Code6392B;
                    break;
                case LanguageCode.Code6392T:
                    rtn = _languages?.FirstOrDefault(x => x.ShortCode == shortCode)?.Code6392T;
                    break;
                case LanguageCode.Direction:
                    rtn = _languages?.FirstOrDefault(x => x.ShortCode == shortCode)?.Direction;
                    break;
                case LanguageCode.LanguageNative:
                    rtn = _languages?.FirstOrDefault(x => x.ShortCode == shortCode)?.LanguageNative;
                    break;
                default:
                    rtn = _languages?.FirstOrDefault(x => x.ShortCode == shortCode)?.LanguageName;
                    break;
            }

            return rtn;
        }

        /// <summary>
        /// Gets the language.
        /// </summary>
        /// <param name="shortCode">The short code.</param>
        /// <returns>Language.</returns>
        public Language? GetLanguage(string shortCode)
        {
            return _languages?.FirstOrDefault(x => x.ShortCode == shortCode);
        }

        /// <summary>
        /// Gets the language code in ISO 639-2 B.
        /// </summary>
        /// <param name="shortCode">The short code.</param>
        /// <returns>System.Nullable&lt;System.String&gt;.</returns>
        public string? GetLanguageCode6392B(string shortCode)
        {
            return GetData(shortCode, LanguageCode.Code6392B);
        }

        /// <summary>
        /// Gets the language code in ISO 639-2 T.
        /// </summary>
        /// <param name="shortCode">The short code.</param>
        /// <returns>System.Nullable&lt;System.String&gt;.</returns>
        public string? GetLanguageCode6392T(string shortCode)
        {
            return GetData(shortCode, LanguageCode.Code6392T);
        }

        /// <summary>
        /// Gets the language direction.
        /// </summary>
        /// <param name="shortCode">The short code.</param>
        /// <returns>System.Nullable&lt;System.String&gt;.</returns>
        public string? GetLanguageDirection(string shortCode)
        {
            return GetData(shortCode, LanguageCode.Direction);
        }

        /// <summary>
        /// Gets the name of the language.
        /// </summary>
        /// <param name="shortCode">The short code.</param>
        /// <returns>System.Nullable&lt;System.String&gt;.</returns>
        public string? GetLanguageName(string shortCode)
        {
            return GetData(shortCode, LanguageCode.LanguageName);
        }

        /// <summary>
        /// Gets the language native.
        /// </summary>
        /// <param name="shortCode">The short code.</param>
        /// <returns>System.Nullable&lt;System.String&gt;.</returns>
        public string? GetLanguageNative(string shortCode)
        {
            return GetData(shortCode, LanguageCode.LanguageNative);
        }

        /// <summary>
        /// Gets the languages.
        /// </summary>
        /// <returns>List&lt;Language&gt;.</returns>
        public List<Language> GetLanguages()
        {
           return _languages?.ToList();
        }
        /// <summary>
        /// Gets the language script.
        /// </summary>
        /// <param name="shortCode">The short code.</param>
        /// <returns>System.Nullable&lt;System.String&gt;.</returns>
        public string? GetLanguageScript(string shortCode)
        {
            return GetData(shortCode, LanguageCode.Script);
        }
        /// <summary>
        /// Gets the json data.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>System.String.</returns>
        private string GetJsonData(string path)
        {
            string json = "";
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(path))
            {
                var reader = new StreamReader(stream);
                json = reader.ReadToEnd();
            }
            return json;
        }
    }
}