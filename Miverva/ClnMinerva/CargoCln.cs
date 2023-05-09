using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class CargoCln
    {
        public static List<Cargo> listar()
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Cargo.ToList();
            }
        }
    }
}
