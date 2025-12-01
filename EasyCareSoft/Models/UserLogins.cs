using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace EasyCareSoft.Models
{
    public class UserLogins
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int UserAutoID { get; set; }
        public string UserID { get; set; } = string.Empty;
        public string Pswd { get; set; } = string.Empty;
        public int EmpNo { get; set; }
        public string ActiveStatus { get; set; } = string.Empty;
        public DateTime EntDateTime { get; set; }
        public DateTime UpdDateTime { get; set; }
        public string UpdUserID { get; set; } = string.Empty; 

    }
}
