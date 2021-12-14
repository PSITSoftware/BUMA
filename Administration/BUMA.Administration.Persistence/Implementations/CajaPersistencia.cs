// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 22/11/2021
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
// 0.1	22/11/2021	    Edwn Andres Florez	    Desarrollo Inicial
using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Utilities.Connection;
using Npgsql;
using System.Data;
using System;
using System.Linq;

namespace BUMA.Administration.Persistence.Implementations
{
    public class CajaPersistencia : ICajaPersistencia
    {
        PostgressConection _idConnection;
        public async Task npglsqlConection()
        {
            PostgressConection npgcon = new PostgressConection();
            npgcon.ConnectionPostgressAdmin().Open();
            _idConnection = npgcon;

        }
        public async Task<List<Caja>> GetCajaListAsync()
        {
            try
            {
                // Start a transaction as it is required to work with cursors in PostgreSQL
                NpgsqlCommand command = new NpgsqlCommand("SelectCaja", _idConnection.ConnectionPostgressAdmin());
                command.CommandType = CommandType.StoredProcedure;


                // Execute the stored procedure and obtain the first result set
                NpgsqlDataReader dr = command.ExecuteReader();
                //var caja = new List<Caja>();
                //return caja;
            }
            catch (NpgsqlException ex)
            {

            }
            return new List<Caja>();

        }
        public async Task<Caja> GetCajaByIdAsync(int idCaja)
        {
            var _caja = new List<Caja>();
            //var caja = new Caja();
            //return caja;
            try
            {
                // Start a transaction as it is required to work with cursors in PostgreSQL
                NpgsqlCommand command = new NpgsqlCommand("SelectIdCaja", _idConnection.ConnectionPostgressAdmin());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@pid_caja", idCaja);


                // Execute the stored procedure and obtain the first result set
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    var cajas = new Caja()
                    {
                        idcaja = Convert.ToInt32(dr["Id_Caja"]),
                        nombrecaja = Convert.ToString(dr["Nombre"]),
                        codigocaja = Convert.ToString(dr["Codigo_Caja"]),
                        esprincipal = Convert.ToInt32(dr["Es_Principal"])
                    };
                    _caja.Add(cajas);
                }
              
            }
            catch (NpgsqlException ex)
            {

            }
            /// validar el retorno
            return null;
        }
        public async Task InsertCaja(Caja caja)
        {
            caja = new Caja();
        }
        public async Task UpdateCaja(Caja caja)
        {
            caja = new Caja();
        }
    }
}
