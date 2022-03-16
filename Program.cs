

Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);
Calisan calisan = new Calisan("Hakkı", "Ayman" , "Developer");
Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

System.Console.WriteLine("Toplama İşlemi Sonucu: " +Islemler.Topla(100,200));
System.Console.WriteLine("Çıkartma İşlemi Sonucu: "+Islemler.cikar(200,100));



class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi;}

    private string Isim;
    private string Soyisim;
    private string Departman;

    //Static kurucuların erişim belirteci olmaz(public -private gibi)
    static Calisan(){
        calisanSayisi = 0;
    }
    public Calisan(string isim, string soyisim, string departman)
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman=departman;
        calisanSayisi ++;

    }
}


static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1+sayi2;
    }
    public static long cikar(int sayi1,int sayi2)
    {
        return sayi1-sayi2;
    }
}