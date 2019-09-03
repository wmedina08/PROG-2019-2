using System;
using System.Collections.Generic;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {/* 
           var lista=new List<int>{15,20,8,13,12,15,15,20,0,6,12};
           int apro;
            int j=0;
        for(int i=0; i<lista.Count;i++){
            var num=lista[i];
            if(num>10){
                j++;
            }
        }
        var aprobados =lista.Where(x => x>10);
        var promedio =lista.Average();
        */
        var lista =new List<String>{"Manzana","Uva","Piña","Naranaja","Pera","Platano","Granadilla","Melon","Papaya"};
        /* var fruta=lista.Where(x =>x.StartsWith("P"));
            foreach(var item in fruta){
            Console.WriteLine(item);
        }
        }
        */
        var fruta=lista.Where(x =>x.StartsWith("P"));
        var up=fruta.First();
        var ul=fruta.Last();
        Console.WriteLine(up);
        Console.WriteLine(ul);
        }
    }
}
