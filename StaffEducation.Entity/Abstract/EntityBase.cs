using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Entity.Abstract
{
    public class EntityBase : IEntityBase
    {
        [Key]
        public Int64 ID { get; set; }
        public int DataStatus { get; set; }
    }
}
