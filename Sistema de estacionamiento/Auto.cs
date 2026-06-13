using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_estacionamiento
{
    public class Auto: Vehiculo
    {
        public double PrecioPorHora = 10.0;

        public Auto(string patente, string marca, string modelo, int tiempoestacionamiento) : base(patente, marca, modelo, tiempoestacionamiento)
        {

        }
        public override double CalcularCostoEstacionamiento() => (TiempoEstacionamiento > 2) ? (TiempoEstacionamiento * PrecioPorHora) * 0.9 : TiempoEstacionamiento * PrecioPorHora;
    }
}
