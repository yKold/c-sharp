using System; 


static public class Jogador3{
    static public int energia;
    static public bool vivo;
    static public string nome;
    static public void iniciar(string n){
        nome = n;
        energia = 100;
        vivo = true;
    }
    static public void info(){
        Console.WriteLine("Nome player: {0}", nome);
        Console.WriteLine("Energia player: {0}", energia);
        Console.WriteLine("Estado player: {0}\n", vivo);
    }
}

class Inimigo{
    static public bool alerta;
    public string nome;
    public Inimigo(string n){
        alerta = false;
        nome = n;
    }
    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("------------------");
    }
}

class Aula031{
    static void Main(){
        Jogador3.iniciar("Bruno");
        Jogador3.info();

        Inimigo i1 = new Inimigo("Doidao");
        Inimigo i2 = new Inimigo("Maluco");
        Inimigo i3 = new Inimigo("Pirado");

        Inimigo.alerta = true;

        i1.info();
        i2.info();
        i3.info();
    }
    
}