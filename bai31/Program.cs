//nhap n
Console.WriteLine("nhap so n");
int n = int.Parse(Console.ReadLine());
bool[] isPrime = new bool[n + 1];
//kiem tra so ng to
for (int i = 2; i <= n; i++)
{
    isPrime[i] = true;
}
for (int i = 2; i*i <= n; i++)
{
    if (isPrime[i])
    {
        for (int j = i*i; j <= n; j += i)
        {
            isPrime[j] = false;
        }
    }
}
Console.WriteLine($"cac so nguyen to nho hon {n} la: ");
for (int i = 2; i <= n; i++)
{
    if (isPrime[i])
    {
        Console.WriteLine(i) ;
    }
}