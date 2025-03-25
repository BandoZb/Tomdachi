using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosClases
{
    internal class Program
    {

        

        static void Main(string[] args)

        {
            
            /*
            Console.WriteLine("Registra a tu personaje");

            Console.WriteLine("Inserta el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Inserta el apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Inserta la edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserta el seño ( h/m )");
            string sexo = Console.ReadLine();
            Console.WriteLine("Inserta la altura");
            int altura = int.Parse(Console.ReadLine());
            */

            // Datos prueba

            string nombre = "h";
            string apellido = "a";
            int edad = 1;
            string sexo = "s";
            int altura = 2;

            Humano personaje = new Humano(nombre, apellido, edad , sexo, altura);

            do
            {
                Console.WriteLine("Stats actuales Agua : {0} , Comida : {1} , Sueño : {2} , Fuerza : {3} , Cardio : {4}",personaje.GetAgua() , personaje.GetComida() , personaje.GetSueño() , personaje.GetFuerza() , personaje.GetCardio() );
                Console.WriteLine("");
                Console.WriteLine("Que quieres hacer");
                Console.WriteLine("");
                Console.WriteLine("1.Beber 2.Comer 3.Dormir 4.Entrenar 5.Correr");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        personaje.BeberAgua();
                        break;
                    case 2:
                        personaje.Comer();
                        break;
                    case 3:
                        personaje.Dormir();
                        break;
                    case 4:
                        personaje.EntrenarBanca();
                        break;
                    case 5:
                        personaje.Correr();
                        break;
                }

                personaje.Morir();
                personaje.FinalizarJuego();



            } while (personaje.GetVivo() == true && personaje.GetWin() == false);



            Console.Read();
        }
    }
}
