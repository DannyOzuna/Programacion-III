using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;

public class ConsumirApi{
    public List<Result> obtenerDatos(){
        WebClient wc = new WebClient();
        var url = "https://randomuser.me/api/?results=10";
        var datos = wc.DownloadString(url);
        var rs =  JsonConvert.DeserializeObject<Datos>(datos);
        return rs.results;
    }
}