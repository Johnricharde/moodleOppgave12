namespace moodleOppgave12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isLessThan10 = true;

            int counter = 0;

            while (isLessThan10){
                if (counter < 10)
                {
                    Console.WriteLine($"Runde {counter + 1}");
                    counter++;
                }
                else
                {
                    isLessThan10 = false;
                }
            }
        }
    }
}
