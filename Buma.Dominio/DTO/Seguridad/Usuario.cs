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

namespace buma.dominio.DTO.Seguridad
{
    public class Usuario
    {
        public int idUsuario
        {
            get;set;
        }
        public int idEmpresa
        {
            get;set;
        }
        public int idtipoDocumento
        {
            get;set;
        }
        public string numeroDocumento
        {
            get;set;
        }
        public string PrimerNombre
        {
            get;set;
        }
        public string SegundoNombre
        {
            get;set;
        }
        public string PrimerApellido
        {
            get;set;
        }
        public string SegundoApellido
        {
            get;set;
        }
        public string usuario
        {
            get;set;
        }
        public string password
        {
            get;set;
        }
        public string TelefonoCont
        {
            get;set;
        }
        public string CorreoElect
        {
            get;set;
        }
        public int Estado
        {
            get;set;
        }
        public string Usuariocre
        {
            get;set;
        }
        public DateTime fechacreacion
        {
            get;set;
        }
        public string TipoUsuario
        {
            get;set;
        }
    }
    
}
