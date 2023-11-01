//mohammadmousavi moadel
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("salam dawsh\t chandta dars emtehan dadi?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            float sum = 0, unit, unit1 = 0;
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("dars{0} chand shodi?:", i + 1);
                num[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("dars{0}:chand vahedi bud?:", i + 1);
                unit = Convert.ToInt32(Console.ReadLine());
                sum += unit * num[i];
                unit1 += unit;

            }

            float avg = sum / unit1;
            Console.WriteLine("benazam moadeled shode {0}", avg);


        }
    }
}