namespace workinterview.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VenderBage
    {
        public VenderBage(){}
        public int Id { get; set; }

        public int? IdVender { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        [StringLength(255)]
        public string white_image { get; set; }

        public VenderBage(int? idVender, Badge badge)
        {
            this.IdVender = idVender;
            this.title = badge.title;
            this.description = badge.description;
            this.image = badge.image;
            this.white_image = badge.white_image;
        }
        public virtual Vender Vender { get; set; }
    }
}
