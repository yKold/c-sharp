using System;
using System.Collections.Generic;


class Aula057{
    static void Main(){

        List<string> carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        // carros2.AddRange(carros);

        // carros.Clear()
        if(carros.Contains("Gol")){
            System.Console.WriteLine("Contem");
        }else {
            Console.WriteLine("Nao contem");
        }

        carros.CopyTo(carros2, 2);

        carros.Insert(3, "John");
        carros.Insert(4, "John");
        string j = "John";
        Console.WriteLine("Ultimo index de j = {0}",carros.LastIndexOf(j));

        carros.Remove("Argo");
        carros.RemoveAt(0);
        carros.Reverse();
        carros.Sort();

        System.Console.WriteLine("Tamanho = {0}", carros.Count);

        foreach(string c in carros){
            Console.WriteLine(c);
        }

        string d = "HRV";
        Console.WriteLine("Index de = {0}",carros.IndexOf(d));

        

    }
}