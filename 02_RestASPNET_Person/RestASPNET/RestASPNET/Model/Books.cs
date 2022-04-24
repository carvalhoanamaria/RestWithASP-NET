using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using RestASPNET.Model.Base;

namespace RestASPNET.Model
{
    [Table("books")]
    public class Books : BaseEntity
    {

        [Column("author")]
        public string Author { get; set; }

        [Column("launch_date")]
        public DateTime Launch_date { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("title")]
        public string Title { get; set; }
    }
}
