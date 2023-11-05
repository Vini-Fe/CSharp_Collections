using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{
    class Sets_Program
    {
        public void ChamarSets()
        {

            //Sets = conjuntos

            //duas propriedades do set
            //1. não permite duplicidade
            //2. os elementos não são mantidos em ordem específica

            Console.WriteLine("Digite o tamanho do seu set: ");
            int tam = int.Parse(Console.ReadLine());


            ISet<string> set_usuario = new HashSet<string>();

            int posicao = 0;

            while (posicao < tam)
            {
                Console.WriteLine($"Adicione um conteúdo em seu set na posição: {posicao}");
                set_usuario.Add(Console.ReadLine());

                posicao++;
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("Seu set é: ");

            foreach (string item in set_usuario)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            

            Console.WriteLine("Deseja adicionar ou remover um conteúdo? Digite S ou N");
            string texto = Console.ReadLine() == "S" ? "True": "False";
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

                            set_usuario.Remove(item_removido);

                            Console.WriteLine("\r\n");
                        
                            Console.WriteLine("Seu set é :");

                            Console.WriteLine("\r\n");
                    
                            foreach (string item in set_usuario)
                            {
                            Console.WriteLine(item);
                                               
                            }

                     
                         }

                        if(opção == "adicionar")
                        {
                            Console.WriteLine("Digite seu conteúdo:");
                            string item_adicionado = Console.ReadLine();

                            set_usuario.Add(item_adicionado);

                            Console.WriteLine("\r\n");

                            Console.WriteLine("Seu set é :");

                            
                            foreach (string item in set_usuario)
                            {
                                Console.WriteLine(item);

                            }

                        }

                }

           
        }

    }
}

