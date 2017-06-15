namespace LoginTeste.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("login.navio")]
    public partial class navio
    {
        [Key]
        public int idNavio { get; set; }

        [StringLength(70)]
        public string vesselName { get; set; }

        [StringLength(50)]
        public string flag { get; set; }

        [StringLength(15)]
        public string callSign { get; set; }

        public int? imo { get; set; }

        public int? loa { get; set; }

        public int? nrt { get; set; }

        public int? grt { get; set; }

        public int? dwt { get; set; }

        [Column(TypeName = "year")]
        public short? builtYear { get; set; }
    }
}
