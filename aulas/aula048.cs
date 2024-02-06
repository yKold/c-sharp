using System;



class Calcc{
    public int soma(params int[]n){
        int s = 0;
        for(int x = 0; x < n.Length; x++){
            s += n[x];
        }
        return s;
    }
    public double soma(params double[]n){
        double s = 0;
        for(int x = 0; x < n.Length; x++){
            s += n[x];
        }
        return s;
    }
    public int fatorial(int n){
        int res;
        if(n < 1){
            res = 1;
        }else{
            res = n * fatorial(n-1);
        }
        return res;
    }



    // public int soma(int n1, int n2, int n3){
    //     return n1+n2+n3;
    // }
    // public int soma(int n1, int n2, int n3, int n4){
    //     return n1+n2+n3+n4;
    // }
}



class Aula048{
    static void Main(){
        Calcc cal = new Calcc();
        var res = cal.fatorial(15);
        System.Console.WriteLine(res);
    }
}