using GAP.Seguros.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Seguros.Business
{
    public class PolizasBL
    {
        public ValidationResult ValidarRiesgoPoliza(Poliza poliza) {

            return new ValidationResult
            {
                valido = !(poliza.Cobertura > 50 && poliza.IdTipoRiesgo == 4),
                mensaje = (poliza.Cobertura > 50 && poliza.IdTipoRiesgo == 4) ?
                "El pocentaje de cubrimiento no puede ser mayor al 50% ya que el tipo de riesgo es alto" : ""
            };
        }
    }

    public class ValidationResult{
        public bool valido { get; set; }
        public string mensaje { get; set; }
    }
}
