using System;
using System.IO;

namespace Tarea4{
    public class Reporte{
        public string factura(int Id, string Nombre, string Apellido, string Placa, string Marca, string Latitud, string Longitud, string Descripcion, bool pago){

            string ruta = "C:\\ArchivoHTML";
            if(Directory.Exists(ruta) == false){
                Directory.CreateDirectory(ruta);
            }
            string css= "@import url('https://fonts.googleapis.com/css2?family=Lato&display=swap');"+
                "@import url('https://fonts.googleapis.com/css2?family=Montserrat&display=swap');"+
            "body {"+
            "background: #292F36;"+
            "font-family: 'Lato', sans-serif;"+
            "}"+

            ".portfolio {"+
            "display: flex;"+
            "width: 100%;"+
            "height: 70%;"+
            "justify-content: center;"+
            "}"+
            ".first-element {"+
            "width: 40%;"+
            "padding-right: 10%;"+
            "}"+
            ".right {font-size:25px; color:black;}"+
            ".left {"+
            "margin-left: 5%;"+
            "}"+

            ".second-element {"+
            "width: 90%;"+
            "display: flex;"+
            "flex-direction: column;"+
            "}"+

            ".myInfo {"+
            "display: flex;"+
            "flex-direction: row;"+
            "margin-left: 1%;"+
            "}"+

            ".flex-container {"+
            "display: flex;"+
            "flex-direction: row;"+
            "height: 300px;"+
            "width: 700px;"+
            "padding: 2% 2% 2% 2%;"+
            "background: #4ECDC4;"+
            "margin: 20px;"+
            "box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);"+
            "}";

            string contenidos = $"<!DOCTYPE html>"+
                                "<html lang='en' dir='ltr'>"+
                                "<head><meta charset='utf-8'/>"+
                                "<link rel='stylesheet' href='https://pro.fontawesome.com/releases/v5.10.0/css/all.css' integrity='sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p' crossorigin='anonymous'/>"+
                                "<link rel='StyleSheet' href='style.css' media='screen'/>"+
                                "<title>Reporte Pago</title>"+
                                "</head>"+
                                "<body>"+
                                "<div class='portfolio'>"+
                                "<div class='flex-container'>"+
                                "<div class='element second-element'>"+
                                "<div class='titulo'>"+
                                $"<h1>Reporte de Pago</h1>"+
                                "</div>"+
                                "<div class='myInfo'>"+
                                "<div class='right'>"+
                                $"<p>Nombre: <b>{Id}</b></p>"+
                                $"<p>Nombre: <b>{Nombre}</b></p>"+
                                $"<p>Apellido: <b>{Apellido}</b></p>"+
                                $"<p>Placa: <b>{Placa}</b></p>"+
                                $"<p>Marca: <b>{Marca}</b></p>"+
                                $"<p>Latitud: <b>{Latitud}</b></p>"+
                                $"<p>Longitud: <b>{Longitud}</b></p>"+
                                $"<p>Descripcion: <b>{Descripcion}</b></p>"+
                                $"<p>Pago: <b>{pago}</b></p>"+
                                "</div>"+
                                "</div>"+
                                "</div>"+
                                "</div>"+
                                "</div>"+
                                "</body>"+
                                "</html>";
                
            File.WriteAllText($"C:\\ArchivoHTML\\style.css", css);
            File.WriteAllText($"C:\\ArchivoHTML\\datos.html", contenidos);
            Console.Clear();
            return "Factura creado correctamente!...";
        }        
    }
}