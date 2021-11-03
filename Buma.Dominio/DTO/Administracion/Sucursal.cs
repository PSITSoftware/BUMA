// ==================================================================================
// Desarrollado Por	    : Edwin Andres Florez
// Fecha de Creación	: 20/10/2021
// Producto o sistema	: PIDT
// Empresa	: PSIT S.A.S
// Proyecto	: BUMA
// Cliente	: todos
// ==================================================================================
// Versión	Descripción
// 1.0.0.0	<Descripción del archivo>
//
// ==============================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buma.Dominio.DTO.Administracion
{
    class Sucursal
    {
        public int idsucursal
        {
            get;set;
        }
        public string nombre
        {
            get;set;
        }
        public string actividad
        {
            get; set;
        }
        public string Popietario
        {
            get; set;
        }
        public string nit
        {
            get; set;
        }
        public string direccion
        {
            get; set;
        }
        public string telefono
        {
            get; set;
        }
        public string ciudad
        {
            get; set;
        }
        public string leyenda
        {
            get; set;
        }
        public string horario
        {
            get; set;
        }
        public string resolucion
        {
            get; set;
        }
        public DateTime fecharesolucion
        {
            get; set;
        }
        public string prefijo
        {
            get; set;
        }
        public int desde
        {
            get; set;
        }
        public int hasta
        {
            get; set;
        }
        public int idEmpresa
        {
            get; set;
        }
    }
}
