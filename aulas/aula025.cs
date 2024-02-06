using System;

class Aula025{

    static void Main(){
        int v1;
        v1 = 10;
        
        Dobrar(ref v1);
        Console.WriteLine(v1);
    }

    static void Dobrar(ref int n1){
        n1 *= 2;
    }

}