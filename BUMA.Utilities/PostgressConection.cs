using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BUMA.Utilities.Connection
{
    public class PostgressConection
    {
        public string ConectarAdministracion { get; set; }

        public NpgsqlConnection ConnectionPostgressAdmin()
        {
            NpgsqlConnection ConnectPostgressAdmin = new NpgsqlConnection();
            ConectarAdministracion = "Server = localhost; User Id = postgres; password = @lej@ndr0; Database = BumaAdministracion";

            if (!string.IsNullOrWhiteSpace(ConectarAdministracion))
            {
                try
                {
                    ConnectPostgressAdmin = new NpgsqlConnection(ConectarAdministracion);
                    ConnectPostgressAdmin.Open();
                    ConnectPostgressAdmin.State.ToString();
                }
                catch (Exception ex)
                {
                    ConnectPostgressAdmin.Close();
                }
            }
            return ConnectPostgressAdmin;
        }




    }

}
