using Mathematics;
using System;

namespace DSAExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDigit c = new CountDigit();
            Palindrome p = new Palindrome();
            Factorial f = new Factorial();
            Fibonachi fb = new Fibonachi();
            GCD g = new GCD();
            LCM l = new LCM();
            PrimeNunber prime = new PrimeNunber();
            PrimeFactor pf = new PrimeFactor();
            AllDivisonOfNumber ad = new AllDivisonOfNumber();
            AllPrimeNOLessThanN pn = new AllPrimeNOLessThanN();
            Power pw = new Power();
            //Console.WriteLine("Digit in number "+c.countdigit(4567900));
            //Console.WriteLine("Is Palindrome " + p.palindrome(789870));
            //Console.WriteLine("Factorial : " + f.factorial(5));
            //Console.WriteLine("time complexity is O(n) and space complexity(Auxilary space) is tehta(n) because" +
            //    " at the end we have n+1 fuction call in fucntion stack so this not good solution");
            //Console.WriteLine("Factorial : " + f.factorialRecursion(5));
            //Console.WriteLine("No of Trailing zero in given no factorial :" +
            //    f.TrailingZeroInFactorial(5));
            //Console.WriteLine("No of Trailing zero in given no factorial by division method :" +
            //    f.CountTrailingZero(251));

            //Console.WriteLine("time complexity is o(2^n), space complexity is @(n)" +
            //    " and nth fibo term is " + fb.fibo1(0));
            //Console.WriteLine("nth fibo term is " + fb.fibo2(1));
            //Console.WriteLine("nth fibo term is " + fb.fibo3(4));
            //Console.WriteLine("GCD of two no is " + g.gcd(18, 3));
            //Console.WriteLine("The time complexity of Euclidean algorithm is O(log(min(a, b))");
            //Console.WriteLine("GCD of two no is " + g.gcdByEuclideanAlgo(18, 3));
            //Console.WriteLine("LCM of two no is " + l.lcm1(12, 5));
            //Console.WriteLine("LCM of two no is " + l.lcm2(12, 5));
            //Console.WriteLine("Is Prime : " + prime.IsPrime1(1031));
            //Console.WriteLine("Is Prime : " + prime.IsPrime2(1031));
            //Console.WriteLine("Is Prime : " + prime.IsPrime3(1031));
            //Console.WriteLine("Prime factor of given no by 1 method are");
            //pf.primefactor1(84);
            //Console.WriteLine("Prime factor of given no by 2 method are");
            //pf.primefactor2(84);
            //Console.WriteLine("All divisor of given no by 1 method are");
            //ad.alldivisor1(100);
            //Console.WriteLine("All divisor of given no by 2 method are");
            //ad.alldivisor2(100);
            Console.WriteLine("All divisor of given no by 3 method are");
            ad.alldivisor3(6);
            //Console.WriteLine("All prime no less than given no by 1 method are");
            //pn.AllPrineNumber(10);
            //Console.WriteLine("All prime no less than given no by SieveOfEratosthenes algoritm are");
            //pn.SieveOfEratosthenes(10000000);
            //Console.WriteLine();
            //Console.WriteLine("All prime no less than given no by SieveOfEratosthenes algoritm are");
            //pn.SieveOfEratosthenesIMPORTANT(10);
            //Console.WriteLine("Power of n1 to n2 is " + pw.power1(3, 9));
            //Console.WriteLine("Power of n1 to n2 is " + pw.power2(3, 9));
            //Console.WriteLine("Power of n1 to n2 is " + pw.power3(3, 9));
            //Console.WriteLine( pw.solve("sd12gh12"));
            Console.ReadKey();
        }
    }
}
