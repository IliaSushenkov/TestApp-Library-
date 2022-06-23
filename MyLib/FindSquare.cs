namespace MyLib
{
    public static class FindSquare
    {
        public static double s;

        private static int radius;

        public static void SquareCircle (int r)
        {
            radius = r;

            s = Math.PI * Math.Pow(r, 2);
        }

        private static double A, B, C, p;

        public static void Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            p = (a + b + c) / 2;

            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static void Area() => Console.WriteLine($"Area of circle: {s}");
    }

}