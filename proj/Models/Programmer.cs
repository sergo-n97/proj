using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proj.Models;

namespace proj.Models
{
    public class Programmer : BaseModel
    {
        public string Name { get; set; }

        public virtual int ProjectId {get; set; }

        public List<Projects> Projects { get; set; }

        public virtual int CompanyId { get; set; }

        public virtual Company Company { get; set; }

    }
}
