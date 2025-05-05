namespace UcgenCizme
{
    public class Ucgen
    {
        public void UcgenCiz(int sayi)
        {
            for (int i = 1; i < sayi; i++)
            {
                for (int k = 1; k <= sayi - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }

        }

    }
}