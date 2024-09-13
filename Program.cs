namespace _1;

class Program
{
    /*
    Given n, take the sum of the digits of n. If that value has more than one digit, 
    continue reducing in this way until a single-digit number is produced. 
    The input will be a non-negative integer.
    */
    static void Main()
    {
        NReducer(2302028723918);

        
    }
    //Example: 156 = 1+5+6 = 12 -> Two digits, remove one. -> 1

    public static int NReducer(long n)
    {
        long nSummed = 0;
        long nDivided = n; //???
        long nDigits = n.ToString().Length;//
        long wat = 0;

        while (nDigits != 0)
        {
            Console.WriteLine(nDigits + ": " + nSummed + ", Divided: " + nDivided);
            nSummed += nDivided % 10; // Adding the last digit of 'n' to the 'sum' variable
            nDivided /= 10;
            Console.WriteLine("Is " + nDigits + " more than 1?");
            nDigits = nDivided.ToString().Length;
            if(nDigits <= 1)
            {
                nSummed += nDivided % 10; // Adding the last digit of 'n' to the 'sum' variable
                Console.WriteLine("Final run: " + nSummed);

                nDigits = 0;
            }
        }
        while (nSummed != 0)
        {
            wat += nSummed%10;
            Console.WriteLine(nSummed);
            nSummed /= 10;
            Console.WriteLine("Summed sum: " + wat);

        }
        if(wat.ToString().Length > 1)
        {
            long x;
            x = wat%10;
            wat /= 10;
            wat = x+wat;
        }
        Console.WriteLine("Final wat: " + wat);

        return (int)wat;
    }
}
