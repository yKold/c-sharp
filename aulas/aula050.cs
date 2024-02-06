using System;

delegate int Op(int n1, int n2);
class Matt{
    public static int soma(int n1, int n2){
        return n1 + n2;
    }
    public static int mult(int n1, int n2){
        return n1*n2;
    }
}

class Aula050{
    static void Main(){
        int resultado;

        Op d1 = new Op(Matt.soma);
        resultado = d1(10, 50);
        Console.WriteLine(resultado);

        d1 = new Op(Matt.mult);
        resultado = d1(10, 50);
        Console.WriteLine(resultado);
    }
}