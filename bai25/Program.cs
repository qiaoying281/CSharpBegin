//nhap so nguyen duong n
Console.WriteLine("nhap so nguyen duong n: ");
int n = int.Parse(Console.ReadLine());
string tinhToan = n.ToString();
int tich = 1;
foreach(char i in tinhToan)
{
    tich *= int.Parse(i.ToString());
}
Console.WriteLine($"tich cac chu so cua {n} la: {tich}");