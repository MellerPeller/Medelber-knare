namespace Medelberäknare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 0;
            double divider =0;


            while (true) 
            { 
                value = value + Convert.ToDouble(Console.ReadLine());
                divider++;
                Console.WriteLine("Medelvärdet är " + (value/divider));
             
            }





        }
    }
}
