﻿using System.Reflection;
using System.Xml;

namespace NExtra.Documentation
{
    /// <summary>
    /// This interface can be implemented by classes that can
    /// extract XML documentation for assemblies.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://danielsaidi.github.com/nextra
    /// </remarks>
    public interface IAssemblyDocumentationExtractor
    {
        /// <summary>
        /// Extract XML documentation for an assembly, using
        /// the default documentation file location.
        /// </summary>
        XmlDocument ExtractDocumentation(Assembly assembly);

        /// <summary>
        /// Extract XML documentation for an assembly, using
        /// a custom documentation file location.
        /// </summary>
        XmlDocument ExtractDocumentation(Assembly assembly, string xmlFilePath);
    }
}
