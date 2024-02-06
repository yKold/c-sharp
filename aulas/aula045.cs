using System;


struct Carro55{
    public string modelo;
    public string cor;
    public void info(){
        Console.WriteLine("{0},\n{1}", this.modelo, this.cor);
        Console.WriteLine("_______________________");
    }
}

class Aula045{
    static void Main(){
        Carro55[] c1 = new Carro55[4];

        c1[0].modelo = "HRV";
        c1[0].cor = "Prata";

        c1[1].modelo = "Golf";
        c1[1].cor = "Azul";
        
        c1[2].modelo = "Jetta";
        c1[2].cor = "Branco";
        
        c1[3].modelo = "Argo";
        c1[3].cor = "Preto";

        for(int i = 0; i < c1.Length; i++){
            c1[i].info();
        }
    }
}