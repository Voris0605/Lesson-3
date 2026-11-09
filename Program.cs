//classtask1
//int n = Convert.ToInt32(Console.ReadLine());
//
//PrintFromNumberToOne(n);
//
//void PrintFromNumberToOne(int number)
//{
//for(int i = number; i > 0; i--)
//{
//     System.Console.Write(i + " ");
//   }
//}

//classtask2
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//int d = Convert.ToInt32(Console.ReadLine());

//Sum(a, b, c, d);

//void Sum(int a, int b, int c, int d)
//{
//  int sum = a + b + c + d;
//   System.Console.WriteLine(sum + " ");
//}

//classtask3
//using System.Runtime.InteropServices;

//int n = Convert.ToInt32(Console.ReadLine());

//Reverse(n);

//void Reverse(int number)
//{
    //int a = number / 100;
    //int b = number / 10 % 10;
    //int c = number % 10;

    //int rev  = (c * 100) + (b * 10) + (a * 1);

  //  System.Console.WriteLine(rev + " ");
//}

//classtask4 
//int n = Convert.ToInt32(Console.ReadLine());

//PrintStars(n);

//void PrintStars(int number)
//{
  //  System.Console.WriteLine(new string('*', number));
//}

//classtask5
//int n = Convert.ToInt32(Console.ReadLine());

//PrintSquare(n);

//void PrintSquare(int size)
//{
    //for(int i = 0; i < size; i++)
    //{
    //    PrintStars(size);
  //  }
//}
//void PrintStars(int n)
//{
//    System.Console.WriteLine(new string('*', n));
//}

//classtask6
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

PrintSquare(a, b);

void PrintSquare(int width, int height)
{
    for(int i = 0; i < height; i++)
    {
        PrintStars(width);
    }
}
void PrintStars(int n)
{
    System.Console.WriteLine(new string('*', n));
}