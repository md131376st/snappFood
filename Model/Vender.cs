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
      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
        [StringLength(255)]
        public string address { get; set; }
       

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VenderBage> VenderBages { get; set; }
        public Vender()
        {
            VenderBages = new HashSet<VenderBage>();
        }
        public Vender(int id,
                      string vendorCode,
                      bool? noOrder,
                      string title,
                      string description,
                      byte? rate,
                      byte? rating,
                      string logo,
                      string defLogo,
                      string address)
        {
            this.id = id;
            this.vendorCode = vendorCode;
            this.noOrder = noOrder;
            this.title = title;
            this.description = description;
            this.rate = rate;
            this.rating = rating;
            this.logo = logo;
            this.defLogo = defLogo;
            this.address = address;
            this.VenderBages = new HashSet<VenderBage>();
        }


    }
}
