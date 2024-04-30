using MisVotos.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisVotos.BLL
{
    public interface ICrudLugar
    {
        string Add(LugarVotacion lugarVotacion);
        string Update(LugarVotacion lugarVotacion);
        string Delete(LugarVotacion lugarVotacion);
        List<LugarVotacion> GetAll();
    }
}
