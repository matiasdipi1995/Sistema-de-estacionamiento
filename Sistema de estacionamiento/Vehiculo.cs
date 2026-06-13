using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_estacionamiento
{
    public abstract class Vehiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Patente { get; private set; }
        public int TiempoEstacionamiento { get; set; }

        //lo que declaramos siguiente es el contructo de la clase, es para hacer mas sencillo la creacion de los objetos con la clase, usando el constructo podemos crear objetos asi "Auto miAuto = new Auto("AA123BB", "Fiat", "Cronos", 60);" sin el constructo tendriamos que agregar uno por uno los elemento en el objeto asi "Auto miAuto = new Auto();
            //miAuto.Patente = "AA123BB";
            //miAuto.Marca = "Fiat";
            //miAuto.Modelo = "Cronos";
            //miAuto.TiempoEstacionamiento = 60;"
        public Vehiculo(string patente, string marca, string modelo, int tiempoestacionamiento)
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            TiempoEstacionamiento = tiempoestacionamiento;
        }
        public abstract double CalcularCostoEstacionamiento();


    }
}
