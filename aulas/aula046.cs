using System;


class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }
    public Ovo botar(){
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo{
    private int numOvos;
    private string minhaGalinha;
    public Ovo(int numOvos1, string minhaGalinha){
        this.numOvos = numOvos1;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo Criado: {0} - {1}", numOvos1, minhaGalinha);
    }
}


class Aula046{

    static void Main(){
        Galinha g1 = new Galinha("Josefina");
        Galinha g2 = new Galinha("Felizberta");
        Galinha g3 = new Galinha("Marilda");

        g1.botar();
        g1.botar();
        g1.botar();
        g1.botar();

    }
}