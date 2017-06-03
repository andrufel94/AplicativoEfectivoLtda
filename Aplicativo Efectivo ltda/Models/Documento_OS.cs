using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicativo_Efectivo_ltda.Models
{
    public class Documento_OS : Documento
    {
        [Display(Name = "Sucursal Destino")]
        public int cod_sucursal_destino { get; set; }

        [Display(Name = "Persona Destino")]
        public int cod_persona_destino { get; set; }

        public override string InsertarDocumento()
        {
            throw new NotImplementedException();
        }
    }
}