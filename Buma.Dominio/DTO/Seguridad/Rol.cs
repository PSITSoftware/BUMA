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

namespace Buma.Dominio.DTO.Seguridad
{
    public class Rol
    {
        public int idRol
        {
            get; set;
        }
        public string ProviderKey
        {
            get; set;
        }
        public string Nombre
        {
            get; set;
        }
        public string Descripcion
        {
            get; set;
        }
        public int Estado
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
    }
}
