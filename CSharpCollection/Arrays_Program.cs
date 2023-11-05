namespace CSsharpCollection.Arrays_Aula
{
    public class Arrays_Program
    {
        public void ChamarArrays()
        {
            Console.WriteLine("Digite o tamanho do array: ");
            int tam = int.Parse(Console.ReadLine());

            int[] arrayCriado = new int[tam];

            int posicao = 0;


            while (posicao < arrayCriado.Length)
            {
                Console.WriteLine($"Insira o valor na posição:  {posicao} do array ");
                arrayCriado[posicao] = int.Parse(Console.ReadLine());


                posicao++;
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("os valores do seu array são: ");



            foreach (int valor in arrayCriado)
            {
                Console.WriteLine(valor);

            }

            Console.ReadLine();

        }
    }
}
