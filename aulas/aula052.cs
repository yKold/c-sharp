using System;

class Aula052{
    static void Main(){

        int n1, n2, res;
        res = n1 =n2 = 0;

        n1 = 10;
        n2 = 0;
        try {
            res = n1/n2;
            Console.WriteLine("Resultado: {0}", res);
        } catch(Exception e){
            Console.WriteLine("Error: {0}", e.Message);
        }
        

        

    }
}