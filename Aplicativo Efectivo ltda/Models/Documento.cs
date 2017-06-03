using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicativo_Efectivo_ltda.Models
{
    public abstract class Documento
    {
        public int cod_doc { get; set; }

        [Display(Name = "Sucursal Origen")]
        public int cod_sucursal_origen { get; set; }

        [Display(Name = "Persona Remitente")]
        public int cod_persona_remitente { get; set; }

        [Display(Name = "Fecha")]
        public DateTime date_fecha_doc { get; set; }

        [Display(Name = "Valor")]
        public decimal valor { get; set; }

        public abstract string InsertarDocumento();
    }
}