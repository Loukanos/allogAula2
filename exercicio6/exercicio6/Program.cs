//Lucas
internal class Program
{
    private static void Main(string[] args)
    {

        bool temA = false;
        Console.WriteLine("Entre com a frase:");
        string input = Console.ReadLine();
        char[] chars = input.ToCharArray();//cria um array de caracteres através do string

        for (int i = 0; i < chars.Length; i++)//percorre array e realiza as substituições necessárias
        {
            if (chars[i] == 'A' || chars[i] == 'a')
            {
                temA = true;
                chars[i] = '&';
            }
        }

        if (temA==true)//só checa se a frase realmente seria modificada
        {
            Console.WriteLine("Frase modificada:");
            input = new string(chars);//transfere os caracteres modificados de volta ao input
            Console.WriteLine(input);
        }
        else//se não for, avisa usuário
        {
            Console.Clear();//só pra bonito
            Console.WriteLine("Sua frase não tem 'A' ou 'a' e fica igual.");
        }

    }
}