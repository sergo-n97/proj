using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proj.Models
{
    [Table("Company")]
    public class Company: BaseModel
    {
        public string Name { get; set; } // компания

        public virtual int ProjectId { get; set; }
        public  List<Projects> Projects { get; set; } // проекты

        public virtual int ProgrammerId { get; set; }
        public List<Programmer> Programmer { get; set; } //программисты
    }
}
