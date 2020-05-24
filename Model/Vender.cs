namespace workinterview.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vender")]
    public partial class Vender
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vender()
        {
            VenderBages = new HashSet<VenderBage>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string vendorCode { get; set; }

        public bool? noOrder { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public byte? rate { get; set; }

        public byte? rating { get; set; }

        [StringLength(255)]
        public string logo { get; set; }

        [StringLength(255)]
        public string defLogo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VenderBage> VenderBages { get; set; }
    }
}
