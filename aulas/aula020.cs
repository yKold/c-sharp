using System;

class Aula020{

    static void Main(){

        int[] array = new int[10];

        for(int i = 0; i < 10; i++){
            Console.WriteLine(i);
        }

        Console.WriteLine("Acabou o loop com For!!");
        
        while(array[0] < 10){
            array[0] = array[0] + 1;
            Console.WriteLine(array[0]);
        }



    }
}