using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_BF.DAL.Entities.EnumsToEntities
{
    public abstract class AbstractEnumsToEntities
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Definition { get; set; }
    }
}
