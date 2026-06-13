using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_estacionamiento
{
    public class Estacionamiento
    {
        private List<Vehiculo> vehiculosestacionados;
        public int CapacidadMaximaAutos { get; set; }

        public Estacionamiento(int capacidadmaximaauto)
        {
            CapacidadMaximaAutos = capacidadmaximaauto;
            vehiculosestacionados = new List<Vehiculo>();
        }
        public void RegistrarEntrada(Vehiculo v)
        {
            if(vehiculosestacionados.Count < CapacidadMaximaAutos)
            {
                vehiculosestacionados.Add(v);
                Console.WriteLine($"Vehiculo {v.Marca} con patente {v.Patente} Ingreso con exito loco");
            }
            else
            {
                Console.WriteLine("Estacionamiento lleno, no se puede ingresar");
            }
        }
    }
}
