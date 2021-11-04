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

namespace buma.dominio.DTO.Administracion
{
    public class Empresa
    {
        public int idempresa
        {
            get;set;
        }
        public int idtipoempresa
        {
            get;set;
        }
        public int idregimen
        {
            get;set;
        }
        public string nombreempresa
        {
            get;set;
        }
        public string nit
        {
            get;set;
        }
        public string direccion
        {
            get;set;
        }
        public string basededatos
        {
            get;set;
        }
        public int numerousuarios
        {
            get;set;
        }
        public int key_code
        {
            get;set;
        }
        public string usuariocreacion
        {
            get;set;
        }
        public DateTime fechacreacion
        {
            get;set;
        }
        public char estado
        {
            get;set;
        }
    }
}
