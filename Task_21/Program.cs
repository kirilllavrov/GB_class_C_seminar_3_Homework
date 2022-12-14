Console.WriteLine("Введите координату X точки А");
int Ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки A");
int Ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z точки A");
int Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X точки B");
int Bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки В");
int By = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z точки В");
int Bz = Convert.ToInt32(Console.ReadLine());


// d=√(xb​—xa​)2+(yb​—ya​)2+(zb​—za​)2

double d = Math.Round(Math.Sqrt(Math.Pow(Bx-Ax,2) + Math.Pow(By-Ay,2) + Math.Pow(Bz-Az,2)), 2);

Console.WriteLine($"Расстояние между точками: " +d);