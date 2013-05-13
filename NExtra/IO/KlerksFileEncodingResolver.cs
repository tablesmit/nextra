using System.Text;

namespace NExtra.IO
{
    /// <summary>
    /// This class can be used to resolve file encodings,
    /// using the static KlerksSoftFileEncodingDetector.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://danielsaidi.github.com/Cloney
    /// </remarks>
    public class KlerksFileEncodingResolver : IFileEncodingResolver
    {
        private readonly Encoding defaultEncoding;


        public KlerksFileEncodingResolver(Encoding defaultEncoding)
        {
            this.defaultEncoding = defaultEncoding;
        }


        public Encoding ResolveFileEncoding(string filePath)
        {
            return KlerksSoftFileEncodingDetector.DetectTextFileEncoding(filePath, defaultEncoding);
        }
    }
}