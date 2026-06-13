using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_estacionamiento
{
    public class Moto: Vehiculo
    {
        public int Cilindrada { get; set; }
        public double PrecioPorHora = 5.0;

        public Moto (string patente, string marca, string modelo, int tiempoestacionamiento, int cilindrada) : base(patente,marca,modelo,tiempoestacionamiento)
        {
            Cilindrada = cilindrada;
        }

        public override double CalcularCostoEstacionamiento()
        {
            if(Cilindrada>= 250)
            {
                return (TiempoEstacionamiento * PrecioPorHora) + 20;
            }
            return TiempoEstacionamiento * PrecioPorHora;
        }
    }
}
