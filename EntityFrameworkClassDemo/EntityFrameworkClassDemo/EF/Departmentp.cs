using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkClassDemo.EF
{
    public partial class Department
    {
        public override string ToString()
        {
            return $"{this.vDepartmentName} is at " + $"{this.vLocation} with ID {this.cDepartmentCode}";
        }
    }
}
