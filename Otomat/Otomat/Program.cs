List<string> urunler = new List<string>() { "Su","Kola","Gofret" };
List<int> fiyat = new List<int>() { 10, 20, 15 };
int adminsifre = 123;
Girismenu:;
while (true)
{
    Console.Clear();
    Console.WriteLine("1 - Ürün Al");
    Console.WriteLine("2 - Admin Giriş");
    Console.WriteLine("0 - Çıkış");

    int secim = Convert.ToInt32(Console.ReadLine());
    {
        if (secim == 1)
        {
            goto Urunal;
        }
        else if (secim == 2)
        {
            goto Admingiris;
        }
        else if ( secim == 0)
        {
            return;
        }    
        else
        {
            Console.WriteLine("Geçersiz İşlem,Lütfen Tekrar Deneyiniz");
        }
    } 

}
Urunal:;
Console.Clear();
Console.WriteLine("Ürünler:");
for (int i = 0; i < urunler.Count; i++)
{
    Console.WriteLine($"{i + 1} - {urunler[i]}: {fiyat[i]}TL");
}
Console.WriteLine("Bir Ürün Seçiniz");
int urunsecim = Convert.ToInt32(Console.ReadLine())-1;

if (urunsecim >= 0 && urunsecim < urunler.Count)
{
    Console.WriteLine("Para giriniz:");
    int girilenPara = Convert.ToInt32(Console.ReadLine());

    if (girilenPara >= fiyat[urunsecim])
    {
        Console.WriteLine($"{urunler[urunsecim]} alındı, para üstü: {girilenPara - fiyat[urunsecim]} TL");
        Thread.Sleep(1000);
    }
    else
    {
        Console.WriteLine("Yetersiz bakiye, tekrar deneyin.");
        Thread.Sleep(1000);
        goto Urunal;
    }
}
else
{
    Console.WriteLine("Geçersiz Ürün,Lütfen Tekrar Deneyiniz");
    Thread.Sleep(1000);
    goto Urunal;
}
goto Girismenu;
Admingiris:;
Console.Clear();
Console.WriteLine("Lütfen Şifrenizi Giriniz");
int girilensifre = Convert.ToInt32(Console.ReadLine());
if (girilensifre == adminsifre)
{
    Console.WriteLine("Giriş Başarılı");
    Thread.Sleep(1000);
}    
else
{
    Console.WriteLine("Hatalı Şifre,Giriş Menüsüne Gönderiliyorsunuz");
    Thread.Sleep(1000);
    goto Girismenu;
}
admin:;
Console.Clear();
Console.WriteLine("1 - Ürün Ekle");
Console.WriteLine("2 - Ürün Sil");
Console.WriteLine("3 - Fiyat Güncelle");
Console.WriteLine("4 - Menüye Dön");

int adminsecim = Convert.ToInt32(Console.ReadLine());

if (adminsecim == 1)
{
    Console.WriteLine("Eklenecek Ürünün Adını Gİriniz:");
    string yeniurun = Console.ReadLine();
    Console.WriteLine("Yeni Ürünün Fiyatını Giriniz:");
    int yenifiyat=Convert.ToInt32(Console.ReadLine());

    urunler.Add(yeniurun);
    fiyat.Add(yenifiyat);

    Console.WriteLine($"{yeniurun} eklendi.");
    Console.WriteLine("Ana Menüye Dönülüyor...");
    Thread.Sleep(1000);
    goto Girismenu;
}
else if (adminsecim == 2)
{
    Console.WriteLine("Silinecek Ürün Numarasını Gİriniz:");
    int silinecekurun = Convert.ToInt32(Console.ReadLine()) - 1;

    if (silinecekurun >= 0 && silinecekurun < urunler.Count)
    {
        Console.WriteLine($"{urunler[silinecekurun]} silindi.");
        urunler.RemoveAt(silinecekurun);
        fiyat.RemoveAt(silinecekurun);
        Console.WriteLine("Ana Menüye Dönülüyor...");
        Thread.Sleep(1000);
        goto Girismenu;
    }
    else
    {
        Console.WriteLine("Geçersiz ürün numarası.");
        Thread.Sleep(1000);
        goto admin;
    }
}
else if(adminsecim == 3)
{
    Console.WriteLine("Güncellemek İstediğiniz Ürünün Numarasını Giriniz:");
    int Fiyatguncellemeno = Convert.ToInt32(Console.ReadLine()) - 1;

    if (Fiyatguncellemeno >= 0 && Fiyatguncellemeno < urunler.Count)
    {
        Console.WriteLine($"Yeni fiyatı girin (Mevcut fiyat: {fiyat[Fiyatguncellemeno]} TL):");
        int yenifiyat = Convert.ToInt32(Console.ReadLine());

        fiyat[Fiyatguncellemeno] = yenifiyat;
        Console.WriteLine($"{urunler[Fiyatguncellemeno]} ürününün yeni fiyatı: {yenifiyat} TL");
        Console.WriteLine("Ana Menüye Dönülüyor...");
        Thread.Sleep(1000);
        goto Girismenu;
    }
}
else if(adminsecim == 4)
{
    Console.WriteLine("Ana Menüye Dönülüyor");
    Thread.Sleep (1000);
    goto Girismenu;
}
else
{
    Console.WriteLine("Geçersiz Ürün Numarası,Lütfen Tekrar Deneyiniz");
    Thread.Sleep(1000);
    goto admin;
}