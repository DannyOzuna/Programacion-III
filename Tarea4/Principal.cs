using System;

namespace Tarea4{
    class Principal{
        Crud oCrud = new Crud();
        public void iniciar(){
            Console.WriteLine("Bienvinidos al Sistema de Violaciones de Transito.");
            Program.wait();
            menu();
        }

        public void menu(){
            Console.Clear();
            Console.WriteLine("Menu Pricipal");
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Listar");
            Console.WriteLine("3. Pagar");
            Console.WriteLine("4. Exportar Caso");
            Console.WriteLine("5. Salir");
            var opcion = Program.input("Opcion: ");
            switch(opcion){
                case "1":
                    Console.WriteLine(oCrud.Add());
                    Program.wait();
                    menu();
                break;
                case "2":
                    Console.Clear();
                    oCrud.Get();
                    Program.wait();
                    menu();
                break;
                case "3":
                    Console.Clear();
                    oCrud.Pago();
                break;
                case "4":
                    Console.Clear();
                    oCrud.exportar();
                    Program.wait();
                    menu();
                break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Adios :(");
                    Environment.Exit(0);
                break;

                default:
                    Console.WriteLine("Dato Incorrecto!...");
                    Program.wait();
                    menu();
                break;

            }
        }
    }
}