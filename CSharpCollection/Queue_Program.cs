using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{
     class Queue_Program
    {
        public void ChamarQueue()
        {
            Console.WriteLine("Digite o tamanho da seu set: ");
            int tam = int.Parse(Console.ReadLine());

            var fila_usuario = new Queue<string>();

            int posicao = 0;

            while (posicao < tam)
            {
                Console.WriteLine($"Adicione um conteúdo de número {posicao} na sua fila");
                fila_usuario.Enqueue(Console.ReadLine());

                posicao++;
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("Sua fila é: ");

            foreach (string item in fila_usuario)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            Console.WriteLine("Deseja adicionar ou remover um conteúdo? Digite S ou N");
            string texto = Console.ReadLine() == "S" ? "True" : "False";
            bool resposta = bool.Parse(texto);



            if (resposta == false)
            {
                Environment.Exit(0);
            }

            if (resposta == true)
            {
                Console.WriteLine("remover ou adicionar ?");
                string opção = Console.ReadLine();
                Console.WriteLine("\r\n");

                if (opção == "remover")
                {
                    fila_usuario.Dequeue();

                    Console.WriteLine("\r\n");

                    Console.WriteLine("Seu set é :");

                    Console.WriteLine("\r\n");

                    foreach (string item in fila_usuario)
                    {
                        Console.WriteLine(item);

                    }


                }

                if (opção == "adicionar")
                {
                    Console.WriteLine("Digite seu conteúdo:");
                    string item_adicionado = Console.ReadLine();

                    fila_usuario.Enqueue(item_adicionado);

                    Console.WriteLine("\r\n");

                    Console.WriteLine("Seu set é :");


                    foreach (string item in fila_usuario)
                    {
                        Console.WriteLine(item);

                    }

                }
            }

        }

            //numa fila o primeiro que entra é, também, o primeiro que sai.
     }
}
