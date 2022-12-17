// See https://aka.ms/new-console-template for more information
 double Finobacci (int n)
 {
    if (n ==1 || n==2) return 1;
    else return Finobacci(n-1)+Finobacci(n-2);
 }
for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"f({i})= {Finobacci(i)}"); //Console.WriteLine(Finobacci(i))
}