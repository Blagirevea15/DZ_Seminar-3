// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void zadacha19()
{
   Console.WriteLine("Введите пятизначное число: ");
   int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
   if (number >= 100000 || number < 10000)
   {
      Console.WriteLine("Вы ввели не пятизначное число"); 
   }
   else 
   {
      if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
      {
         Console.WriteLine("Число является палиндромом"); 
      }
      else
      {
         Console.WriteLine("Число  не является палиндромом"); 
      }
   }
}


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void zadacha21()
{
   Console.WriteLine("Введите A(x): ");
   int Ax = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите A(y): ");
   int Ay = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите A(z): ");
   int Az = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите B(x): ");
   int Bx = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите B(y): ");
   int By = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите B(z): ");
   int Bz = Convert.ToInt32(Console.ReadLine());
   double lenght = Math.Sqrt (Math.Pow(Ax-Bx, 2) + Math.Pow(Ay-By, 2) + Math.Pow(Az-Bz, 2));
   Console.WriteLine($"Расстояние между A и B: {lenght}");
}




//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void zadacha23()
{
   Console.WriteLine("Введите число: ");
   int N = Convert.ToInt32(Console.ReadLine());
   int i = 1;
   while (i <= N)
   {
     Console.WriteLine(Math.Pow(i, 3));
     i+=1; 
   }
}

//zadacha19();
//zadacha21();
//zadacha23();

   
 

