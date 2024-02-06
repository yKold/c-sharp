using System;

class Carro11{
    private int velMax;
    public int vm{
        get{
            return velMax;
        }
        set{
            if(value < 0){
                velMax = 0;
            } else if(value > 300){
                velMax = 300;
            } else{
                velMax = value;
            }
        }
    }
    public Carro11(){
        vm = 120;
    }
}
class Aula041{
    static void Main(){
        Carro11 c1 = new Carro11();
        System.Console.WriteLine(c1.vm);
    }
}