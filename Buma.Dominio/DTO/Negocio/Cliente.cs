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

namespace buma.dominio.DTO.Negocio
{
    public class Cliente
    {
        public int idcliente
        {
            get;set;
        }
        public string PrimerNombre
        {
            get; set;
        }
        public string SegundoNombre
        {
            get; set;
        }
        public string PrimerApellido
        {
            get; set;
        }
        public string SegundoApellido
        {
            get; set;
        }
        public int idtipodocumento
        {
            get;set;
        }
        public string Documento
        {
            get;set;
        }
        public string NumeroContacto
        {
            get;set;
        }
        public string Email
        {
            get; set;
        }
        public int idRegimen
        {
            get;set;
        }
        public int idEmpresa
        {
            get;set;
        }
    }
}
