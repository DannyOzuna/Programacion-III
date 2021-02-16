using System;
using System.Linq;
using HtmlAgilityPack;
using ScrapySharp.Extensions;

public class ObtenerDatos{
    public int cImagenes=0, cParrafos=0;
    public void datosObtenidos(string url){

        HtmlWeb oWeb = new HtmlWeb();
        HtmlDocument doc = oWeb.Load(url);

        //Para obtener la cantidad de imagnes 
        HtmlNode img =  doc.DocumentNode.CssSelect("img").First();
        cImagenes  = img.InnerLength;

        //Para obtener la cantidad de parrafos 
        HtmlNode p =  doc.DocumentNode.CssSelect("p").First();
        cParrafos = p.InnerLength;
    }
}