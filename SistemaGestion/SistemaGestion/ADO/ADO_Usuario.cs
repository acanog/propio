using SistemaGestion.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.ADO
{
    public class ADO_Usuario
    {
        public static Usuario TraerUsuario(string nombreUsuario)
        {
            SqlConnectionStringBuilder conecctionbuilder = new SqlConnectionStringBuilder();
            conecctionbuilder.DataSource = "DESKTOP-RRAI8UU";
            conecctionbuilder.InitialCatalog = "dbSistemaGestionCoder";
            conecctionbuilder.IntegratedSecurity = true;
            var cs = conecctionbuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                //  Punto 1
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select * from Usuario where nombreUsuario = @nombreUsuario";
                cmd.Parameters.Add(new SqlParameter("nombreUsuario", nombreUsuario));


                var param = new SqlParameter("@nombreUsuario", SqlDbType.VarChar);
                param.Value = nombreUsuario;

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var User = new Usuario();

                    User.Id = Convert.ToInt32(reader.GetValue(0));
                    User.Nombre = reader.GetValue(1).ToString();
                    User.Apellido = reader.GetValue(2).ToString();
                    User.NombreUsuario = reader.GetValue(3).ToString();
                    User.Contraseña = reader.GetValue(4).ToString();
                    User.Mail = reader.GetValue(5).ToString();
                    //Console.WriteLine("---- INFORMACION USUARIO ----- ");
                    //Console.WriteLine("id = " + User.Id);
                    //Console.WriteLine("Nombre = " + User.Nombre);
                    //Console.WriteLine("Costo = " + User.Apellido);
                    //Console.WriteLine("PrecioVenta = " + User.NombreUsuario);
                    //Console.WriteLine("Stock = " + User.Contraseña);
                    //Console.WriteLine("IdUsuario = " + User.Mail);
                    //Console.WriteLine("--------------");
                }
                reader.Close();
                connection.Close();
                return new Usuario();
            }


        }
        public static Usuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            SqlConnectionStringBuilder conecctionbuilder = new SqlConnectionStringBuilder();
            conecctionbuilder.DataSource = "DESKTOP-RRAI8UU";
            conecctionbuilder.InitialCatalog = "dbSistemaGestionCoder";
            conecctionbuilder.IntegratedSecurity = true;
            var cs = conecctionbuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                //  Punto 6
                SqlCommand cmd5 = connection.CreateCommand();
                cmd5.CommandText = "select * from Usuario where NombreUsuario=@nombreUsuario and Contraseña=@Contraseña";
                cmd5.Parameters.Add(new SqlParameter("nombreUsuario", nombreUsuario));
                cmd5.Parameters.Add(new SqlParameter("Contraseña", contraseña));

                var param5 = new SqlParameter("@nombreUsuario", SqlDbType.VarChar);
                param5.Value = nombreUsuario;
                var param6 = new SqlParameter("@Contraseña", SqlDbType.VarChar);
                param6.Value = contraseña;

                var reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    var User = new Usuario();
                    User.NombreUsuario = reader5.GetValue(3).ToString();

                }
                reader5.Close();
                connection.Close();
                return new Usuario();

            }



        }

    }

}