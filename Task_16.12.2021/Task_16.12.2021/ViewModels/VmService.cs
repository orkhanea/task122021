using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_16._12._2021.Models;

namespace Task_16._12._2021.ViewModels
{
    public class VmService : VmLayout
    {
        public Banner Banner { get; set; }

        public List<Service> Services { get; set; }
        public List<OurWork> OurWorks { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<TagToWork> TagToWorks { get; set; }
        public List<WorkTag> WorkTags { get; set; }

        
    }
}
