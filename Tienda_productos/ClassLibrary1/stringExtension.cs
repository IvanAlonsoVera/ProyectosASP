using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class stringExtension
    {
        public static DateTime IsDateConvert(this String content)
        {
            DateTime date;
            bool result = DateTime.TryParse(content, out date);
            if (result) return date;
            else return DateTime.MinValue;
        }
    }
}
