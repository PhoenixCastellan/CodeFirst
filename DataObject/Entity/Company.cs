using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    public class Company
    {
        public long Id { get; set; }

        [DisplayName("名称"), Required, StringLength(50)]
        public string Name { get; set; }

        [DisplayName("描述")]
        public string Descript { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
