//khai bao chuoi
string str = "Hello C#, Hello .Net, Hello HVITCLAN";
Console.WriteLine($"chuoi truoc khi sua la: {str}");
string[] strArr = str.Split(" ",StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < strArr.Length; i++)
{
    if (strArr[i] == "Hello")
    {
        strArr[i] = strArr[i].Replace("Hello", "Cheers");
    }
}
string str2 = string.Join(" ", strArr);
Console.WriteLine($"chuoi sau khi sua la: {str2}");