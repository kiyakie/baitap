using Microsoft.VisualBasic;
using System.Text;
abstract class HinhHoc
{
    public abstract void Nhap();
    public abstract void Xuat();
    public abstract void ChuVi();
    public abstract void DienTich();
}

class TamGiac : HinhHoc
{
    int a, b, c;
    double chuvi, dientich, p;
    public TamGiac(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public TamGiac() { }
    public override void Nhap()
    {
        Console.WriteLine("- Nhập thông tin Tam Giác");
        Console.Write("Nhập a: "); a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b: "); b = int.Parse(Console.ReadLine());
        Console.Write("Nhập c: "); c = int.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        Console.WriteLine("Thông tin Tam Giác");
        Console.WriteLine($"a= {a}\nb= {b}\nc= {c}");
        Console.WriteLine($"Chu vi: {chuvi}");
        Console.WriteLine($"Diện tích: {dientich}");
    }

    public override void ChuVi()
    {
        p = (a + b + c) / 2;
    }

    public override void DienTich()
    {
        chuvi = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}

class HinhTron : HinhHoc
{
    double bankinh, chuvi, dientich;
    const double pi = 3.14;
    public HinhTron(double bankinh)
    {
        this.bankinh = bankinh;
    }

    public HinhTron() { }

    public override void Nhap()
    {
        Console.WriteLine("- Nhập thông tin Hình Tròn");
        Console.Write("Nhập bán kính: "); bankinh = double.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        Console.WriteLine("Thông tin Hình Tròn");
        Console.WriteLine($"r = {bankinh}");
        Console.WriteLine($"Chu vi: {chuvi}");
        Console.WriteLine($"Diện tích: {dientich}");

    }
    public override void ChuVi()
    {
        chuvi = 2 * pi * bankinh;
    }
    public override void DienTich()
    {
        dientich = pi * Math.Pow(bankinh, 2);
    }
}

class ChuNhat : HinhHoc
{
    int dai, rong;
    double chuvi, dientich;

    public ChuNhat(int dai, int rong)
    {
        this.dai = dai;
        this.rong = rong;
    }

    public ChuNhat() { }

    public override void Nhap()
    {
        Console.WriteLine("- Nhập thông tin Chữ Nhật");
        Console.Write("Nhập chiều dài: "); dai = int.Parse(Console.ReadLine());
        Console.Write("Nhập chiều rộng: "); rong = int.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        Console.WriteLine("Thông tin Chữ Nhật");
        Console.WriteLine($"Chiều dài: {dai}\nChiều rộng: {rong}");
        Console.WriteLine($"Chu vi: {chuvi}");
        Console.WriteLine($"Diện tích: {dientich}");
    }

    public override void ChuVi()
    {
        chuvi = 2 * (dai + rong);
    }

    public override void DienTich()
    {
        dientich = dai * rong;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Random R = new Random();
        int t;
        HinhHoc[] hinhhoc = new HinhHoc[4];
        for (int i = 0; i < 4; i++)
        {
            t = R.Next() % 3;
            switch (t)
            {
                case 0:
                    hinhhoc[i] = new TamGiac();
                    hinhhoc[i].Nhap();
                    hinhhoc[i].ChuVi();
                    hinhhoc[i].DienTich();
                    Console.WriteLine();
                    break;
                case 1:
                    hinhhoc[i] = new HinhTron();
                    hinhhoc[i].Nhap();
                    hinhhoc[i].ChuVi();
                    hinhhoc[i].DienTich();
                    Console.WriteLine();
                    break;
                case 2:
                    hinhhoc[i] = new ChuNhat();
                    hinhhoc[i].Nhap();
                    hinhhoc[i].ChuVi();
                    hinhhoc[i].DienTich();
                    Console.WriteLine();
                    break;
            }

        }

        for (int i = 0; i < hinhhoc.Length; i++)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"({i + 1})");
            hinhhoc[i].Xuat();
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}

