
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task_16._12._2021.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Logo { get; set; }

        [NotMapped]
        public IFormFile LogoFile { get; set; }

        [MaxLength(250)]
        public string FooterLogo { get; set; }

        [NotMapped]
        public IFormFile FooterLogoFile { get; set; }

        [MaxLength(250)]
        public string FooterBg { get; set; }

        [NotMapped]
        public IFormFile FooterBgFile { get; set; }

        [MaxLength(25)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(1000)]
        public string Info { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(30)]
        public string Copyright { get; set; }

        [MaxLength(250)]
        public string CopyrightLink { get; set; }



    }
}
