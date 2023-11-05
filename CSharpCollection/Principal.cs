using CSsharpCollection.Arrays_Aula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a opção que deseja observar: ");

            Console.WriteLine("Opção 1 --------------- Array");
            Console.WriteLine("Opção 2 --------------- Lista");
            Console.WriteLine("Opção 3 --------------- Sets");
            Console.WriteLine("Opção 4 --------------- LinkedList");
            Console.WriteLine("Opção 5 --------------- Stack");
            Console.WriteLine("Opção 6 --------------- Queue");
            Console.WriteLine("Opção 7 --------------- Dicionarios");

            var opção = Console.ReadLine();



            if (opção == "1")
            {
                var arrays = new Arrays_Program();
                arrays.ChamarArrays();
            }

            else if (opção == "2")
            {
                var lista = new Lista();
                lista.ChamarLista();

            }

            else if (opção == "3")
            {
                var sets = new Sets_Program();
                sets.ChamarSets();

            }


            else if (opção == "4")
            {
                var linkedlist = new Pilhas();
                linkedlist.ChamarPilhas();

            }

            else if (opção == "5")
            {
                var stack = new Stack_Program();
                stack.ChamarStack();

            }

             else if (opção == "6")
            {
                var queue = new Queue_Program();
                queue.ChamarQueue();

            }
            else if (opção == "7")
            {
                var dicionario = new Dicionarios();
                dicionario.ChamarDicionarios();
            }
            else
            {
                Console.WriteLine("Opção inválida");
                return;

            }


        }
    }
}
