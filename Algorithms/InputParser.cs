namespace Algorithms
{
    public class InputParser
    {
        public static int ParseInt(string input)
        {
            int res = 0;
            int.TryParse(input, out res);
            return res;
        }
    }
}