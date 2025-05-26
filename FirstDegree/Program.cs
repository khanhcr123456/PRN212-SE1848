void first_degree_solution(double a, double b)
{
    if (a == 0 && b == 0)
    {
        //0x+0=0
        Console.WriteLine("Vo so nghiem");
    }
    else if (a == 0 && b != 0)
    {
        Console.WriteLine("vo nghiem");
    }
    else
    {
        Console.WriteLine("X={0}", -b / a);
    }

}
Console.WriteLine("Phuong trinh bac 1 :ax+b=0");
Console.WriteLine("nhap a");
double a=double.Parse(Console.ReadLine());
Console.WriteLine("nhap b");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("{0}x+{1}=0", a, b);
first_degree_solution(a, b);
Console.ReadLine();
