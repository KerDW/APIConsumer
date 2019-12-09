using System;
using System.Collections.Generic;

namespace Model
{
    public class Model1
    {

        public partial class telefon
        {
            public int telId { get; set; }
            public string telefon1 { get; set; }
            public string tipus { get; set; }
            public Nullable<int> contacteId { get; set; }

            public virtual contacte contacte { get; set; }
        }

        public partial class email
        {
            public int emailId { get; set; }
            public string email1 { get; set; }
            public string tipus { get; set; }
            public Nullable<int> contacteId { get; set; }

            public virtual contacte contacte { get; set; }
        }

        public class contacte
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public contacte()
            {
                this.emails = new HashSet<email>();
                this.telefons = new HashSet<telefon>();
            }

            public int contacteId { get; set; }
            public string nom { get; set; }
            public string cognoms { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<email> emails { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<telefon> telefons { get; set; }


        }

    }
}
