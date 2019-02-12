using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Model
{
    public class TermTranslationContent
    {
        public Dictionary<string, string> KeyValues;
        public string Value;

        public static implicit operator TermTranslationContent(Dictionary<string, string> keyValues) => new TermTranslationContent { KeyValues = keyValues };
        public static implicit operator TermTranslationContent(string value) => new TermTranslationContent { Value = value };
    }
}
