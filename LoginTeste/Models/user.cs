namespace LoginTeste.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("login.user")]
    public partial class user
    {
        [Key]
        public int idUsuario { get; set; }

        [StringLength(10)]
        public string nome { get; set; }

        [StringLength(50)]
        public string senha { get; set; }
    }
}
