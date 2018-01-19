using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace umayplusapi.Models
{
    [Table("Member")]
    public class Member
    {
        public int id { get; set; }
        [Column("umayplusCardID")]
        public string UmayplusCardID { get; set; }
        [Column("personalCardID")]
        public string PersonalCardID { get; set; }
        public string BirthDate { get; set; }
        public string MobilePhone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
