using SistemaGestion.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace SistemaGestion.ADO
{
    public class ADO_Producto
    {
        public static List<Producto> TraerProducto(int idUsuarioProducto)
        {
            var listaProductos = new List<Producto>();


            SqlConnectionStringBuilder conecctionbuilder = new SqlConnectionStringBuilder();
            conecctionbuilder.DataSource = "DESKTOP-RRAI8UU";
            conecctionbuilder.InitialCatalog = "dbSistemaGestionCoder";
            conecctionbuilder.IntegratedSecurity = true;
            var cs = conecctionbuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                //  Punto 2
                SqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = "select * from Producto where idUsuario = @idUsuarioProducto";
                cmd2.Parameters.Add(new SqlParameter("@idUsuarioProducto", idUsuarioProducto));


                var param2 = new SqlParameter("@idUsuarioProducto", SqlDbType.Int);
                param2.Value = idUsuarioProducto;

                var reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    var produc = new Producto();

                    produc.Id = Convert.ToInt32(reader2.GetValue(0));
                    produc.Descripcion = reader2.GetValue(1).ToString();
                    produc.Costo = Convert.ToDouble(reader2.GetValue(2));
                    produc.PrecioVenta = Convert.ToDouble(reader2.GetValue(3));
                    produc.Stock = Convert.ToInt32(reader2.GetValue(4));
                    produc.IdUsuario = Convert.ToInt32(reader2.GetValue(5));

                    listaProductos.Add(produc);

                }
                //Console.WriteLine("---- PRODUCTOS ----- ");
                //foreach (var produc in listaProductos)
                //{
                //    Console.WriteLine("id = " + produc.Id);
                //    Console.WriteLine("Descripciones = " + produc.Descripcion);
                //    Console.WriteLine("Costo = " + produc.Costo);
                //    Console.WriteLine("PrecioVenta = " + produc.PrecioVenta);
                //    Console.WriteLine("Stock = " + produc.Stock);
                //    Console.WriteLine("IdUsuario = " + produc.IdUsuario);
                //
                //    Console.WriteLine("--------------");
                //
                //}
                reader2.Close();
                connection.Close();


                return new List<Producto>();

            }


        }

        public static List<Producto> TraerProductoVendido(int idUsuarioProducto)
        {

            var listaProductosVendidos = new List<Producto>();

            SqlConnectionStringBuilder conecctionbuilder = new SqlConnectionStringBuilder();
            conecctionbuilder.DataSource = "DESKTOP-RRAI8UU";
            conecctionbuilder.InitialCatalog = "dbSistemaGestionCoder";
            conecctionbuilder.IntegratedSecurity = true;
            var cs = conecctionbuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                //  Punto 3
                SqlCommand cmd3 = connection.CreateCommand();
                cmd3.CommandText = "select p.Id,Descripciones,Costo,PrecioVenta,p.Stock,IdUsuario from Producto as p inner join ProductoVendido as pv on pv.IdProducto = p.Id where idUsuario = @idUsuarioProducto";
                cmd3.Parameters.Add(new SqlParameter("idUsuarioProducto", idUsuarioProducto));


                var param3 = new SqlParameter("@idUsuarioPV", SqlDbType.Int);
                param3.Value = idUsuarioProducto;

                var reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    var producVend = new Producto();

                    producVend.Id = Convert.ToInt32(reader3.GetValue(0));
                    producVend.Descripcion = reader3.GetValue(1).ToString();
                    producVend.Costo = Convert.ToDouble(reader3.GetValue(2));
                    producVend.PrecioVenta = Convert.ToDouble(reader3.GetValue(3));
                    producVend.Stock = Convert.ToInt32(reader3.GetValue(4));
                    producVend.IdUsuario = Convert.ToInt32(reader3.GetValue(5));

                    listaProductosVendidos.Add(producVend);

                }
                Console.WriteLine("---- PRODUCTOS VENDIDOS ----- ");
                foreach (var producVend in listaProductosVendidos)
                {
                    Console.WriteLine("id = " + producVend.Id);
                    Console.WriteLine("Descripciones = " + producVend.Descripcion);
                    Console.WriteLine("Costo = " + producVend.Costo);
                    Console.WriteLine("PrecioVenta = " + producVend.PrecioVenta);
                    Console.WriteLine("Stock = " + producVend.Stock);
                    Console.WriteLine("IdUsuario = " + producVend.IdUsuario);

                    Console.WriteLine("--------------");

                }
                reader3.Close();
                connection.Close();

                return new List<Producto>();




            }


        }



    }


}
