using System;

class Aula027{

    static void Main(){
        Soma(1,2,3,7,8,9,1);
    }

    static void Soma(params int[] n){
        int soma = 0;
        for(int i = 0; i < n.Length ; i++){
            soma += n[i];
        }
        System.Console.WriteLine(soma);
    }
}