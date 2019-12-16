using System;
using System.Collections.Generic;

namespace Model
{
    public class Model1
    {

        public class ProdMag
        {
            public int idProd { get; set; }
            public int idMag { get; set; }
            public int qnt { get; set; }

            public virtual Magatzem Magatzem { get; set; }
            public virtual Producte Producte { get; set; }
        }

        public class VProdMag
        {
            public int idProd { get; set; }
            public int idMag { get; set; }
            public int qnt { get; set; }
            public string nomProd { get; set; }
            public string nomMag { get; set; }
        }

        public class Producte
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Producte()
            {
                this.ProdMags = new HashSet<ProdMag>();
            }

            public int id { get; set; }
            public string nom { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<ProdMag> ProdMags { get; set; }
        }

        public class Magatzem
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Magatzem()
            {
                this.ProdMags = new HashSet<ProdMag>();
            }

            public int id { get; set; }
            public string nom { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<ProdMag> ProdMags { get; set; }
        }

    }
}
