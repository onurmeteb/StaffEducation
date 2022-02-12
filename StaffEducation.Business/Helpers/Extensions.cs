using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Business.Helpers
{
    public static class Extensions
    {
        public static bool IsEmpty(this string val)
        {
            return val == null ? true : string.IsNullOrEmpty(val.Trim());
        }
    }
}
