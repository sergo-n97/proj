using System.Collections.Generic;

namespace proj.Models
{
    public class Projects : BaseModel
    {
        public string Name { get; set; }

        public List<Programmer> Programmer;

        public virtual int CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
