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
    public class RolxUsuario    {
        public int idRol
        {
            get; set;
        }
        public int idUsuarios
        {
            get; set;
        }
        public int Estado
        {
            get; set;
        }
        public string UsuarioCrea
        {
            get; set;
        }
        public DateTime FechaCreacion
        {
            get; set;
        }
    }
    
}
