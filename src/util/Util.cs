namespace util
{
    public static class Util
    {   
        static void Main() {}
        public static bool CheckPrime(long number)
        {            
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (var i = 2; i <= number/2; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;            
        }

        public static bool CheckDivider(long number, long divider)
        {
            if (number % divider == 0)
                return true;
            return false;
        }
    }
}