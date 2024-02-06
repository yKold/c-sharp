using System;

class Area{
    public static float Quad(float bas, float altura){
        if(bas == 0 || altura == 0){
            throw new Exception("Base ou altura == 0");
        } 
        return bas*altura;
    }
}

class Aula053{
    static void Main(){
        float area=0;

        try {
            area = Area.Quad(10f,0f);
            System.Console.WriteLine("Area do quad: {0}", area);
        } catch(Exception e) {
            Console.WriteLine("Error: {0}", e.Message);
        } finally {
            Console.WriteLine("Fim do Processo");
        }
        

        

    }
}