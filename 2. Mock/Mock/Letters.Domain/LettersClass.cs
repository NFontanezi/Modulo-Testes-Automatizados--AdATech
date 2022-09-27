namespace Letters.Domain
{
    public class LettersClass
    {
        public bool IsLetter(string word)

        {
            char[] arrayword = word.ToCharArray();

            Array.Reverse(arrayword); //void

            var newString = new string (arrayword);


            if (word != newString)
            {
                return false;
            }
            return true;

            

        }
    }
}