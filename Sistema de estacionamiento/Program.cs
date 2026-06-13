namespace Sistema_de_estacionamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento EstacionamientoCentro = new Estacionamiento(4);
            Auto Auto1 = new Auto(Generadordepatentes.GenerarPatentesArgentinas(), "Renault","Twingo", 1);
            Auto Auto2 = new Auto(Generadordepatentes.GenerarPatentesArgentinas(), "toyota", "corola", 3);
            Moto Moto1 = new Moto(Generadordepatentes.GenerarPatentesArgentinas(), "Honda", "Wave", 2, 110);
            Moto Moto2 = new Moto(Generadordepatentes.GenerarPatentesArgentinas(), "Yamaha", "XTZ", 2, 350);
            EstacionamientoCentro.RegistrarEntrada(Auto2);
            EstacionamientoCentro.RegistrarEntrada(Moto2);
            EstacionamientoCentro.RegistrarEntrada(Moto1);
            EstacionamientoCentro.RegistrarEntrada(Auto1);
            EstacionamientoCentro.MostrarVehiculos();
            EstacionamientoCentro.RegistrarSalida(Auto1.Patente);
            EstacionamientoCentro.RegistrarSalida(Auto2.Patente);
            EstacionamientoCentro.RegistrarSalida(Moto1.Patente);
            EstacionamientoCentro.RegistrarSalida(Moto2.Patente);

        }
    }
}
