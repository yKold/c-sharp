using System;

class Carro22{
    private int[] velMax = new int[5]{80,120,160,240,300};
    public int this[int i]{
        get{
            return velMax[i];
        }
        set{
            if(value < 0){
                velMax[i] = 0;
            } else if(value > 300){
                velMax[i] = 300;
            } else{
                velMax[i] = value;
            }
        }
    }
    public Carro22(){
    }
}
class Aula042{
    static void Main(){
        Carro22 c1 = new Carro22();
        c1[1]=200;
        Console.WriteLine(c1[1]);
    }
}