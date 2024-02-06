using System; 


public class Jogador1{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador1(string n){
        nome = n;
        energia = 100;
        vivo = true;
    }
    ~Jogador1(){
        Console.WriteLine("Jogador destruido");
    }
}

class Aula029{
    static void Main(){
        Console.WriteLine("Digite um nome:   ");
        string nome = Console.ReadLine();
        Jogador1 j1 = new Jogador1(nome);

        j1.energia = 50;

        Console.WriteLine("Energia do J1: {0}", j1.energia);
        Console.WriteLine("Nome do J1: {0}", j1.nome);
        
    }
}