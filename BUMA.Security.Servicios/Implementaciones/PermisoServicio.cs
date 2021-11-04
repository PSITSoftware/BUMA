// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 25/10/2021
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
// 0.1	25/10/2021	    Edwn Andres Florez	    Desarrollo Inicial
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Seguridad;
using buma.security.servicios.Interfaces;

namespace buma.securiy.servicios.Implementaciones
{
    public class PermisoServicio : IPermisoServicio
    {

        public async Task<List<Permiso>> GetPermisosListAsync()
        {

            var permisos = new  List<Permiso>();
            return permisos;
        }

        public async Task<Permiso> GetPermisosByIdAsync(int idPermisos)
        {
            var permisos = new Permiso();
            return permisos;
        }
        public async Task InsertPermisos(Permiso permiso)
        {
            permiso = new Permiso();

        }
        public async Task UpdatePermisos(Permiso permiso)
        {
            permiso = new Permiso();
        }
    }
       
}

