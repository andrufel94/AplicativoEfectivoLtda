using Aplicativo_Efectivo_ltda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicativo_Efectivo_ltda.DAO
{
    public abstract class Cliente_Persona_DAO
    {
        public abstract List<Cliente_Persona> Consultar_Clientes_Personas();
    }
}