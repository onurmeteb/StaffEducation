using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Business.Helpers
{
    public static class RegexFormats
    {
        public static string IsOnlyAlfabetichs => @"[a-zA-Z]+";
        public static string AlfNumAndSpecialChar => @"[a-zA-Z0-9#]+";
        public static string IsOnlyNumerics => @"[0-9]+";
        public static string IsOnlydate => @"^\d{1,2}/\d{1,2}/\d{4}$";
    }
}
