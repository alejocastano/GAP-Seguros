using System;
using System.Collections.Generic;

namespace GAP.Seguros.Data.Models
{
    public partial class TipoCubrimiento
    {
        public TipoCubrimiento()
        {
            PolizaTiposCubrimiento = new HashSet<PolizaTiposCubrimiento>();
        }

        public byte IdTipoCubrimiento { get; set; }
        public string DescCubrimiento { get; set; }

        public virtual ICollection<PolizaTiposCubrimiento> PolizaTiposCubrimiento { get; set; }
    }
}
