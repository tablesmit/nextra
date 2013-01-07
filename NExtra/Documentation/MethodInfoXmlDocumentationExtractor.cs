﻿using System.Reflection;
using System.Xml;

namespace NExtra.Documentation
{
    ///<summary>
    /// This class can be used to extract XML documentation
    /// data for MethodInfo instances.
    ///</summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://danielsaidi.github.com/nextra
    /// </remarks>
    public class MethodInfoXmlDocumentationExtractor : IMethodInfoDocumentationExtractor
    {
        private readonly IDocumentationElementExtractor xmlDocumentationElementExtractor;


        /// <param name="xmlDocumentationElementExtractor">The element documentation extractor to use.</param>
        public MethodInfoXmlDocumentationExtractor(IDocumentationElementExtractor xmlDocumentationElementExtractor)
        {
            this.xmlDocumentationElementExtractor = xmlDocumentationElementExtractor;
        }


        public XmlElement ExtractDocumentation(MethodInfo methodInfo)
        {
            var parametersString = "";
            foreach (var parameterInfo in methodInfo.GetParameters())
            {
                if (parametersString.Length > 0)
                    parametersString += ",";
                parametersString += parameterInfo.ParameterType.FullName;
            }

            return parametersString.Length > 0 ?
                xmlDocumentationElementExtractor.ExtractDocumentationElement(methodInfo.DeclaringType, 'M', methodInfo.Name + "(" + parametersString + ")") :
                xmlDocumentationElementExtractor.ExtractDocumentationElement(methodInfo.DeclaringType, 'M', methodInfo.Name);
        }
    }
}
