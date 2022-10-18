using SistemaGestion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.ADO
{
    public class ADO_ProductoVendido
    {
        public static List<ProductoVendido> TraerProductoVendido(int idUsuario)
        {
            return new List<ProductoVendido>();
            //hacer directamente una consulta a la bd producto vendido  join producto filtrando por Idusuario
            //como pide la consigna, llamar a traer productos que hicimos en la otra clase y recorrer esa lista y filtrar porductovendido por idprodcuto
        }
    }
}
