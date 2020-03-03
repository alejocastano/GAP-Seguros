using System;
using System.Collections.Generic;

namespace GAP.Seguros.Data.Models
{
    public partial class TipoRiesgo
    {
        public TipoRiesgo()
        {
            Poliza = new HashSet<Poliza>();
        }

        public byte IdTipoRiesgo { get; set; }
        public string DescTipoRiesgo { get; set; }

       public virtual ICollection<Poliza> Poliza { get; set; }
    }
}
