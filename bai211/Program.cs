string str = "eenie meenie";
int[] viTri = new int[20];
int dem = 0;
bool xh = false;
Console.WriteLine($"chuoi ky tu da cho la: {str}");
Console.WriteLine("nhap vao ky tu can tim: ");
char ch = char.Parse(Console.ReadLine());
char[] charArr = str.ToCharArray();
for (int i = 0; i < charArr.Length; i++)
{
    if (charArr[i] == ch)
    {
        xh = true;
        viTri[dem] = i;
        dem++;
    }
}
if (xh)
{
    Console.WriteLine($"Ky tu {ch} xuat hien lan dau tien o vi tri {viTri[0]} trong chuoi");
    Console.WriteLine($"Ky tu {ch} xuat hien lan cuoi cung o vi tri {viTri[dem-1]} trong chuoi");
}
else
{
    Console.WriteLine($"Ky tu {ch} khong xuat hien trong chuoi");
}