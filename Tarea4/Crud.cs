using System;
using System.Collections.Generic;
using System.Linq;
namespace Tarea4{

    public class Crud{
        Principal oPrincipal;
        public string Add(){
            using(var post = new PostDbContext()){
                var oInfraccion =  new Infraccion();
                Console.Clear();
                Console.WriteLine("Registro de Infraccion");
                oInfraccion.Nombre = Program.input("Nombre: ");
                oInfraccion.Apellido = Program.input("Apellido: ");
                oInfraccion.Cedula = Program.input("Cedula: ");
                oInfraccion.Placa = Program.input("Placa: ");
                oInfraccion.Marca = Program.input("Marca: ");
                oInfraccion.Latitud = Program.input("Latitud: ");
                oInfraccion.Longitud = Program.input("Longitud: ");
                oInfraccion.Descripcion = Program.input("Descripcion: ");
                post.Add(oInfraccion);
                post.SaveChanges();
                return "Registro Exitoso!...";
            }
        }

        public void Get(){
            using(var post = new PostDbContext()){
                var lstIfracciones = post.Infracciones;
                Program.print("*----------------------*");
                Program.print("Listado de Infracciones");
                Program.print("*----------------------*");
                foreach(var infraccion in lstIfracciones){
                    Program.print("  ID: " + infraccion.Id);
                    Program.print("  Nombre: " + infraccion.Nombre);
                    Program.print("  Apellido: " + infraccion.Apellido);
                    Program.print("  Placa: " + infraccion.Placa);
                    Program.print("  Marca: " + infraccion.Marca);
                    Program.print("  Latitud: " + infraccion.Latitud);
                    Program.print("  Longitud: " + infraccion.Longitud);
                    Program.print("  Descripcion: " + infraccion.Descripcion);
                    Program.print("  pago: " + infraccion.pago);
                    Program.print("|*----------------------*|");
                }
            }
        }

        public void Pago(){
            int id = 0;
            lstInfraccion(true);
            id = Program.inputNumber("ID: ");
            using(var post = new PostDbContext()){
               oPrincipal = new Principal();
                try{
                    var oInterracion = post.Infracciones.Find(id);
                    oInterracion.pago = true;
                    post.SaveChanges();
                    Program.print("Pago Exitoso!...");
                    Program.wait();
                    Console.Clear();
                    oPrincipal.menu();    
                }catch(Exception ex){
                    Program.print("No Encotrado!");
                    Program.wait();
                    Console.Clear();
                    oPrincipal.menu();
                }
            }
        }

        public void exportar(){
            lstInfraccion(false);
            using(var post = new PostDbContext()){
               oPrincipal = new Principal();
               var id = Program.inputNumber("ID: ");
                try{    
                    var oInterracion = post.Infracciones.Find(id);
                    Program.print("Proximamente Funcionando!...");
                }catch(Exception ex){
                    Program.print("No Encotrado!");
                }
            }
        }

        public void lstInfraccion(bool estado){
            using(var post = new PostDbContext()){
                IQueryable<Infraccion> list = null;
                if(estado){
                    list = from i in post.Infracciones
                            where i.pago == false
                            select i;
                }else{
                    list = from i in post.Infracciones
                            select i;
                }
                Program.print("*----------------------*");
                Program.print("Listado de Infracciones");
                Program.print("*----------------------*");
                foreach(var infraccion in list){
                    Program.print("  ID: " + infraccion.Id);
                    Program.print("  Nombre: " + infraccion.Nombre.Trim() + " " + infraccion.Apellido.Trim());
                    Program.print("|*----------------------*|");
                }
            }
        }
    }
}