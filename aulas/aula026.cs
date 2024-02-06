using System;

class Aula026{

    static void Main(){
        int w1, w2, w3, w4, w5, w6;
        w1 = 2;
        w2 = 4;

        Somu(

        w1, 
        w2, 
        out w3, 
        out w4, 
        out w5, 
        out w6

        );

        Console.WriteLine(w3);
        Console.WriteLine(w4);
        Console.WriteLine(w5);
        Console.WriteLine(w6);
    }

    static int Somu(

        int v1,  
        int v2, 
        out int res1, 
        out int res2, 
        out int res3, 
        out int res4
        
        ){

        res1 = v1 * v2;
        res2 = v1 + v2;
        res3 = v1 - v2;
        res4 = v2 / v1;
        return 0;
    }    

}