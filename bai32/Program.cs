//nhap n
using System.Text;

Console.WriteLine("nhap vao n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"tam giac voi {n} hang la: ");
for (int i = 1; i <= n; i++)
{
    string strOut = "";
    StringBuilder sb = new StringBuilder(strOut);
    for (int j = 1; j <= (n-i); j++)
    {
        sb.Append(" ");
    }
    for (int j = 1; j <= i; j++)
    {
        sb.Append(j);
    }
    for (int j = (i-1); j >= 1; j--)
    {
        sb.Append(j);
    }
    for (int j = 1; j <= (n - i); j++)
    {
        sb.Append(" ");
    }
    Console.WriteLine(sb);
}