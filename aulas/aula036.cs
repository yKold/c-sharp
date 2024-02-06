using System;

class Veiculo01{
    public int velAtual;
    private int velMax;
    protected bool ligado;
    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }
    public Veiculo01(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }
}


class Carro01:Veiculo01{
    public string nome;
    public Carro01(string nome, int vm):base(vm){
        this.nome = nome;
        ligado = true;
    }
}



class Aula036{

    static void Main(){
        Carro01 c1 = new Carro01("Pretin", 100);
        Console.WriteLine(c1.getLigado());
        Console.WriteLine(c1.getVelMax());
    }
}