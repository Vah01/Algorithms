namespace decnum
{
    class BinaryNuber
    {
        public int binaryNumber;
        public int decimalValue = 0;
        public int base1 = 1;
        public void GetBinary()
        {
            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"Decimal Value : {decimalValue} ");
            Console.ReadKey();
        }
    }
    class Decnum
    {
        public int decimalnumber;
        public int rem;
        public string result = string.Empty;
        public void GetDecimal()
        {
            while (decimalnumber > 0)
            {
                rem = decimalnumber % 2;
                decimalnumber /= 2;
                result = rem.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Decnum ob = new Decnum();
            do
            {
                Console.Write("DecimalNumber =");
                ob.decimalnumber = int.Parse(Console.ReadLine());
            }   while (ob.decimalnumber < 0);
            ob.GetDecimal();
            BinaryNuber ob1 = new BinaryNuber();
            do
            {
                Console.Write("Enter the Binary Number : ");
                ob1.binaryNumber = int.Parse(Console.ReadLine());
            } while (ob1.binaryNumber < 0);
            ob1.GetBinary();
            
        }
    }
}


