using System;
using System.Collections.Generic;

namespace newlab4franco
{
    class MainClass
    {

        class Computador
        {
            public void Prendermaquina(Maquina maquina)
            {
                maquina.Encendido();
            }
            public void Reiniciarmaquina(Maquina maquina)
            {
                maquina.Reinicio();

            }
            public void Apagarmaquina(Maquina maquina)
            {

                maquina.Apagado();
            }



        }
        public abstract class Maquina
        {
            List<string> Memoria = new List<string>();
            public abstract void Encendido();
            public abstract void Reinicio();
            public abstract void Apagado();

            

        }


        public class Recepcion : Maquina
        {
            public override void Encendido()
            {
                Console.WriteLine("La maquina recepcion se esta encendiendo");
            }
            public override void Reinicio()
            {
                Console.WriteLine("La maquina recepcion se esta reiniciando");
            }
            public override void Apagado()
            {
                Console.WriteLine("La maquina recepcion se esta apagando");
            }









        }
        public class Almacenamiento : Maquina
        {
            public override void Encendido()
            {
                Console.WriteLine("La maquina almacenamiento se esta encendiendo");
            }
            public override void Reinicio()
            {
                Console.WriteLine("La maquina almacenamiento se esta reiniciando");
            }
            public override void Apagado()
            {
                Console.WriteLine("La maquina almacenamiento se esta apagando");
            }




        }
        public class Ensamblaje : Maquina
        {

            public override void Encendido()
            {
                Console.WriteLine("La maquina ensamblaje se esta encendiendo");
            }
            public override void Reinicio()
            {
                Console.WriteLine("La maquina ensamblaje se esta reiniciando");
            }
            public override void Apagado()
            {
                Console.WriteLine("La maquina ensamblaje se esta apagando");
            }




        }
        public class Verifica : Maquina
        {

            public override void Encendido()
            {
                Console.WriteLine("La maquina verifica se esta encendiendo");
            }
            public override void Reinicio()
            {
                Console.WriteLine("La maquina verifica se esta reiniciando");
            }
            public override void Apagado()
            {
                Console.WriteLine("La maquina verifica se esta apagando");
            }



        }
        public class Empaque : Maquina
        {
            public override void Encendido()
            {
                Console.WriteLine("La maquina empaque se esta encendiendo");
            }
            public override void Reinicio()
            {
                Console.WriteLine("La maquina empaque se esta reiniciando");
            }
            public override void Apagado()
            {
                Console.WriteLine("La maquina empaque se esta apagando");
            }



        }





        public static void Main(string[] args)
        {
            Maquina mrecepcion = new Recepcion();
            Maquina malmacenamiento = new Almacenamiento();
            Maquina mensamblaje = new Ensamblaje();
            Maquina mverifica = new Verifica();
            Maquina mempaque = new Empaque();
            Computador computador = new Computador();

            mrecepcion.Encendido();
            malmacenamiento.Encendido();
            mensamblaje.Encendido();
            mverifica.Encendido();
            mempaque.Encendido();

            mrecepcion.Apagado();
            malmacenamiento.Apagado();
            mensamblaje.Apagado();
            mverifica.Apagado();
            mempaque.Apagado();





        }
    }
}
