namespace EntityFrameworkClassDemo.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        [Key]
        [StringLength(4)]
        public string cDepartmentCode { get; set; }

        [StringLength(25)]
        public string vDepartmentName { get; set; }

        [StringLength(25)]
        public string vDepartmentHead { get; set; }

        [StringLength(20)]
        public string vLocation { get; set; }
    }
}
