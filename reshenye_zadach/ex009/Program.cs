// Показать последнюю цифру трёхзначного числа

Console.WriteLine("введите трехзначное число");
double x = Convert.ToInt32(Console.ReadLine());
double y = x%10;
Console.WriteLine(y);

