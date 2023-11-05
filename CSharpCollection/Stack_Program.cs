using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{
     class Stack_Program
    {
        public void ChamarStack()
        {


            Console.WriteLine("Digite o tamanho da seu stack");
            int tam = int.Parse(Console.ReadLine());

            var stack_usuario = new Stack<string>(tam);

            int posicao = 0;

            while (posicao < tam)
            {
                Console.WriteLine($"Adicione o conteúdo em seu stack na posição: {posicao}");
                stack_usuario.Push(Console.ReadLine());

                posicao++;
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("Seu stack é: ");

            foreach (string item in stack_usuario)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }    
        //com a prioridade de que "o último elemento que entra é o primeiro que sai", o que chamamos de LIFO, em inglês, "Last in, first out".
     }
}
