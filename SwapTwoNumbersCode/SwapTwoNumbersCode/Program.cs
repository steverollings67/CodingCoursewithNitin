using System;

namespace SwapTwoNumbersCode
{
    class Program
    {
        static void Main(string[] args)
        {
			int firstNo = 30;
			int secondNo = 10;
			int temp;

            Console.WriteLine($"Before Swap. First Number: {firstNo}, Second Number: {secondNo}");

            temp = firstNo;
            firstNo = secondNo;
            secondNo = temp;

            Console.WriteLine($"After Swap. First Number: {firstNo}, Second Number: {secondNo}");

            firstNo = firstNo + secondNo;
            secondNo = firstNo - secondNo;
            firstNo = firstNo - secondNo;

            Console.WriteLine($"After reswap. First Number: {firstNo}, Second Number: {secondNo}");

		}
    }
}
