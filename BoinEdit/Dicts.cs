using System.Collections.Generic;
using FastColoredTextBoxNS;

namespace BoinEditNS {
    public static class Dicts {

        public static Dictionary<string, string> extensionMap = new Dictionary<string, string>();
        public static Dictionary<string, Language> languageMap = new Dictionary<string, Language>();

        public static void init() {
            // Pairing file extensions with languages
            extensionMap.Add(".cs",    "C#");
            extensionMap.Add(".html",  "HTML");
            extensionMap.Add(".htm",   "HTML");
            extensionMap.Add(".js",    "JavaScript");
            extensionMap.Add(".lua",   "Lua");
            extensionMap.Add(".php",   "PHP");
            extensionMap.Add(".phtml", "PHP");
            extensionMap.Add(".phps",  "PHP");
            extensionMap.Add(".sql",   "SQL");
            extensionMap.Add(".vb",    "Visual Basic");
            extensionMap.Add(".vbs",   "Visual Basic");
            extensionMap.Add(".xml",   "XML");
            extensionMap.Add(".rss",   "XML");
            extensionMap.Add(".xsd",   "XML");
            extensionMap.Add(".xslt",  "XML");

            // For textbox language selection
            languageMap.Add("Plain Text", Language.Custom);
            languageMap.Add("C#", Language.CSharp);
            languageMap.Add("HTML", Language.HTML);
            languageMap.Add("JavaScript", Language.JS);
            languageMap.Add("Lua", Language.Lua);
            languageMap.Add("PHP", Language.PHP);
            languageMap.Add("SQL", Language.SQL);
            languageMap.Add("Visual Basic", Language.VB);
            languageMap.Add("XML", Language.XML);
        }
    }
}
