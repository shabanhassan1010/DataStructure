namespace DataStructure
{
    public static class StringExtensions
    {
        public static string RemoveSpaces(this string value)
        {
            return value.Replace(" ","");
        }
        public static string ReverseString(this string value)
        {
            var charArr = value.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
    public static class BoolExtensions
    {
        public static bool IsBetween(this int value, int min, int max)
        {
            return value >= min && value <= max;
        }
        public static bool IsNumber(this string value)
        {
            return int.TryParse(value, out _);
        }
        public static bool IsGreaterThan(this int num1 , int num2)
        {
            return num1 > num2;
        }
        public static bool IsText(this string text)
        {
            return int.TryParse(text , out int n);
        }
        public static int CountWordCustome(this string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                string[] stringArr= value.Split(' ');
                return stringArr.Length;
            }
            else
            {
                return 0;
            }
        }
    }
}
