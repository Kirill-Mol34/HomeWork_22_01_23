/*Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int weekday; 
Console.Write("Введите номер дня (1-7): "); 
weekday = Convert.ToInt32(Console.ReadLine()); 
switch (weekday) 
    { 
     case 1: 
            Console.WriteLine("Рабочий день"); 
            break; 
     case 2: 
            Console.WriteLine("Рабочий день"); 
            break; 
     case 3: 
            Console.WriteLine("Рабочий день"); 
            break; 
     case 4: 
            Console.WriteLine("Рабочий день"); 
            break; 
     case 5: 
            Console.WriteLine("Рабочий день"); 
            break; 
     case 6: 
            Console.WriteLine("Выходной");
            break;
     case 7: 
            Console.WriteLine("Выходной");
            break;
       default: 
           Console.WriteLine("неправильный номер");  //           break; 
    } */

//        По двум заданным числам проверять является ли одно квадратом другого
/* System.Console.WriteLine("Введите первое число: ");
string writenum1=Console.ReadLine();
int num1=Convert.ToInt32(writenum1);
System.Console.WriteLine("Введите второе число: ");
string writenum2=Console.ReadLine();
int num2=Convert.ToInt32(writenum2);
string txtResult1= $"Число {num1} не является квадратом числа {num2}";
if (num1==num2*num2)
{
    txtResult1=txtResult1.Replace("не"," ");
}
string txtResult2= $"Число {num2} не является квадратом числа {num1}";
if (num2==num1*num1)
{
    txtResult2=txtResult2.Replace("не"," ");
}
System.Console.WriteLine(txtResult1);
System.Console.WriteLine(txtResult2);
System.Console.WriteLine(); */

//      Задать номер четверти, показать диапазоны для возможных координат
 /*
Console.WriteLine("Введите x от -30 до 30: ");
double x = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите y от -30 до 30: ");
double y = Convert.ToDouble(Console.ReadLine());
    if (x > 0 && y > 0 )
    Console.WriteLine("I четверть");
    else if (x > 0 && y < 0)
    Console.WriteLine("IV четверть");
    else if (x < 0 && y > 0)
    Console.WriteLine("II четверть");
    else if (x < 0 && y < 0)
    Console.WriteLine("III четверть");
    else if (x == 0 || y == 0)
    Console.WriteLine("Точка является началом координат или лежит на одной из осей x или y");  
    if (x > 30 && y > 30)
    Console.WriteLine("недопустимый диапазон координат");
    else if (x < -30 && y < -30)
    Console.WriteLine("недопустимый диапазон координат");
    else if (x < -30 && y > 30)
    Console.WriteLine("недопустимый диапазон координат");
    else if (x > 30 && y < -30)
    Console.WriteLine("недопустимый диапазон координат");
    else if (x > 0 && y < -30)
    Console.WriteLine("недопустимый диапазон координат");
    */

    
