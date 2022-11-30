namespace CatalogWitcher.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Character
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Sex { get; set; }

        [StringLength(100)]
        public string Race { get; set; }

        [StringLength(100)]
        public string Occupation { get; set; }

        [StringLength(50)]
        public string Belonging { get; set; }

        public string Description { get; set; }

        public string Img { get; set; }

        public int? CharaptersId { get; set; }

        public virtual Chapter Chapter { get; set; }
    }
}
