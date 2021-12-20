using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_16._12._2021.ViewModels
{
    public class VmRegister
    {
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Surname { get; set; }

        [MaxLength(15)]
        public string UserName { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(40)]
        public string Password { get; set; }

    }
}
