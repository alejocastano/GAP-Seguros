using System;
using System.Collections.Generic;

namespace GAP.Seguros.Data.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            ClientePoliza = new HashSet<ClientePoliza>();
        }

        public int IdCliente { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<ClientePoliza> ClientePoliza { get; set; }
    }
}
