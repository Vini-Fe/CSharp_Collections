using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{
      class Dicionarios
    {
        
        public void ChamarDicionarios()
        {

            bool repetidor = true;
            var cadastros = new Dictionary<string, int>();

            while (repetidor)
            {
                Console.WriteLine("Insira seu cadastro: ");
                Console.WriteLine("\r\n");
                Console.WriteLine("Nome : ");
                var nome = Console.ReadLine();
                Console.WriteLine("\r\n");
                Console.WriteLine("Idade : ");
                var idade = int.Parse(Console.ReadLine());

                cadastros[nome] = idade;

                Console.WriteLine("Deseja ver os seus cadastros ? Digite 1 para ver o cadastro e 2 para inserir outro cadastro");
                var resposta = Console.ReadLine() == "1" ? "True" : "False";
                bool resultado = bool.Parse(resposta);

                if (!resultado)
                {
                    Console.WriteLine("\r\n");
                    Console.WriteLine("Estes são seus cadastros :");
                    Console.WriteLine("\r\n");
                    foreach (var c in cadastros)
                    {
                        Console.WriteLine(c);
                        Console.WriteLine("\r\n");
                    }
                    repetidor = false;
                }
              

            }
        }

    }
}
