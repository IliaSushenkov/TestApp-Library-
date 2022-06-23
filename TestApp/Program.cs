using MyLib;

Console.WriteLine("Введите радиус кругa: ");
int k = Convert.ToInt32(Console.ReadLine());


FindSquare.SquareCircle(k);

FindSquare.Area();


Console.WriteLine("Введите сторону A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сторону B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сторону C: ");
int c = Convert.ToInt32(Console.ReadLine());

FindSquare.Triangle(a, b, c);
FindSquare.Area();



    

