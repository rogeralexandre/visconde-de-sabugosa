using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Util
{
    public sealed class ConversoraData
    {
        public static DateTime ConverterData(String data)
        {
            CultureInfo cultureInfo = new CultureInfo("pt-Br");
            return Convert.ToDateTime(data, cultureInfo);
        }

    }

}
