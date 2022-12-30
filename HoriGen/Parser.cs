using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoriGen
{
    static class Parser
    {
        public static string[] Split(string value, string separator)
        {
            List<string> parts = new List<string>();
            int openBrackets = 0;
            int openParens = 0;
            int startIndex = 0;

            for (int i = 0; i < value.Length; i++)
            {
                char chr = value[i];

                if (chr == '<')
                {
                    openBrackets++;
                }
                else if (chr == '>')
                {
                    openBrackets--;
                }
                else if (chr == '(')
                {
                    openParens++;
                }
                else if (chr == ')')
                {
                    openParens--;
                }
                else if ((openBrackets | openParens) == 0 &&
                    i + separator.Length <= value.Length &&
                    value.Substring(i, separator.Length) == separator)
                {
                    string part = value.Substring(startIndex, i - startIndex);
                    parts.Add(part);
                    startIndex = i + separator.Length;
                    i += separator.Length - 1;
                }
            }

            if (startIndex < value.Length)
            {
                parts.Add(value.Substring(startIndex));
            }

            return parts.ToArray();
        }
    }
}
