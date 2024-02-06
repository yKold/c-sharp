using System;

class Veiculo2{
    private int rodas;
    public int velMax;
    public bool ligado;
    public Veiculo2(int rodas){
        this.rodas = rodas;
    }
    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }
    public int getRodas(){
        return rodas;
    }
    public string getLigado(){
        return(ligado?"sim":"não");
    }
    public int analisar(){
        return(ligado?velMax=120:velMax=0);
    }
    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas = 0;
        } else if(rodas>40){
            this.rodas = 40;
        } else {
            this.rodas = rodas;
        }
    }
}
class Carro3:Veiculo2{
    public string nome;
    public string cor;
    public Carro3(string nome, string cor):base(4){
        analisar();
        this.nome = nome;
        this.cor = cor;
    }
}
class CarroCombate:Carro3{
    public int municao;
    public CarroCombate():base("carro de combate", "verde"){
        municao = 100;
        setRodas(6);
    }
}
class Aula035{

    static void Main(){
        
        Carro3 c1= new Carro3("Rapidão", "Vermelho");
        CarroCombate cc1= new CarroCombate();

        
        c1.ligar();
        Console.WriteLine(c1.getLigado());
        c1.analisar();
        Console.WriteLine(c1.getRodas());
        Console.WriteLine(c1.nome);
        Console.WriteLine(c1.cor);
        Console.WriteLine(c1.ligado );
        Console.WriteLine(c1.velMax);
        System.Console.WriteLine("----------------------");

        cc1.ligar();
        Console.WriteLine(cc1.getLigado());
        cc1.analisar();
        Console.WriteLine(cc1.getRodas());
        Console.WriteLine(cc1.nome);
        Console.WriteLine(cc1.cor);
        Console.WriteLine(cc1.ligado );
        Console.WriteLine(cc1.velMax);
        
    }
}