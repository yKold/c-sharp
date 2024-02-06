using System;

public interface Vei{
    
    void ligar();
    void desligar();
    void info();
}
public interface Combate{
    void disparar();
}
class Carro33:Vei,Combate{
    public bool ligado;
    private int municao;
    public Carro33(){
       setMunicao(100);
    }
    public void setMunicao(int qtde){
        this.municao = qtde; 
    }
    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }
    public void info(){}
    public void disparar(){}
}
class Aula043{
    static void Main(){
        Carro33 c1 = new Carro33();
    }
}