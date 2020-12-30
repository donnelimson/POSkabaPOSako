using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AppuserLoginHistory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Appuser")]
        public int AppuserId { get; set; }
        public virtual Appuser Appuser { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime? LogoutDate { get; set; }
    }
}
