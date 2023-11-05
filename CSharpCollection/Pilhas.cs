using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{       
    //linked list é mais utilizada para listas menores, seus elementos não precisam estar memorizados em sequência
    //para representar a ordem desejada (cria um "nó")
     class Pilhas
    {
        public void ChamarPilhas()
        {
            Console.WriteLine("Digite o tamanho da pilha: ");
            int tam = int.Parse(Console.ReadLine());

            var pilha_usuario = new LinkedList<string>();

            int posicao = 0;

            while (posicao < tam)
            {
                Console.WriteLine($"Adicione um conteúdo em sua pilha na posição: {posicao}");
                pilha_usuario.AddFirst(Console.ReadLine());

                posicao++;
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("Sua pilha é: ");

            foreach (string item in pilha_usuario)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Deseja remover um conteúdo? Digite S ou N");
            string texto = Console.ReadLine() == "S" ? "True" : "False";
            bool resposta = bool.Parse(texto);



            if (resposta == false)
            {
                Environment.Exit(0);
            }

            if (resposta == true)
            {


                Console.WriteLine("escreva o conteúdo que deseja remover");
                string item_removido = Console.ReadLine();

                pilha_usuario.Remove(item_removido);

                Console.WriteLine("\r\n");

                Console.WriteLine("Sua pilha é :");

                Console.WriteLine("\r\n");

                foreach (string item in pilha_usuario)
                {
                    Console.WriteLine(item);

                }


            }

        }          
     }
}
