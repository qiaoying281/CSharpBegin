using System;
using System.Security.Cryptography;
//nhap diem a(x,y)
Console.WriteLine("nhap hoanh do diem a: ");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("nhap tung do diem a: ");
double y = double.Parse(Console.ReadLine());
Console.WriteLine($"Toa do diem a la: {x},{y}");

//nhap phuong trinh duong thang d = ax + by + c = 0
Console.WriteLine("nhap duong thang ax + by + c = 0");
Console.WriteLine("he so a la: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("he so b la: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("he so c la: ");
double c = double.Parse(Console.ReadLine());
Console.WriteLine($"phuong trinh duong thang d la: {a}x + {b}y + {c} = 0");

//tinh toan
//giao diem voi truc x, y
double y1 = -c / b;
double x1 = -c / a;
//dien tich tam giac ax1y1
double ax1 = Math.Sqrt(Math.Pow(a - x1,2) + Math.Pow(b, 2));
double x1y1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
double y1a =  Math.Sqrt(Math.Pow(a,2)+ Math.Pow(b - y1, 2));
double nuaCV = (ax1 + x1y1 + y1a) / 2;
double dienTich = Math.Sqrt(nuaCV * (nuaCV - ax1) * (nuaCV - x1y1) * (nuaCV - y1a));
//khoang cach tu diem a den duong thang d
double khoangCach = dienTich * 2 / x1y1;
Console.WriteLine($"khoang cach giua diem a va duong thang d la: {khoangCach}");