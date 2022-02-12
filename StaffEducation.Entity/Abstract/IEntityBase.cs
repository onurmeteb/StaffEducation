using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Entity.Abstract
{
    public interface IEntityBase
    {
        Int64 ID { get; set; }
        int DataStatus { get; set; }

    }
}
