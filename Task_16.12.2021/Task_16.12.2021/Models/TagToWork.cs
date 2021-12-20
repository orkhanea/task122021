
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task_16._12._2021.Models
{
    public class TagToWork
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("WorkTag")]
        public int WorkTagId { get; set; }

        public WorkTag WorkTag { get; set; }

        [ForeignKey("OurWork")]
        public int OurWorkId { get; set; }
        
        public OurWork OurWork { get; set; }




    }
}
