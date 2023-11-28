//nhap vao a, b
Console.WriteLine("nhap vao so a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("nhap vao so b: ");
int b = int.Parse(Console.ReadLine());
int tich = a * b;
while (b != 0)
{
    int temp = b;
    b = a % b;
    a = temp;
}
Console.WriteLine($"uoc chung lon nhat la: {a}");
Console.WriteLine($"boi chung nho nhat la: {tich / a}");