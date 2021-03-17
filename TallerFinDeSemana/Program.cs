using System;

namespace TallerFinDeSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int Opcion;
            string opciones;
            do
            {

                bool DatoCorrecto = false;

                Console.Clear();                   
                gui.Marco(1, 110, 1, 25);
                Console.SetCursorPosition(10, 10); Console.WriteLine("1. quienes somos ");
                Console.SetCursorPosition(10, 11); Console.WriteLine("2. Menu de aplicacion ");
                Console.SetCursorPosition(10, 12); Console.WriteLine("0. Salir ");

                do
                {

                    Console.SetCursorPosition(10, 13); Console.WriteLine("Seleccione una opcion");
                    Console.SetCursorPosition(10, 14); opciones = Console.ReadLine();
                    
                    if (!Verificaciones.Vacio(opciones))                           
                        if (Verificaciones.TipoNumero(opciones))
                            DatoCorrecto = true;

                    
                } while (!DatoCorrecto);

                
                Opcion = Convert.ToInt32(opciones);
                switch (Opcion)
                {

                    case 1:
                        Console.WriteLine(" nombres ");
                        break;
                    case 2:
                        menu.MenuSecundario();
                        break;
                    case 0:
                        Console.SetCursorPosition(40, 20); Console.WriteLine("Feliz dia...");
                        break;
                    default:
                        Console.WriteLine("respuesta incorrecta");
                        break;

                }

                Console.SetCursorPosition(40, 21); Console.WriteLine("presione una tecla para continuar");
                Console.SetCursorPosition(40, 22); Console.ReadKey();

            } while (Opcion > 0);

            
        }
    }
}
