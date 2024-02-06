using System; 


public class Jogador2{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador2(){
        nome = "Jogador";
        energia = 100;
        vivo = true;
    }
    public Jogador2(string n){
        nome = n;
        energia = 100;
        vivo = true;
    }
    public Jogador2(string n, int e){
        nome = n;
        energia = e;
        vivo = true;
    }
    public Jogador2(string n, int e, bool v){
        nome = n;
        energia = e;
        vivo = v;
    }
    public void info(){
        Console.WriteLine("Nome player: {0}", nome);
        Console.WriteLine("Energia player: {0}", energia);
        Console.WriteLine("Estado player: {0}\n", vivo);
    }
}


class Aula030{
    static void Main(){
        Jogador2 j1 = new Jogador2();
        Jogador2 j2 = new Jogador2("Bruno");
        Jogador2 j3 = new Jogador2("Bruno", 50);
        Jogador2 j4 = new Jogador2("Gabriel", 200, false);
        
        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }
}