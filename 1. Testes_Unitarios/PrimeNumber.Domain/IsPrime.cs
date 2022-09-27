namespace PrimeNumber.Domain
{
    public class IsPrime
    {
        public bool IsPrimeNumber (int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {

                if (number % 2 == 0)
                    return false;
            }
            return true;
        }
    }
}