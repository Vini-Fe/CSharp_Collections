using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{

    class Lista
    {
        public void ChamarLista()
        {
            Console.WriteLine("Digite o tamanho da sua lista");
            int tam = int.Parse(Console.ReadLine());

            List<string> lista_usuario = new List<string>(tam);

            int posicao = 0;

            while (posicao < tam)
            {
                Console.WriteLine($"Adicione o conteúdo em sua lista na posição: {posicao}");
                lista_usuario.Add(Console.ReadLine());

                posicao++;
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("Sua lista é: ");

            foreach (string item in lista_usuario)
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

                    Console.WriteLine("escreva o conteúdo que deseja remover");
                    string item_removido = Console.ReadLine();

                    lista_usuario.Remove(item_removido);

                    Console.WriteLine("\r\n");

                    Console.WriteLine("Sua lista é :");

                    Console.WriteLine("\r\n");

                    foreach (string item in lista_usuario)
                    {
                        Console.WriteLine(item);

                    }


                }

                if (opção == "adicionar")
                {
                    Console.WriteLine("Digite seu conteúdo:");
                    string item_adicionado = Console.ReadLine();

                    lista_usuario.Add(item_adicionado);

                    Console.WriteLine("\r\n");

                    Console.WriteLine("Sua lista é :");


                    foreach (string item in lista_usuario)
                    {
                        Console.WriteLine(item);

                    }

                }

            }


        }

    }
}
