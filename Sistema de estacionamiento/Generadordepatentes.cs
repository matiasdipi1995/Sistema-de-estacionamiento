using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_estacionamiento
{
    internal class Generadordepatentes
    {
        //los Hashset son lista que no permiten valores repetidos
        private static HashSet<string> PatentesExistente = new HashSet<string>();
        private static Random aleatorio = new Random();

        public static string GenerarPatentesArgentinas()
        {
            string nuevapatente = "";
            bool Unica = false;

            while(!Unica)
            {
                //.next impone los limites de como se creara el numero rando, al usar una letra en realidad estamos usando un numero, por ejemplo a tiene el valor numerico de 65, y z tiene el valor numerico de 91. usamos al final +1 para que el limitador comtemple a z
                char letra1 = (char)aleatorio.Next('A', 'Z' +1);
                //char lo que hace es tranformar los numero que nos devuelve .next en letras, por eso usamos las letras como parametros para que transforme siempre una letra del abcedario
                char letra2 = (char)aleatorio.Next('A', 'Z'+1);
                //si quieres saber el valor de las letras busca la tabla "tabla ASCII"
                int numeros = aleatorio.Next(100, 1000);
                char letra3 = (char)aleatorio.Next('A', 'Z' +1);
                //ojo al detalle las patentes usan mayusculas y la "a" minuscula y la "A" mayuscula tienen valor diferentes numericamente
                char letra4 = (char)aleatorio.Next('A', 'Z' +1);
                nuevapatente = $"{letra1}{letra2}{numeros}{letra3}{letra4}";

                if(PatentesExistente.Add(nuevapatente))
                {
                    Unica = true;
                }
            }
            return nuevapatente;
        }
    }
}
