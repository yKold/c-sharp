using System;

class Aula015{
    static void Main(){

        Console.WriteLine("Quantos anos você tem?   ");
        int idade = int.Parse(Console.ReadLine());

        // if(idade < 18){
        //     Console.WriteLine("Criança");
        // } else if( idade >= 18 && idade <25){
        //     Console.WriteLine("Jovem");
        // } else if( idade >= 25 && idade < 60){
        //     Console.WriteLine("Adulto");
        // } else {
        //     Console.WriteLine("Idoso");
        // }

        char a = 'a';
        char b = 'b';
        char c = 'c';
        char d = 'd';
        char res;

        if(idade < 18){
            res = a;
        } else if( idade >= 18 && idade <25){
            res = b;
        } else if( idade >= 25 && idade < 60){
            res = c;
        } else {
            res = d;
        }
             
        switch(res){
            case 'a':
                Console.WriteLine("Criança");
                break;
            case 'b':
                Console.WriteLine("Jovem");
                break;
            case 'c':
                Console.WriteLine("Adulto");
                break;
            case 'd':
                Console.WriteLine("Idoso");
                break;
        }

    }
}
