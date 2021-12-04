namespace Statement
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("nhap day so muon xem so chan toi da la 10 so: ");
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < 10;i++)
            {
                if ( a[i] % 2 == 0)
                {
                    Console.WriteLine( + a[i]);
                }
            }
               
            
        }
    }
}



