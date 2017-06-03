using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicativo_Efectivo_ltda.Models
{
    public class Documento_FCT : Documento
    {
        [Display(Name = "Empresa")]
        public int cod_empresa { get; set; }

        public override string InsertarDocumento()
        {
            throw new NotImplementedException();
        }
    }
}