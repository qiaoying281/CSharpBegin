//nhap vao so n
Console.WriteLine("nhap vao so nguyen duong n: ");
int n = int.Parse(Console.ReadLine());
string nString = n.ToString();
bool giamDan = true;
bool tangDan = true;
int max = int.Parse(nString.Substring(0,1));
int min = int.Parse(nString.Substring(0, 1));
foreach(char c in nString)
{
    if(int.Parse(c.ToString()) > max)
    {
        giamDan = false;
    }
    max = int.Parse(c.ToString());
}
foreach(char c in nString)
{
    if (int.Parse(c.ToString()) < min)
    {
        tangDan = false;
    }
    min = int.Parse(c.ToString());
}
if(giamDan)
{
    Console.WriteLine(giamDan);
}
if(tangDan)
{
    Console.WriteLine(!tangDan);
}