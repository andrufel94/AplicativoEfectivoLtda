using Aplicativo_Efectivo_ltda.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Aplicativo_Efectivo_ltda.DAO
{
    public abstract class Sucursal_DAO
    {
        public abstract List<Sucursal> Consultar_Sucursales();
    }
}