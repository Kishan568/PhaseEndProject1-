using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectEnd1.Models
{ 
        [Table("DeptMaster")]
        public class DeptMaster
        {
            [Key]
            public int DeptCode { get; set; }

            public string DeptName { get; set; }
            public virtual ICollection<EmpProfile> EmpProfile { get; set; }
        }
    }

