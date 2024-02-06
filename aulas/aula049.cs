using System;


class Mat{
    public static double pi = 3.14;
    public static int dobro(int n){
        return n*2;
    }
}


class Aula049{
    static void Main(){
        double vpi = Mat.pi;
        int n = 10;
        Console.WriteLine(Mat.dobro(n));
        Console.WriteLine(vpi);
    }
}