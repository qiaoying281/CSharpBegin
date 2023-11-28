//nhap vao 1 chuoi bat ky
Console.WriteLine("Nhap vao 1 chuoi bat ky: ");
string chuoiBD = Console.ReadLine();
int demSo = 0;
int demChu = 0;
int demKytu = 0;
foreach (char charKT in chuoiBD)
{
    if(char.IsDigit(charKT))
    {
        demSo++;
    }
    if(char.IsLetter(charKT))
    {
        demChu++;
    }
    if(!char.IsLetterOrDigit(charKT))
    {
        demKytu++;
    }
}
Console.WriteLine($"so chu so la: {demSo}, so chu cai la: {demChu}, so ky tu la: {demKytu}");