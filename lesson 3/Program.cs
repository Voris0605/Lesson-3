//classtask1
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(isDivisible(a,b));

// bool isDivisible(int number1, int number2)
// {
//     if(number1 % number2 == 0)
//     {
//        return true;
//     }
//     else
//     {
//         return false;
//     }
// }

//classtask 2
// int a = Convert.ToInt32(Console.ReadLine());

//  System.Console.WriteLine(isDivisible(a));

//  string isDivisible(int number)
//  {
//      if(number % 2 == 0)
//      {
//         return "Even";
//      }
//      else
//      {
//          return "Odd";
//      }
// // }

//classtask 3

// using System.Diagnostics.CodeAnalysis;
// using System.Runtime.InteropServices;
// using System.Security.Cryptography.X509Certificates;

// int a = Convert.ToInt32(System.Console.ReadLine());
// int d = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine(CountNumbers(a, d));

// int CountNumbers(int number1, int number2)
// {
//     int sum = 0;
//     for(int i = number1; i < number2; i++)
//     {
//         sum++;
//     }
//     return sum-1;
// }

//classtask4
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumFromOneToN(a));

// int SumFromOneToN(int n)
// {
//     int sum = 0;
//     for(int i = 1; i <= n; i++)
//     {
//         sum+=i;
//     }
//     return sum;
// }

//classtask 5
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumFromOneToN(a));

// int SumFromOneToN(int n)
//{
//int sum = 1;
//for(int i = n; i >= 1; i--)
//{
//    sum*=i;
//  }
//   return sum;
//}

//classtask 6
//  int a = Convert.ToInt32(Console.ReadLine());

//  System.Console.WriteLine(ReverseNumber(a));

//  int ReverseNumber(int n)
//  {
//      int m = n / 1000;
//      int v = n / 100 % 10;
//      int d = n / 10 % 10; 
//      int l = n % 10;

//      int rev = l * 1000 + d * 100 + v * 10 + m;
//      return rev; 
//  }

//classtask 7
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(CountDigits(a));

// int CountDigits(int number)
// {
//     int size = number.ToString().Length;
//     return size;
// }

//classtask 8
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SumEvenDigits(a));

// int SumEvenDigits(int number)
// {
//     int sum = 0;
//     for(int i = 0; i < number; i++)
//     {
//         if(i % 2 == 0)
//         {
//             sum += i;
//         }
//     }
//     return sum;
// }

//hometask 1
//int a = Convert.ToInt32(Console.ReadLine());

//for(int i = 1 ; i < a+1; i++)
//{
//  System.Console.Write(i + " ");
//}

//hometask 2
//int a = Convert.ToInt32(Console.ReadLine());

//for(int i = a ; i > 0; i--)
//{
// System.Console.Write(i + " ");
//}

//hometask 3
//using System.Diagnostics.CodeAnalysis;

//int a = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for(int i = 1 ; i < a+1; i++)
//{
//  sum+=i;
//}
//System.Console.WriteLine(sum);

//hometask 4
i