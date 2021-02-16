using System.Net;
using System.Text.Json;


namespace Services{
    public class ObtenerClima{
        private string RUTA_API_UBICACION = "https://freegeoip.app/json/";

        public DatosLocation ubicacionActual(){
            using(var wc = new WebClient()){
                var response = wc.DownloadString(RUTA_API_UBICACION);
                var datos = JsonSerializer.Deserialize<DatosLocation>(response);
                return datos;
            }
            
        }
    }
}