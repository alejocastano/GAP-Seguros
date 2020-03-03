using System;
using System.Collections.Generic;

namespace GAP.Seguros.Data.Models
{
    public partial class PolizaTiposCubrimiento
    {
        public int IdPolizaTiposCubrimiento { get; set; }
        public byte? IdTipoCubrimiento { get; set; }
        public int? IdPoliza { get; set; }

        public virtual Poliza IdPolizaNavigation { get; set; }
        public virtual TipoCubrimiento IdTipoCubrimientoNavigation { get; set; }
    }
}
