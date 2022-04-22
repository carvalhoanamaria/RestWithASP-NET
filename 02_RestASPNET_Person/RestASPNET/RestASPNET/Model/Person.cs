using System.ComponentModel.DataAnnotations.Schema;


namespace RestASPNET.Model
{
    [Table("person")] // Usado por causa do Linux. Colocando o nome da tabela da mesma forma como esta.
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("first_name")]
        public string FirsName { get; set; }
        [Column("last_name")]
        public string LasName { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("gender")]
        public string Gender { get; set; }
    }
}
