using MisVotos.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisVotos.BLL
{
    
    public class ServicioLugarVotacion : ICrud<LugarVotacion>
    {
        List<LugarVotacion> LugarVotacions;
        public ServicioLugarVotacion()
        {
                LugarVotacions= new List<LugarVotacion>();  
        }
        public string Add(LugarVotacion entidad)
        {
            // validar
            try
            {
                LugarVotacions.Add(entidad);
                return $"se agrego el votante {entidad.Descripcion}";
            }
            catch (Exception)
            {
                return "no se agrego el lugar de votacion";
            }
        }

        public string Delete(LugarVotacion entidad)
        {
            throw new NotImplementedException();
        }

        public List<LugarVotacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(LugarVotacion entidad)
        {
            throw new NotImplementedException();
        }
    }
}
