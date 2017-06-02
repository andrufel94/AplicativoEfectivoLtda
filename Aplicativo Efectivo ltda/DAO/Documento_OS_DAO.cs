using Aplicativo_Efectivo_ltda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicativo_Efectivo_ltda.DAO
{
    public abstract class Documento_OS_DAO
    {
        public abstract string Insertar_Documento_OS(Documento_OS obj_documento);
    }
}