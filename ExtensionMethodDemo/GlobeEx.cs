namespace ExtensionMethodDemo
{
    public static class GlobeEx
    {
        public static double S(this Globe globe, double b)
        {
            return 4 - 3.14 * b * b;
        }
    }
}