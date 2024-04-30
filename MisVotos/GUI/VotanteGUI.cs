using MisVotos.BLL;
using MisVotos.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisVotos.GUI
{
    public class VotanteGUI
    {
        private ServicioVotante servicioVotante = new ServicioVotante();

        public void ViewAdd()
        {
            Votante votante = new Votante();

            Console.Write("Cedula: ");
            votante.Cedula = Console.ReadLine();
            Console.Write("Nombres: ");
            votante.Nombre = Console.ReadLine();
            Console.Write("Telefono: ");
            votante.Telefono = Console.ReadLine();
            Console.Write("Sexo: ");
            votante.Sexo = Console.ReadLine();
            Console.Write("Edad: ");
            votante.Edad = Convert.ToInt16(Console.ReadLine());

            var mensaje = servicioVotante.Add(votante);

            Console.WriteLine(mensaje);
        }
        public void GetWoman()
        {
            Visualizer(servicioVotante.GetBySex("F"));
        }
        public void GetAll()
        {
            Visualizer(servicioVotante.GetAll());
        }
        private void Visualizer(List<Votante> lista)
        {
            Console.Clear();
            Console.SetCursorPosition(5, 7); Console.Write("cedula");
            Console.SetCursorPosition(15, 7); Console.Write("Nombres");
            Console.SetCursorPosition(28, 7); Console.Write("Telefono");
            Console.SetCursorPosition(38, 7); Console.Write("Sexo");
            Console.SetCursorPosition(45, 7); Console.Write("Edad");
            Console.SetCursorPosition(5, 8); Console.Write("--------------------------------------------");

            int i = 0;
            foreach (var item in lista)
            {
                Console.SetCursorPosition(5, 9 + i); Console.Write(item.Cedula);
                Console.SetCursorPosition(15, 9 + i); Console.Write(item.Nombre);
                Console.SetCursorPosition(28, 9 + i); Console.Write(item.Telefono);
                Console.SetCursorPosition(38, 9 + i); Console.Write(item.Sexo);
                Console.SetCursorPosition(45, 9 + i); Console.Write(item.Edad);
                //Console.SetCursorPosition(5, 10+i); Console.Write("--------------------------------------------");
                i++;
            }


            Console.ReadKey();
        }

        public void ViewUpdate()
        {

            string cedula;
            Console.Clear();
            Console.SetCursorPosition(3, 5); Console.Write("Cedula: ");
            Console.SetCursorPosition(11, 5); cedula = Console.ReadLine();
            var votante = servicioVotante.GetByCedula(cedula);
            if (votante != null)
            {
                Console.SetCursorPosition(3, 7); Console.Write($"Nombres: {votante.Nombre}");
                //votante.Nombre = Console.ReadLine();
                Console.SetCursorPosition(3, 9); Console.Write($"Telefono: {votante.Telefono}");
                //votante.Telefono = Console.ReadLine();
                Console.SetCursorPosition(3, 11); Console.Write($"Sexo: {votante.Sexo}");
                //votante.Sexo = Console.ReadLine();
                Console.SetCursorPosition(3, 13); Console.Write($"Edad: {votante.Edad}");
                //votante.Edad = Convert.ToInt16(Console.ReadLine());

                Console.SetCursorPosition(12, 7); votante.Nombre = Console.ReadLine();
                Console.SetCursorPosition(13, 9); votante.Telefono = Console.ReadLine();
                Console.SetCursorPosition(9, 11); votante.Sexo = Console.ReadLine();
                Console.SetCursorPosition(9, 13); votante.Edad = int.Parse(Console.ReadLine());

                var mensaje = servicioVotante.Update(votante);

                Console.WriteLine(mensaje);
            }

        }
    }
}
