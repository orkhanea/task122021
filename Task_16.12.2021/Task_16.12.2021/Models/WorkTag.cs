
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task_16._12._2021.Models
{
    public class WorkTag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string TagName { get; set; }

        public List<TagToWork> TagToWorks { get; set; }




    }
}
