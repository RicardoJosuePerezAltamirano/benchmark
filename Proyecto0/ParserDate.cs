using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto0
{
    public class ParserDate
    {
        // paso 1
        public int GetYearFromDatetime(string DateTimeAsString)
        {
            var datetime = DateTime.Parse(DateTimeAsString);
            return datetime.Year;
        }

        // paso 2

        public int GetYearFromSpit(string DateTimeAsString)
        {
            var split = DateTimeAsString.Split('-');
            return int.Parse(split[0]);
        }
        // paso 3

        public int GetYearFromSubstring(string DateTimeAsString)
        {
            var index = DateTimeAsString.IndexOf('-');
            return int.Parse(DateTimeAsString.Substring(0, index));
        }
        // paso 4

        public int GetYearFromSpan(ReadOnlySpan<char> DateTimeAsSpan)
        {
            var index = DateTimeAsSpan.IndexOf('-');
            return int.Parse(DateTimeAsSpan.Slice(0, index));
        }
    }
}
