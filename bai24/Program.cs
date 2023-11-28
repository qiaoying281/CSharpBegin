//nhap so can kiem tra
Console.WriteLine("nhap so a: ");
int a = int.Parse(Console.ReadLine());
//kiem tra
string kiemTra = a.ToString();
bool le = true;
foreach (char i in kiemTra)
{
    if(int.Parse(i.ToString()) % 2 == 0)
    {
        le = false;
    }
}
if(le)
{
    Console.WriteLine($"so {a} la so toan le");
}
else
{
    Console.WriteLine($"so {a} khong la so toan le");
}