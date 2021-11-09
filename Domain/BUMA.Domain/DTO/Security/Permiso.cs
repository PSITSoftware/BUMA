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
    public class Permiso
    {
        public int idPermiso
        {
            get; set;
        }
        public int idPrograma
        {
            get; set;
        }
        public int idRol
        {
            get; set;
        }
        public int Insertar
        {
            get; set;
        }
        public int Modificar
        {
            get; set;
        }
        public int Eliminar
        {
            get; set;
        }
        public int Consultar
        {
            get; set;
        }
        public string UsuarioCrea
        {
            get; set;
        }
        public DateTime fechaCreacion
        {
            get; set;
        }
    }
}
