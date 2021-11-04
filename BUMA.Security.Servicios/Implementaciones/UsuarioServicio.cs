// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 26/10/2021
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
// Ver.	Fecha	        Autor	                Descripción
// ---	-------------	----------------------	-----------------------------------
// 0.1	26/10/2021	    Edwn Andres Florez	    Desarrollo Inicial
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Seguridad;
using buma.security.servicios.interfaces;

namespace buma.security.servicios.implementaciones

{
    public class UsuarioServicio : IUsuarioServicio
    {
        public async Task<List<Usuario>> GetUsuarioListAsync()
        {
            var usuario = new List<Usuario>();
            return usuario;
        }

        public async Task<Usuario> GetUsuarioByIdAsync(int idUsuario)
        {
            var usuario = new Usuario();
            return usuario;
        }
        public async Task InsertUsuario(Usuario usuario)
        {
            usuario = new Usuario();

        }
        public async Task UpdateUsuario(Usuario usuario)
        {
            usuario = new Usuario();
        }
    }
}
