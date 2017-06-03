using Aplicativo_Efectivo_ltda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicativo_Efectivo_ltda.DAO
{
    public abstract class Cliente_Empresa_DAO
    {
        public abstract List<Cliente_Empresa> Consultar_Clientes_Empresas();
    }
}