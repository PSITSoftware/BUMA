﻿// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 24/11/2021
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
// 0.1	24/11/2021	    Edwn Andres Florez	    Desarrollo Inicial
using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Interfaces
{
    public interface IRolporUsuarioPersistencia
    {
        Task<List<RolxUsuario>> GetRolporUsuarioListAsync();
        Task<RolxUsuario> GetRolporUsuarioByIdAsync(int idRolxusuario);
        Task InsertRolporUsuario(RolxUsuario rolporusuario);
        Task UpdateRolporUsuario(RolxUsuario rolporusuario);
    }
}