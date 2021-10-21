// ==================================================================================
// Desarrollado Por	    : Silvio Alejandro Reyes Jota
// Fecha de Creación	: 20/10/2021
// Producto o sistema	: BUMA
// Empresa	: PSIT S.A.S
// Proyecto	: BUMA
// Cliente	: todos
// ==================================================================================
// Versión	Descripción
// 1.0.0.0	<Descripción del archivo>
//
// ==================================================================================
// HISTORIAL DE CAMBIOS:
// =================================================================================
// Ver.	Fecha	        Autor	                            Descripción
// ---	-------------	----------------------	-----------------------------------
// 0.1	 20/10/2021	    Silvio A. Reyes J.             Desarrollo Inicial

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Seguridad;

namespace buma.security.servicios.interfaces
{
    public interface IUsuarioServicio
    {
        public Task<List<Usuario>> GetUsuariosListAsync();
    }
}
