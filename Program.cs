Console.WriteLine("Банковский счет");

double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");

balance += 500;  //Начисление 
Console.WriteLine($"После пополнения на 500: {balance}");

balance -= 200;  //Покупка
Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05;  //Начисление 5%
Console.WriteLine($"После начисления 5%: {balance}");

balance /= 2;  //Деление счета пополам с партнером 
Console.WriteLine($"После деления пополам: {balance}");

