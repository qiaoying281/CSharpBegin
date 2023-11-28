string[] strArr = { "", "", "" };
for (int i = 0; i< 3; i++)
{
    Console.WriteLine($"nhap chuoi thu {i}: ");
    strArr[i] = Console.ReadLine();
}
Console.WriteLine("sap xep tang dan: ");
for (int i = 0;i< 3;i++)
{
    for (int j = i + 1; j < 3; j++)
    {
        int soSanh = string.Compare(strArr[i], strArr[j]);
        if (soSanh > 0)
        {
            string temp = strArr[i];
            strArr[i] = strArr[j];
            strArr[j] = temp;
        }
    }
}
foreach (string str in strArr)
{
    Console.WriteLine(str);
}
Console.WriteLine();
Console.WriteLine("sap xep giam dan: ");
for (int i = 0; i < 3; i++)
{
    for (int j = i + 1; j < 3; j++)
    {
        int soSanh = string.Compare(strArr[i], strArr[j]);
        if (soSanh < 0)
        {
            string temp = strArr[i];
            strArr[i] = strArr[j];
            strArr[j] = temp;
        }
    }
}
foreach (string str in strArr)
{
    Console.WriteLine(str);
}