using System;

class Aula010{


    enum DiasSemana{
        Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado
    };
    static void  Main(){

        DiasSemana ds = DiasSemana.Domingo;
        int sexta5 = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);
        Console.WriteLine(sexta5);



    }
}