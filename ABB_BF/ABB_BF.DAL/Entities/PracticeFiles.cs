using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_BF.DAL.Entities
{
    public class PracticeFiles : AbstractFormFile
    {
        public virtual Practice Practice { get; set; }
    }
}
