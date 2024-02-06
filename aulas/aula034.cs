using System;

class Veiculo{
    public int rodas;
    public int velMax;
    public bool ligado;
    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }
}
class Carro:Veiculo{
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        desligar();
        rodas = 4;
        velMax= 120;
        this.nome = nome;
        this.cor = cor;

    }
}
class Aula034{

    static void Main(){
        Carro c1= new Carro("Rapidão", "Vermelho");
        System.Console.WriteLine(c1.nome);
    }
}