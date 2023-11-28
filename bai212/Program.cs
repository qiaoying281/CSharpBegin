//nhap vao chuoi
using System.Text;

Console.WriteLine("nhap vao chuoi: ");
string str = Console.ReadLine();
string str2 = "";
StringBuilder sb = new StringBuilder(str2);
char[] charArr = str.ToCharArray();
char[] charArr2 = new char[charArr.Length];

for (int i = 0; i < charArr.Length; i++)
{
    charArr2[charArr.Length-i-1] = charArr[i];
}
for (int i = 0;i < charArr2.Length; i++)
{
    sb.Append(charArr2[i]);
}
Console.WriteLine(charArr2);
string s = charArr2.ToString();
Console.WriteLine(sb.ToString().ToUpper());