using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL.Function
{
    public static class GetFormatString
    {
        public static string MakingIDNow()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +
                   DateTime.Now.Second.ToString();
        }
        public static string MakingIDNHANVIEN()
        {
            return DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +
                   DateTime.Now.Second.ToString();
        }

        public static string GetCurrencyString(double value)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            return value.ToString("#,###", cul.NumberFormat) + " vnđ";
        }

    }
}
