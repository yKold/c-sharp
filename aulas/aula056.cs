using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;


class Aula056{
    static void Main(){

        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        transp.AddLast("Bicicleta");

        LinkedListNode<string> no;
        no = transp.FindLast("Navio").Next;
        transp.AddAfter(no, "Patinete");
        transp.AddBefore(no, "Patins");

        // transp.Clear();
        if(transp.Find("Carro") == null){
            System.Console.WriteLine("Null");
        } else {
            System.Console.WriteLine("OK");
        }

        // transp.Remove("Navio");

        foreach(string n in transp){
            Console.WriteLine(n);
        }



    }
}