using System;
using System.Collections.Generic;

namespace GAP.Seguros.Data.Models
{
    public partial class TipoCubrimiento
    {
        public TipoCubrimiento()
        {
            Poliza = new HashSet<Poliza>();
        }

        public byte IdTipoCubrimiento { get; set; }
        public string DescCubrimiento { get; set; }

        public virtual ICollection<Poliza> Poliza { get; set; }
    }
}
