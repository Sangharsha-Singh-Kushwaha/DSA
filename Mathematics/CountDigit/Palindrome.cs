namespace Mathematics
{
    public class Palindrome
    {
        public bool palindrome(int n)
        {
            int resverse = 0;
            int temp = n;
            while (n != 0)
            {
                resverse = resverse * 10 + n % 10;
                n = n / 10;
            }
            return (resverse == temp);
        }

    }
}
