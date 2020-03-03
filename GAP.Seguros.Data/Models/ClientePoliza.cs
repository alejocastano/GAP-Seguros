using System;
using System.Collections.Generic;

namespace GAP.Seguros.Data.Models
{
    public partial class ClientePoliza
    {
        public short IdClientePoliza { get; set; }
        public int? IdCliente { get; set; }
        public int? IdPoliza { get; set; }
        public bool? Activo { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Poliza IdPolizaNavigation { get; set; }
    }
}
