namespace UcgenCizme
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Üçgen için satır sayısı giriniz: ");
            if (Int32.TryParse(Console.ReadLine(), out int sayi))
            {
                Ucgen ucgen = new Ucgen();
                ucgen.UcgenCiz(sayi);

            }
            else
            {
                Console.WriteLine("Geçersiz giriş yaptınız!!");
            }

        }
    }


}