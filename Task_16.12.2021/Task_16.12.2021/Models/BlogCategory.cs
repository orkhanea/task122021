﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_16._12._2021.Models
{
    public class BlogCategory
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string CategoryName { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
