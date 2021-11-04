// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 29/10/2021
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
// 0.1	29/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Administracion;
using Buma.Administracion.servicios.Interfaces;

namespace Buma.Administracion.servicios.Inplementaciones
{
    public class RegimenServicio : IRegimenServicio
    {

        public async Task<List<Regimen>> GetRegimenListAsync()
        {
            var regimen = new List<Regimen>();
            return regimen;
        }

        public async Task<Regimen> GetRegimenByIdAsync(int idRegimen)
        {
            var regimen = new Regimen();
            return regimen;
        }
        public async Task InsertRegimen(Regimen regimen)
        {
            regimen = new Regimen();

        }
        public async Task UpdateRegimen(Regimen regimen)
        {
            regimen = new Regimen();
        }


    }
}
