// Newbie


//Console.WriteLine("Hello World");              //1

//string name = Console.ReadLine()!;             //2
//Console.WriteLine($"Helo {name}");

//Console.Write("Введите 2 числа: ");
//int number1 = int.Parse(Console.ReadLine()!);  //3
//int number2 = int.Parse(Console.ReadLine()!);
//int result =  number1 + number2;

//Console.Write("Введите число: ");              //4
//int number0 = int.Parse(Console.ReadLine()!);
//if (number0 % 2 == 0) Console.WriteLine("Четное");
//else Console.WriteLine("Не четное");

//Console.Write("Введите 3 числа: ");             //5
//int number1 = int.Parse(Console.ReadLine()!);
//int number2 = int.Parse(Console.ReadLine()!);
//int number3 = int.Parse(Console.ReadLine()!);

//int max = 0;
//max = Math.Max(number1, Math.Max(number2,number3));
//Console.WriteLine($"Наибольшее число {max}");


// Base


//Console.Write("Введите целое число:");          //6
//int userNumber = int.Parse(Console.ReadLine()!);
//long f = 1;
//for (int i = 1; i <= userNumber; f *= i++) ;
//Console.WriteLine(f);

//int a = 1;                                      //7
//int b = 100;
//for (int i = a; i <= b; i++)
//{
//    if (i % 3 == 0 || i % 5 == 0) Console.Write(i + " ");
//}

//string input = Console.ReadLine()!;             //8
//for (int i = 1; i < input.Length; i++)
//{
//    Console.WriteLine(i);
//}

//Console.Write("Введите целое число:");         //9 
//int x = int.Parse(Console.ReadLine());
//int y = 0;
//for (int i = 2; i < x; i++)
//{
//    if (x % i == 0) y++;
//}
//if (y == 0) Console.WriteLine("Простое число");
//else Console.WriteLine("Не простое");


//Console.Write("Введите 3 числа:");           //10
//int number1 = int.Parse(Console.ReadLine()!);
//int number2 = int.Parse(Console.ReadLine()!);
//int number3 = int.Parse(Console.ReadLine()!);

//int sum = number1 + number2 + number3; 
//Console.WriteLine($"Avg={sum / 3:F2}");


//Console.Write("Введите 3 числа:");           //11
//int number1 = int.Parse(Console.ReadLine()!);
//int number2 = int.Parse(Console.ReadLine()!);
//int number3 = int.Parse(Console.ReadLine()!);

//int min = 0;
//min = Math.Min(number1, Math.Min(number2, number3));
//Console.WriteLine($"Наименьшее число {min}");

//Console.Write("Введите строку:");           //12
//string str = Console.ReadLine();
//for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);

//Console.Write("Введите строку:");            //13
//string str = Console.ReadLine();
//string rts = "";
//for (int i = str.Length - 1; i >= 0; i--) rts += str[i];
//if (str == rts) Console.WriteLine("Палиндром");
//else Console.WriteLine("Не палиндром");


//Fan


//Console.Write("Введите целое число:");       //14
//int n = int.Parse(Console.ReadLine()!);
//for (int i = 1; i <= n; i++)
//{
//    if (n % i == 0) Console.Write(i + " ");
//}
//int j = 1;
//while (j <= n)
//{
//    if (n % j == 0) Console.Write(j + " ");
//    j++;
//}


//for (int i =1; i<=100; i++)                 //15
//{
//    int x = 0;
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0) x++;
//    }
//    if (x== 0) Console.Write(i+" ");
//}

//for (int i = 1; i <= 100; i++)                 //16
//{
//        if (i % 2 == 0) Console.Write(i); 
//}

//Console.Write("Введите слово: ");              //17
//string abc = Console.ReadLine()!;
//for (int i = (int)'а'; i <= (int)'я'; i++)
//{
//    if (Char.IsLetter((char)i)) abc += (char)i;
//}
//Console.WriteLine(abc);

//string res = "";
//string str = Console.ReadLine()!;

//for (int i = 0; i < str.Length; i++)
//{
//    if (!res.Contains(str[i]) && Char.IsLetter(str[i])) res += Char.ToLower(str[i]);
//}
//char[] mas = res.ToArray();
//Array.Sort(mas);
//res = new string(mas);
//Console.WriteLine(res);
//if (abc == res) Console.WriteLine("Анграмма");
//else Console.WriteLine("Не анграмма");

//Console.Write("Введите число:");           //19
//int number1 = int.Parse(Console.ReadLine()!);

//while (true)
//{
//    if (number1 > 0)
//    {
//        number1 = int.Parse(Console.ReadLine()!);
//    }
//    else break;
//}

int[] mas = { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };