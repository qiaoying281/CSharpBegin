//nhap ho va ten
using System.Text;

Console.WriteLine("nhap vao ho va ten: ");
string hoTen = Console.ReadLine();
hoTen = hoTen.Trim();
string[] strArr = hoTen.Split(" ",StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < strArr.Length; i++)
{
    strArr[i] = strArr[i].ToLower();
}
string newHoTen = String.Join("",strArr);
StringBuilder sb = new StringBuilder(newHoTen);
sb.Append("@hvitclan.com");
Console.WriteLine($"Email cua {newHoTen} la: {sb}");