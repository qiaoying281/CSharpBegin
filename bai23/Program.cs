//nhap vao ho ten va ngay sinh
Console.WriteLine("nhap  vao ho ten: ");
string hoTen = Console.ReadLine();
Console.WriteLine("nhap vao nam sinh: ");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("nhap vao thang sinh: ");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("nhap vao ngay sinh: ");
int day = int.Parse(Console.ReadLine());
DateTime ngaySinh = new DateTime(year,month,day);
DateTime ngayHuu = new DateTime(year+60,month,day);
Console.WriteLine($"ho ten: {hoTen}");
Console.WriteLine($"ngay nghi huu la: {ngayHuu}");