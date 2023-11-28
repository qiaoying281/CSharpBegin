//nhap vao a 
int a;
do
{
    Console.WriteLine("nhap vao so a nho hon 1 va lon hon 100: ");
    a = int.Parse(Console.ReadLine());
}
while ((a <= 1) || (a >= 100));
Console.WriteLine($"{a}");