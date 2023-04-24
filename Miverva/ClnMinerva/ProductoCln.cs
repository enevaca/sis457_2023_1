using CadMiverva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class ProductoCln
    {
        public static int insertar(Producto producto) // INSERT INTO Producto VALUES (..., ...)
        {
            using (var contexto = new MinervaEntities())
            {
                contexto.Producto.Add(producto);
                contexto.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Producto producto) // UPDATE Producto SET campo=valor,... WHERE id = id
        {
            using (var contexto = new MinervaEntities())
            {
                var existente = contexto.Producto.Find(producto.id);
                existente.codigo = producto.codigo;
                existente.descripcion = producto.descripcion;
                existente.unidadMedida = producto.unidadMedida;
                existente.saldo = producto.saldo;
                existente.precioVenta = producto.precioVenta;
                existente.usuarioRegistro = producto.usuarioRegistro;
                return contexto.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro) // UPDATE Producto SET registroActivo=false, usuarioRegistro=valor WHERE id=id
        {
            using (var contexto = new MinervaEntities())
            {
                var existente = contexto.Producto.Find(id);
                existente.registroActivo = false;
                existente.usuarioRegistro = usuarioRegistro;
                return contexto.SaveChanges();
            }
        }

        public static Producto get(int id) // SELECT * FROM Producto WHERE id = id
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Producto.Find(id);
            }
        }

        public static List<Producto> listar() // SELECT * FROM Producto WHERE registroActivo=true
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Producto.Where(x => x.registroActivo.Value).ToList();
            }
        }

        public static List<paProductoListar_Result> listarPa(string parametro) // EXEC paProductoListar 'valor'
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.paProductoListar(parametro).ToList();
            }
        }
    }
}
