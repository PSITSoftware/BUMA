// ==================================================================================
// Desarrollado Por	    : Edwin Andres Florez
// Fecha de Creación	: 19/10/2021
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

namespace BUMA.Domain.DTO.Security
{
    public class Programa
    {
        public int idPrograma
        {
            get; set;
        }
        public int idModulo
        {
            get; set;
        }
        public string NombrePrograma
        {
            get; set;
        }
        public string CodigoPodrigo
        {
            get; set;
        }
        public int posicion
        {
            get; set;
        }
        public int estado
        {
            get; set;
        }
        public string UsuarioCreacion
        {
            get; set;
        }
        public DateTime fechacreacion
        {
            get; set;
        }
        public int visiblemenu
        {
            get; set;
        }
        public int generaLog
        {
            get; set;
        }
    }
}
