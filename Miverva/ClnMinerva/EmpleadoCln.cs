using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class EmpleadoCln
    {
        public static int insertar(Empleado empleado)
        {
            using (var contexto = new MinervaEntities())
            {
                contexto.Empleado.Add(empleado);
                contexto.SaveChanges();
                return empleado.id;
            }
        }

        public static int actualizar(Empleado empleado)
        {
            using (var contexto = new MinervaEntities())
            {
                var existente = contexto.Empleado.Find(empleado.id);
                existente.cedulaIdentidad = empleado.cedulaIdentidad;
                existente.nombre = empleado.nombre;
                existente.primerApellido = empleado.primerApellido;
                existente.segundoApellido = empleado.segundoApellido;
                existente.direccion = empleado.direccion;
                existente.celular = empleado.celular;
                existente.cargo = empleado.cargo;
                existente.fechaNacimiento = empleado.fechaNacimiento;
                existente.usuarioRegistro = empleado.usuarioRegistro;
                return contexto.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var contexto = new MinervaEntities())
            {
                var existente = contexto.Empleado.Find(id);
                existente.registroActivo = false;
                existente.usuarioRegistro = usuarioRegistro;
                return contexto.SaveChanges();
            }
        }

        public static Empleado get(int id)
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Empleado.Find(id);
            }
        }

        public static Empleado validar(string cedulaIdentidad)
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Empleado
                    .Where(x=> x.registroActivo.Value && x.cedulaIdentidad == cedulaIdentidad)
                    .FirstOrDefault();
            }
        }

        public static List<Empleado> listar()
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Empleado.Where(x => x.registroActivo.Value).ToList();
            }
        }

        /*public static List<paProductoListar_Result> listarPa(string parametro)
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.paProductoListar(parametro).ToList();
            }
        }*/
    }
}
