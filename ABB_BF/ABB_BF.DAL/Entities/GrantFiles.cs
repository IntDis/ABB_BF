using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_BF.DAL.Entities
{
    public class GrantFiles : AbstractFormFile
    {
        public virtual Grant Grant { get; set; }
    }
}
