using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model.Base
{
    public class BaseEntity
    {

        [Column("id")]
        public int Id { get; set; }
    }
}
