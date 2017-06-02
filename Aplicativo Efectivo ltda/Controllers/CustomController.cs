using Aplicativo_Efectivo_ltda.DAO;
using Aplicativo_Efectivo_ltda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicativo_Efectivo_ltda.Controllers
{
    public class CustomController : Controller
    {
        //
        // GET: /Custom/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult InsertarDocumentoOS()
        {
            Sucursal_DAO_DB my_sucursal = new Sucursal_DAO_DB();
            Cliente_Persona_DAO_DB my_cliente_persona = new Cliente_Persona_DAO_DB();

            ViewBag.VB_Sucursales = new SelectList(my_sucursal.Consultar_Sucursales(), "cod_sucursal", "nom_sucursal");
            ViewBag.VB_Clientes_Personas = new SelectList(my_cliente_persona.Consultar_Clientes_Personas(), "cod_cliente_persona", "nom_cliente_persona");

            ViewBag.VB_Fecha_Actual = DateTime.Now;

            return View();
        }
        [HttpPost]
        public ActionResult InsertarDocumentoOS(Documento_OS doc_os)
        {
            Documento_OS_DAO_DB my_new_doc_os = new Documento_OS_DAO_DB();
            string result = my_new_doc_os.Insertar_Documento_OS(doc_os);

            Sucursal_DAO_DB my_sucursal = new Sucursal_DAO_DB();
            Cliente_Persona_DAO_DB my_cliente_persona = new Cliente_Persona_DAO_DB();

            ViewBag.VB_Sucursales = new SelectList(my_sucursal.Consultar_Sucursales(), "cod_sucursal", "nom_sucursal");
            ViewBag.VB_Clientes_Personas = new SelectList(my_cliente_persona.Consultar_Clientes_Personas(), "cod_cliente_persona", "nom_cliente_persona");

            ViewBag.VB_Fecha_Actual = doc_os.date_fecha_doc;
            ViewBag.VB_Result = result;

            return View();
        }
	}
}