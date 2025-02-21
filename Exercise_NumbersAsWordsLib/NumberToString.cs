using System.Numerics;

namespace Packt.Shared
{
    public static class NumberToString
    {
        public static string ToWords(this int input)
        {
            return ToWords((BigInteger)input);
        }

        public static string ToWords(this long input)
        {
            return ToWords((BigInteger)input);
        }

        public static string ToWords(this BigInteger input)
        {
            return "Not Implemented Yet."; // Placeholder. All the translation logic will be implemented in this method.
        }
    }
}
