internal class Program
{
    private static void Main(string[] args)
    {
        float c;
        Console.WriteLine("Insira temperatura em graus celsius");

        while (true)
        {
            try
            {
                string s =Console.ReadLine();;
                s= s.Replace('.',',');//substituir "." por ","
                c = float.Parse(s);
                break;
            } catch(Exception ex) 
            {
                Console.WriteLine("Erro ao ler temperatura: " + ex.Message);
            }
        }
        float f = (9*c + 160)/5;
        Console.WriteLine("A temperatura em farenheit é: " + f);
    }
}