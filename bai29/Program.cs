string str = "ebracadabra";
int viTri = 0;
int demVT = 0;
bool xh = false;
Console.WriteLine($"chuoi ky tu da cho la: {str}");
Console.WriteLine("nhap vao ky tu can tim: ");
char r = char.Parse(Console.ReadLine());
foreach (char c in str)
{
    if(c == r)
    {
        demVT = viTri;
        xh = true;
    }
    ++viTri;
}
if(xh )
{
    Console.WriteLine($"Ky tu {r} xuat hien lan cuoi cung o vi tri {demVT} trong chuoi");
}
else
{
    Console.WriteLine($"Ky tu {r} khong xuat hien trong chuoi");
}