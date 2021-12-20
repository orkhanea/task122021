
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task_16._12._2021.Models
{
    public class OurWork
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string SubTitle { get; set; }

        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        [MaxLength(1000)]
        [Required]
        public string Text { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<TagToWork> TagToWorks { get; set; }

        [NotMapped]
        public List<int> TagToWorksId { get; set; }




    }
}
