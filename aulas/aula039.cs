using System;

abstract class Veiculo001{
    protected int velMax;
    protected int velAtual;
    protected bool ligado;
    public Veiculo001(){
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado){
        this.ligado = ligado;
    }
    abstract public void aceleracao(int mult);
}


class Carro001:Veiculo001{
    public Carro001(){
        velMax = 120;
    }
    override public void aceleracao(int mult){
        velAtual+=10*mult;
    }
    public int getVelAtual(){
        return velAtual;
    }
}
class Aula039{

    static void Main(){
        Carro001 c1 = new Carro001();
        c1.aceleracao(3);
        Console.WriteLine(c1.getVelAtual());;
    }
}