namespace Mathematics
{
    public class CountDigit
    {
       public int countdigit(int n)
        {
            int cd = 0;
            while (n != 0)
            {
                n = n / 10;
                cd++;
            }
            return cd;
            
        }
    }

}
