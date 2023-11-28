//nhap ngay sinh ong A
Console.WriteLine("Nhap ngay sinh ong A: ");
Console.Write("nhap theo dinh dang month/day/year: ");
string inputDay = Console.ReadLine();
DateTime ngaySinhA = DateTime.Parse(inputDay);
DateTime hienTai = DateTime.Now;
Console.WriteLine($"ngay hom nay la: {hienTai}");
int tuoi = 0;
if(ngaySinhA.Year < hienTai.Year)
{
    if(ngaySinhA.Month < hienTai.Month)
    {
        tuoi = hienTai.Year - ngaySinhA.Year;
        Console.WriteLine($"tuoi cua ong A sinh ngay {ngaySinhA} la: {tuoi}");
    }
    else
    {
        if(ngaySinhA.Month == hienTai.Month)
        {
            if (ngaySinhA.Day <= hienTai.Day && ngaySinhA.Month <= hienTai.Month && ngaySinhA.Year <= hienTai.Year)
            {
                tuoi = hienTai.Year - ngaySinhA.Year;
                Console.WriteLine($"tuoi cua ong A sinh ngay {ngaySinhA} la: {tuoi}");
            }
            else
            {
                tuoi = hienTai.Year - ngaySinhA.Year - 1;
                Console.WriteLine($"tuoi cua ong A sinh ngay {ngaySinhA} la: {tuoi}");
            }
        }
        else
        {
            tuoi = hienTai.Year - ngaySinhA.Year - 1;
            Console.WriteLine($"tuoi cua ong A sinh ngay {ngaySinhA} la: {tuoi}");
        }
    }
    Console.WriteLine($"tuoi cua ong A sinh ngay {ngaySinhA} la: {tuoi}");
}
else
{
    if (ngaySinhA.Month < hienTai.Month)
    {
        tuoi = hienTai.Year - ngaySinhA.Year;
        Console.WriteLine($"tuoi cua ong A sinh ngay {ngaySinhA} la: {tuoi}");
    }
    else
    {
        if (ngaySinhA.Month == hienTai.Month)
        {
            if (ngaySinhA.Day <= hienTai.Day && ngaySinhA.Month <= hienTai.Month && ngaySinhA.Year <= hienTai.Year)
            {
                tuoi = hienTai.Year - ngaySinhA.Year;
                Console.WriteLine($"tuoi cua ong A sinh ngay {ngaySinhA} la: {tuoi}");
            }
            else
            {
                if (ngaySinhA.Day > hienTai.Day)
                {
                    Console.WriteLine("Ong A hien tai chua sinh ra");
                }
                else
                {
                    tuoi = hienTai.Year - ngaySinhA.Year - 1;
                    Console.WriteLine($"tuoi cua ong A sinh ngay {ngaySinhA} la: {tuoi}");
                }
            }
        }
        else
        {
            Console.WriteLine("Ong A hien tai chua sinh ra");
        }
    }
}