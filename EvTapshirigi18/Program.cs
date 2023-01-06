namespace EvTapshirigi18
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Qonsu elementler arasindaki ishare deyishmelerinin sayi
            
            Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if ((arr[i] > 0 && arr[i - 1 ] < 0) || (arr[i] < 0 && arr[i - 1] > 0))               
                    count++;
                
            }
            Console.Write(count);
        }
    }
}
