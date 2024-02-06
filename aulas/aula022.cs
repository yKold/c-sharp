using System;

class Aula022{

    static void Main(){

        int[] num = new int[4];
        
        int a = 4;

        foreach(int n in num){
            num[n] = a++;
            System.Console.WriteLine(num[n]);
        }
    }
}
