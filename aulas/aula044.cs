using System;


struct Carro44{
    public string marca;
    public string modelo;
    public string cor;
    public Carro44(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void info(){
        Console.WriteLine("{0},{1},{2}",this.marca, this.modelo, this.cor);
    }
}

class Aula044{
    static void Main(){
        Carro44 c1 = new Carro44("honda", "HRV", "preto");

        // c1.marca = "VW";
        // c1.modelo = "Golf";
        // c1.cor = "Vermelho";
        c1.info();
        
    }
}