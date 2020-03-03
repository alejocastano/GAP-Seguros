using System;
using System.Collections.Generic;

namespace GAP.Seguros.Data.Models
{
    public partial class Poliza
    {
        public Poliza()
        {
            ClientePoliza = new HashSet<ClientePoliza>();
        }

        public int IdPoliza { get; set; }
        public string Nombre { get; set; }
        public DateTime? InicioVigencia { get; set; }
        public byte? PeriodoCobertura { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Cobertura { get; set; }
        public byte? IdTipoRiesgo { get; set; }
        public byte? IdTipoCubrimiento { get; set; }
        public virtual TipoRiesgo IdTipoRiesgoNavigation { get; set; }
        public virtual TipoCubrimiento IdTipoCubrimientoNavigation { get; set; }
        public virtual ICollection<ClientePoliza> ClientePoliza { get; set; }
    }
}
