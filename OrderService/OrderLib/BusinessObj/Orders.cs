using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib.BusinessObj
{
    public class Orders
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public int AccountId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int OrderCode { get; set; }
    }
}
