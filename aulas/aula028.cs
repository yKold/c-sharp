using System; 


public class Jogador{
    public int energia = 100;
    public bool vivo = true;
}

class Aula028{
    static void Main(){
        Jogador j1 = new Jogador();
        j1.energia = 50;
        System.Console.WriteLine("Energia do J1: {0}", j1.energia);
    }
}