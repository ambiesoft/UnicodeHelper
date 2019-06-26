using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Ambiesoft
{
    public class UnicodeHelper
    {
        static public string[] ExtractWords(string text)
        {
            if (string.IsNullOrEmpty(text))
                return new string[0];

            Regex reg = new Regex(@"(\p{N}|\p{L})+");
            List<string> rets = new List<string>();
            foreach(Match m in reg.Matches(text))
            {
                rets.Add(m.Value);
            }
            return rets.ToArray();
        }
    }
}
