using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task_16._12._2021.Models
{
    public class CustomUser :IdentityUser
    {
        [MaxLength(25)]
        public string Name { get; set; }

        [MaxLength(25)]
        public string Surname { get; set; }

        public DateTime CreatedDate { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
