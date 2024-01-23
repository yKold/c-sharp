using System;

class Aula006{
    static void Main(){

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra*lucro);

        Console.WriteLine("Produto........:{0,15}", produto);
        Console.WriteLine("Valor.Compra...:{0,15:c}", valorCompra);
        Console.WriteLine("Valor.Venda....:{0,15:c}", valorVenda);
        Console.WriteLine("Lucro..........:{0,15:p}", lucro);



        // int n1, n2, n3;
        // n1 = 10; n2 = 20; n3 = 30;
        // Console.Write("n1={0},\n n2={1},\n n3={2}\n", n1, n2, n3);

    }
}