using SistemaGestion.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.ADO
{
    public class ADO_Venta
    {
        public static List<Venta> TraerVentas(int IdUsuario)
        {
            SqlConnectionStringBuilder conecctionbuilder = new SqlConnectionStringBuilder();
            conecctionbuilder.DataSource = "DESKTOP-RRAI8UU";
            conecctionbuilder.InitialCatalog = "dbSistemaGestionCoder";
            conecctionbuilder.IntegratedSecurity = true;
            var cs = conecctionbuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();


                //  Punto 4
                SqlCommand cmd4 = connection.CreateCommand();
                cmd4.CommandText = "select * from Venta where IdUsuario = @idUsuarioV";
                cmd4.Parameters.Add(new SqlParameter("idUsuarioV", idUsuarioV));


                var param4 = new SqlParameter("@idUsuarioV", SqlDbType.Int);
                param4.Value = idUsuarioV;

                var reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    var ventas = new Venta();

                    ventas.Id = Convert.ToInt32(reader4.GetValue(0));
                    ventas.Comentarios = reader4.GetValue(1).ToString();
                    ventas.IdUsuario = Convert.ToInt32(reader4.GetValue(2));

                    listaVentas.Add(ventas);

                }
                Console.WriteLine("---- VENTAS ----- ");
                foreach (var ventas in listaVentas)
                {
                    Console.WriteLine("id = " + ventas.Id);
                    Console.WriteLine("Comentarios = " + ventas.Comentarios);
                    Console.WriteLine("IdUsuario = " + ventas.IdUsuario);

                    Console.WriteLine("--------------");

                }
                reader4.Close();
                return new List<Venta>();

                connection.Close();
            }
    }
}
