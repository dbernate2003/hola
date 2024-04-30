using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisVotos.ENTITY
{
    public class Votante : Persona
    {
        public Votante() : base() //invoca al constructor de la clase base(Persona) sin argumentos adicionales
        {
                
        }
        public LugarVotacion LugarVotacion { get; set; }
    }
}
