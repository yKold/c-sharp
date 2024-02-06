using System;

class Aula051{
    static void Main(string[] args){

        int res = 0;

        if(args.Length > 0){
            Console.WriteLine("Quantidade de argumentos {0}", args.Length);

            for(int i = 0; i < args.Length; i++){
                res += Int32.Parse(args[i]);
                System.Console.WriteLine(res);
            }
        }else{
            Console.WriteLine("no args");
        }
    }
}