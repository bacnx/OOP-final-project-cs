namespace final_project_web_sales
{
    public static class Extensions
    {
        // convert array<int> to string 
        public static string ToStringArray(this int[] arr)
        {
            string ans = "";
            foreach (var a in arr)
            {
                if (ans == "")
                {
                    ans += a.ToString();
                }
                else
                {
                    ans += ", " + a.ToString();
                }
            }

            return "[ " + ans + " ]";
        }

        // add new item to array
        public static T[] Append<T>(this T[] array, T item)
        {
            if (array == null)
            {
                return new T[] { item };
            }
            T[] result = new T[array.Length + 1];
            array.CopyTo(result, 0);
            result[array.Length] = item;
            return result;
        }
    }
}