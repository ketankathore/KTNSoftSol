using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace EasyCareSoft.Models
{
    public class UserLogins
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int EntNo { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Boolean Satus { get; set; }
        public DateTime EntDateTime { get; set; }
        public string UserID { get; set; } = string.Empty;
        public DateTime UpdDateTime { get; set; }
        public string UpdUserID { get; set; } = string.Empty;



    }
}
