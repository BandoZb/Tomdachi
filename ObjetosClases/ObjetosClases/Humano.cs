using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosClases
{
    internal class Humano
    {

        private string nombre;
        private string apellido;
        private int edad;
        private string sexo;
        private int altura;

        private int agua;
        private int comida;
        private int sueño;
        private int fuerza;
        private int cardio;

        bool vivo;
        bool win;

        public Humano(string nombre, string apellido, int edad, string sexo, int altura)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.sexo = sexo;
            this.altura = altura;

            agua = 100;
            comida = 100;
            sueño = 100;
            fuerza = 0;
            cardio = 0;

            vivo = true;
            win = false;

        }


        public void BeberAgua()
        {
            if (agua > 95)
            {
                Console.WriteLine("Estas muy hidratado");
            }
            else
            {
                Console.WriteLine("Has bebido agua, puntos de agua = {0}",agua);
                agua += 25;
                sueño -= 5;
                comida -= 5;
            }

        }

        public void Comer()
        {
            if (comida > 95)
            {
                Console.WriteLine("Estas muy lleno");
            }
            else
            {
                Console.WriteLine("Has comido, puntos de comida = {0}", comida);
                comida += 30;
                sueño -= 15;
                agua -= 5;
            }

        }

        public void Dormir()
        {
            if (sueño > 85)
            {
                Console.WriteLine("No tienes nada de sueño");
            }
            else
            {
                Console.WriteLine("Has dormido, puntos de sueño = {0}", sueño);
                agua -= 15;
                sueño += 60;
                comida -= 10;
            }

        }

        public void EntrenarBanca()
        {
            
                agua -= 20;
                sueño -= 20;
                comida -= 20;
                fuerza += 10;

            Console.WriteLine("Has entrenado fuerte, levantas = {0} en banca", fuerza);


        }

        public void Correr()
        {
            if (cardio >= 100)
            {
                Console.WriteLine("Estas ready para una maraton");
            }
            else
            {
                Console.WriteLine("Has hecho un gran recorrido, puntos de cardio = {0}", cardio);
                agua -= 20;
                sueño -= 20;
                comida -= 20;
                fuerza -= 5;
                cardio += 15;
            }

        }

        

        public void Morir()
        {
            if (agua <= 0 || comida <= 0 || sueño <= 0)
            {
                vivo = false;

                Console.WriteLine("Has muerto... Aprende a cuidarlo mejor");
            }
        }

        public void FinalizarJuego()
        {
            if (fuerza >= 100)
            {
                win = true;
                Console.WriteLine("¡Felicidades! Levantas 100 en banca por fin.");
            }
            else if (cardio >= 100)
            {
                win = true;
                Console.WriteLine("¡Felicidades! Conseguiste el cardio que querías.");
            }
        }





        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public int GetEdad()
        {
            return edad;
        }

        public string GetSexo()
        {
            return sexo;
        }

        public int GetAltura()
        {
            return altura;
        }

        public int GetAgua()
        {
            return agua;
        }

        public int GetComida()
        {
            return comida;
        }

        public int GetSueño()
        {
            return sueño;
        }

        public int GetFuerza()
        {
            return fuerza;
        }
        public int GetCardio()
        {
            return cardio;
        }

        public bool GetVivo()
        {
            return vivo;
        }
        public bool GetWin()
        {
            return win;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void SetEdad (int edad)
        {
            this.edad = edad;
        }

        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public void SetAltura(int altura)
        {
            this.altura = altura;
        }

        public void SetAgua(int agua)
        {
            this.agua = agua;
        }

        public void SetComida(int comida)
        {
            this.comida = comida;
        }

        public void SetSueño(int sueño)
        {
            this.sueño = sueño;
        }
        public void SetFuerza(int fuerza)
        {
            this.fuerza = fuerza;
        }
        public void SetCardio(int cardio)
        {
            this.cardio = cardio;
        }
        public void SetVivo(bool vivo)
        {
            this.vivo = vivo;
        }
        public void SetWin(bool win)
        {
            this.win = win;
        }
    }
}
