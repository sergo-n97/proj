using proj.Models;
using System.Collections.Generic;

namespace proj.ViewModel
{
    public class HomeDto
    {
        public HomeDto()
        {
            Companies = new List<Company>();
            Projects = new List<Projects>();
        }

        public IList<Company> Companies { get; set; }

        public IList<Projects> Projects { get; set; }


    }
}
