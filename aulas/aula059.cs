using System;
using System.Collections.Generic;

class Aula059{
    static void Main(){

        string[] vs = {"carro","moto","navio","aviao"};
        Queue<string>veiculos = new Queue<string>(vs);

        veiculos.Enqueue("motoca");
        veiculos.Enqueue("bicicleta");
        veiculos.Enqueue("patins");
        veiculos.Enqueue("patinete");

        string a = "aviao";

        if(veiculos.Contains(a)){
            System.Console.WriteLine("Possui o: {0}", a);
        }else{
            System.Console.WriteLine("Nao cotem");
        }

        Console.WriteLine("Tamanho: {0}", veiculos.Count);
        // veiculos.Clear();
        // Console.WriteLine("Tamanho: {0}", veiculos.Count);
        System.Console.WriteLine(veiculos.Peek());



    }
}