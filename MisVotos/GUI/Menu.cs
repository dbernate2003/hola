using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
namespace MisVotos.GUI
{
    public class Menu
    {
        public void MenuPrincipal()
        {
            VotanteGUI votanteGUI = new VotanteGUI();
            var voz = new SpeechSynthesizer();

            voz.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child);
            voz.Rate = -5;

            int op;
            do
            {
                voz.Speak("bienvenido al sistema de gestion de votantes, menu principal");
                Console.Clear();//
                Console.SetCursorPosition(20, 7); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(18, 9); Console.Write("1. Gestion Votantes");
                Console.SetCursorPosition(18, 11); Console.Write("2. Gestion Lugar Votacion");
                //Console.SetCursorPosition(18, 13); Console.Write("3. sa");

                Console.SetCursorPosition(18, 15); Console.Write("3. salir");
                voz.Speak("opcion 1. Gestion Votantes, opcion 2. Gestion Lugar Votacion ");
                voz.Speak("digite opcion");
                Console.SetCursorPosition(27, 15); Console.Write("digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        MenuVotante();
                        Console.ReadKey();
                        break;
                    case 2:
                        MenuLugarVotacion();
                        break;
                    
                }


            } while (op != 3);
        }
        public void MenuVotante()
        {
           VotanteGUI votanteGUI = new VotanteGUI();
            //var voz= new SpeechSynthesizer();
            
            //voz.Speak("bienvenido al sistema de gestion de votantes");
            
            int op;
            do
            {
                Console.Clear();//
                Console.SetCursorPosition(20, 7); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(18, 9); Console.Write("1. Agregar Votante");
                Console.SetCursorPosition(18, 11); Console.Write("2. Consulta General");
                Console.SetCursorPosition(18, 13); Console.Write("3. Actulizar Votante ");

                Console.SetCursorPosition(18, 15); Console.Write("4. salir");

                Console.SetCursorPosition(27, 15); Console.Write("digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        votanteGUI.ViewAdd();
                        Console.ReadKey();
                        break;
                    case 2:
                        votanteGUI.GetAll();
                        break;
                    case 3:
                        votanteGUI.ViewUpdate();
                        Console.Clear();

                        break;
                }


            } while (op != 4);
        }
        public void MenuLugarVotacion()
        {
            VotanteGUI votanteGUI = new VotanteGUI();
            //var voz = new SpeechSynthesizer();

            //voz.Speak("bienvenido al sistema de gestion de votantes");

            int op;
            do
            {
                Console.Clear();//
                Console.SetCursorPosition(20, 7); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(18, 9); Console.Write("1. Agregar Lugar de votacion");
                Console.SetCursorPosition(18, 11); Console.Write("2. Consulta General Lugar de votacion");
                Console.SetCursorPosition(18, 13); Console.Write("3. Actulizar Lugar de votacion ");
                Console.SetCursorPosition(18, 15); Console.Write("4. Eliminar Lugar de votacion ");
                Console.SetCursorPosition(18, 17); Console.Write("5. salir");

                Console.SetCursorPosition(27, 17); Console.Write("digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        //votanteGUI.ViewAdd();
                        Console.ReadKey();
                        break;
                    case 2:
                        //votanteGUI.GetAll();
                        break;
                    case 3:
                        //votanteGUI.ViewUpdate();
                        Console.Clear();

                        break;
                }


            } while (op != 5);
        }
    }
}
