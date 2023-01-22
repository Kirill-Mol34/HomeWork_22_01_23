//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int weekday; 
Console.Write("Введите номер дня (1-7): "); 
weekday = Convert.ToInt32(Console.ReadLine()); 
switch (weekday) 
    { 
        case [1,5]: 
            Console.WriteLine("Рабочий день"); 
            break; 
        case [6,7]: 
            Console.WriteLine("Выходной");
        default: 
            Console.WriteLine("неправильный номер"); 
            break; 
    } 