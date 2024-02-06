using System;


class Base01{
    public Base01(){
        Console.WriteLine("Construtor da classe base");
    }
    virtual public void info(){}
}

class Derivada01:Base01{
    public Derivada01(){
        Console.WriteLine("Construtor da classe derivada 1");
    }
    override public void info(){
        Console.WriteLine("Derivada 1");
    }
}

class Derivada02:Derivada01{
    public Derivada02(){
        Console.WriteLine("Construtor da classe Derivada 2");
    }
    override public void info(){
        Console.WriteLine("derivada 2");
    }
}

class Aula038{
    static void Main(){

        Base01 Ref;

        Derivada01 d1 = new Derivada01();
        Derivada02 d2 = new Derivada02();
        
        Ref = d1;
        Ref.info();
    }
}