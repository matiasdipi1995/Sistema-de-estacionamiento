using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_estacionamiento
{
    public class Moto: Vehiculo
    {
        public string Cilindrada { get; set; }
        public double PrecioPorHora = 5.0;

        public Moto (string patente, string marca, string modelo, int tiempoestacionamiento, string cilindrada) : base(patente,marca,modelo,tiempoestacionamiento)
        {
            Cilindrada = cilindrada;
        }

        public override double CalcularCostoEstacionamiento()
        {
            return (TiempoEstacionamiento/60.0) * PrecioPorHora;
        }
    }
}
