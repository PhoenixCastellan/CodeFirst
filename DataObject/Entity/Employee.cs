using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    public class Employee
    {
        public long Id { get; set; }

        [ForeignKey("Company")]
        public long CompanyId { get; set; }

        [DisplayName("名称"), Required, StringLength(50)]
        public string Name { get; set; }

        public Gender Gender { get; set; }
        public int Height { get; set; }
        public decimal Weight { get; set; }


        public Company Company { get; set; }

    }
}
