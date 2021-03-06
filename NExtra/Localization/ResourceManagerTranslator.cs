using System.Globalization;
using System.Resources;
using System.Threading;

namespace NExtra.Localization
{
    ///<summary>
    /// This class can be used to translate language keys,
    /// using a resource file. It requires an exact match
    /// to translate a language key.
    ///</summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://danielsaidi.github.com/nextra
    /// </remarks>
    public class ResourceManagerTranslator : ITranslator
    {
        private readonly ResourceManager _resourceManager;


        public ResourceManagerTranslator(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }


        public virtual string Translate(string key)
        {
            return Translate(key, Thread.CurrentThread.CurrentUICulture);
        }

        public virtual string Translate(string key, CultureInfo cultureInfo)
        {
            return _resourceManager.GetString(key, cultureInfo);
        }

        public bool TranslationExists(string key)
        {
            return TranslationExists(key, Thread.CurrentThread.CurrentUICulture);
        }

        public bool TranslationExists(string key, CultureInfo cultureInfo)
        {
            return Translate(key, cultureInfo) != null;
        }
    }
}
