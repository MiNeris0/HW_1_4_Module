namespace HW_1_4_Module_work
{
    /// <summary>
    /// start point of Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Start of app.
        /// </summary>
        /// <param name="args">args added via console. </param>
        public static void Main(string[] args)
        {
            List<char> list = new List<char>();
            for (char c = 'A'; c <= 'Z'; ++c)
            {
                list.Add(c);
            }

            char[] alphabet = list.ToArray();

            Console.Write("Set the array size: ");
            byte n = Convert.ToByte(Console.ReadLine());
            byte[] initial = new byte[n];
            byte i2 = 0;
            byte i3 = 0;

            Console.Write("Initial array: ");
            for (byte i = 0; i < initial.Length; i++)
            {
                initial[i] = (byte)new Random().Next(1, 26);
                Console.Write(initial[i] + " ");
            }

            for (byte i = 0; i < initial.Length; i++)
            {
                if (initial[i] % 2 != 0)
                {
                    i2++;
                }
                else
                {
                    i3++;
                }
            }

            byte[] oddArray = new byte[i2];
            Console.WriteLine("\n");
            Console.Write("Odd Array: ");
            byte i1 = 0;
            byte i4 = 0;
            for (byte i = 0; i < initial.Length; i++)
            {
                if (initial[i] % 2 != 0)
                {
                    oddArray[i1] = initial[i];
                    Console.Write(oddArray[i1] + " ");
                    i1++;
                }
            }

            byte[] evenArray = new byte[i3];
            Console.WriteLine();
            Console.Write("Even Array: ");
            for (int i = 0; i < initial.Length; i++)
            {
                if (initial[i] % 2 == 0)
                {
                    evenArray[i4] = initial[i];
                    Console.Write(evenArray[i4] + " ");
                    i4++;
                }
            }

            char[] numbersToCharEven = new char[evenArray.Length];
            char[] numbersToCharOdd = new char[oddArray.Length];
            Console.WriteLine("\n");
            Console.Write("Odd Array to letters: ");

            for (byte i = 0; i < numbersToCharOdd.Length; i++)
            {
                numbersToCharOdd[i] = alphabet[oddArray[i]];
                Console.Write(numbersToCharOdd[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Even Array to letters: ");
            for (byte i = 0; i < numbersToCharEven.Length; i++)
            {
                numbersToCharEven[i] = alphabet[evenArray[i]];
                Console.Write(numbersToCharEven[i] + " ");
            }
        }
    }
}