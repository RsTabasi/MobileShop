using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MvcModel
{
    [Table("Bank")]
    class Bank
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("IDUser", Order = 0)]
        public Guid ID { get; set; }
        public string name { get; set; }

        public virtual Transaction transactions { get; set; }
    }
}
