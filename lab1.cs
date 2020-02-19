using System;

namespace lab1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Lab1.1
			/*double x, y, c, a;
			Console.WriteLine("Enter x");
			x = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter c");
			c = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter a");
			a = Double.Parse(Console.ReadLine());
			y = Math.Pow(c*x-a, 1.0/3.0) + Math.Log(x)/2.0 * Math.Sin(Math.PI/3.0 + x);
			Console.WriteLine("y = {0} ", y);*/

			//Lab1.2
			/*double y, dx, xmax, xmin, c;
			Console.WriteLine("Enter min x");
			xmin = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter max x");
			xmax = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter dx");
			dx = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter c");
			c = Double.Parse(Console.ReadLine());
			
			for(double i = xmin; i <= xmax; i+=dx){
				y = Math.Pow(c*c*i*i + 2, 1.0/3.0) + Math.Log(i*i +1)/2*Math.PI;
				Console.WriteLine("y({0}) = {1} ",i, y);
			}
			*/
			double y, dx, xmax, xmin, k, a;
			Console.WriteLine("Enter min x");
			xmin = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter max x");
			xmax = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter dx");
			dx = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter k");
			k = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter a");
			a = Double.Parse(Console.ReadLine());

			for (double i = xmin; i <= xmax; i += dx)
			{
				y = Math.Pow(Math.Cos(a * i), 1.0 / 3.0) + k * Math.Cos(a * i) / Math.Log(a * i);
				Console.WriteLine("y({0}) = {1} ", i, y);
			}

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}