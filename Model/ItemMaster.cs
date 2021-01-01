using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ItemMaster
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        [MaxLength(100)]
        public string LongDescription { get; set; }
        [MaxLength(50)]
        public string ShortDescription { get; set; }
        [MaxLength(14)]
        public string ItemCode { get; set; }
        [MaxLength(13)]
        public string BarCode { get; set; }
    }
}
