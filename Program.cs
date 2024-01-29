namespace aula24._4
{
    internal class Program
    {
        static void Main()
        {
            soma(10,5);
        }

        static void soma(int n1,int n2)
        {
            int res=n1+n2;

            Console.WriteLine("A soma de {0} e {1} é: {2}",n1,n2,res); 
        }
    }
}