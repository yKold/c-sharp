using System;

class Aula024{

    static void Main(){
        int v1, v2, ra;
        v1 = Convert.ToInt32(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());
        
        ra = Soma(v1, v2);
        Console.WriteLine(ra);
    }

    static int Soma(int n1, int n2){
        int res = n1 + n2;
        return res;
    }

}