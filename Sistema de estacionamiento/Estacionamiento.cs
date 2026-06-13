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
        public void RegistrarSalida(string PatenteABuscar)
        {
            bool encontrar = false;
            Vehiculo vehiculoencontrado = null;
            for (int i = 0 ; i < vehiculosestacionados.Count ; i++)
            {
                if (vehiculosestacionados[i].Patente == PatenteABuscar)
                {
                    encontrar = true;
                    vehiculoencontrado = vehiculosestacionados[i];
                    break;
                }
            }
            if(encontrar)
            {
                double precioacobrar = vehiculoencontrado.CalcularCostoEstacionamiento();
                Console.WriteLine($"Vehiculo con patente {vehiculoencontrado.Patente} se retira del resinto");
                Console.WriteLine($"Total a cobrar = ${precioacobrar}");
                vehiculosestacionados.Remove(vehiculoencontrado);
            }
            else
            {
                Console.WriteLine("Vehiculo no encontrado");
            }
        }

        public void MostrarVehiculos()
        {
            for(int i = 0 ; i < vehiculosestacionados.Count ; i++ )
            {
                Console.WriteLine($"Marca: {vehiculosestacionados[i].Marca}, Modelo: {vehiculosestacionados[i].Modelo}, Patente: {vehiculosestacionados[i].Patente}");
            }
        }

    }
}
