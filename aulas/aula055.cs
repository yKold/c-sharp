using System;
using System.Collections.Generic;

class Aula055{
    static void Main(){

        Dictionary <int, string> veiculos = new Dictionary <int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Aviao");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        // veiculos.Clear();
        // Console.WriteLine(veiculos.Count);

        veiculos.Remove(20);
        veiculos[15] = "Bicicleta";

        string chave = "Bicicleta";
        if(veiculos.ContainsValue(chave)){
            System.Console.WriteLine("ON");
        } else {
            System.Console.WriteLine("OFF");
        }

        Dictionary<int, string>.ValueCollection valores = veiculos.Values;

        foreach(string v in valores){
            System.Console.WriteLine(v);
        }

    }
}