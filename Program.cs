namespace first
{
    internal class Program
    {
        static string crypt(string text)
        {
            List<char> charArray = text.ToList<char>();
            string? output = "";
            for(int i=0; i<charArray.Count(); i++)
            {
                charArray[i] = (char)((int)charArray[i]+3);
                output += charArray[i];
            }
            foreach(var x in charArray)
            {
                Console.Write(x);
            }

            return output;
        }
        static string decrypt(string text)
        {
            List<char> charArray = text.ToList<char>();
            string? output = "";
            for (int i = 0; i < charArray.Count(); i++)
            {
                charArray[i] = (char)((int)charArray[i] -3);
                output += charArray[i];
            }
            foreach (var x in charArray)
            {
                Console.Write(x);
            }

            return output;
        }
        static void Main(string[] args)
        {

            decrypt(crypt("bebra"));
        }
    }
}