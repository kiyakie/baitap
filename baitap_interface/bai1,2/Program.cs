using System.Text;

interface IShape
{
    void TinhChuVi();
    void TinhDienTich();

}

interface ICompareShape
{
    void SoSanhDienTich(HinhVuong a);

}

class HinhChuNhat : IShape
{
    int chieudai, chieurong;
    public double chuvi, dientich;
    public HinhChuNhat(int chieudai, int chieurong)
    {
        this.chieudai = chieudai;
        this.chieurong = chieurong;
    }

    public void TinhChuVi()
    {
        chuvi = 2 * (chieudai + chieurong);
    }

    public void TinhDienTich()
    {
        dientich = chieurong * chieurong;
    }
}

class HinhTron : IShape
{
    int bankinh;
    public double chuvi, dientich;
    const double pi = 3.14;
    public HinhTron(int bankinh)
    {
        this.bankinh = bankinh;
    }

    public void TinhChuVi()
    {
        chuvi = 2 * pi * bankinh;
    }
    public void TinhDienTich()
    {
        dientich = pi * Math.Pow(bankinh, 2);
    }

}

class HinhVuong : ICompareShape
{
    int canh;
    public double dientich;
    public HinhVuong(int canh)
    {
        this.canh = canh;
    }

    public void TinhDienTich()
    {
        dientich = Math.Pow(canh, 2);
    }
    public void SoSanhDienTich(HinhVuong a)
    {
        double dientich2 = 10;
        if (dientich == dientich2)
        {
            Console.WriteLine("Hai hình vuông bằng nhau");
        }

        if (dientich < dientich2)
        {
            Console.WriteLine($"Diện tích hình vuông của bạn nhỏ hơn {dientich2 - dientich} giá trị");
        }
        else
        {
            Console.WriteLine($"Diện tích hình vuông của bạn lớn hơn {dientich - dientich2} giá trị");
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = UTF32Encoding.UTF8;
        HinhChuNhat hcn = new HinhChuNhat(10,5);
        hcn.TinhDienTich();
        Console.WriteLine(hcn.dientich);

        HinhTron ht = new HinhTron(5);
        ht.TinhDienTich();
        Console.WriteLine(ht.dientich);

        HinhVuong hv = new HinhVuong(7);
        hv.TinhDienTich();
        Console.WriteLine(hv.dientich);
        hv.SoSanhDienTich(hv);
        Console.ReadLine();

    }
}
