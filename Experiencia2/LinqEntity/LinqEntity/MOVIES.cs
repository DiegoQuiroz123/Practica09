namespace LinqEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOVIES
    {
        [StringLength(2)]
        public string ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Title { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(8)]
        public string Genre { get; set; }

        public double Price { get; set; }

        public double Rating { get; set; }
    }
}
