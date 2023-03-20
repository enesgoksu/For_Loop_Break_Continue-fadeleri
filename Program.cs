class Program
{
    private static void Main(string[] args)
    {
        // Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
        Console.Write("Lütfen bir sayı giriniz: ");
        int sayac =int.Parse(Console.ReadLine());
        for (int i = 1; i <= sayac; i++)     // i'yi 0 dan başlat bir bir artır length'den küçük olana kadar.
        {
            if(i % 2 == 1)
            Console.WriteLine(i);
            // Komutlar

        }
        
            // 1 ile 1000 arasındaki tek sayıların kendi içerisindeki toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++) 
        {
            if(i % 2 == 1)
                tekToplam += i;
            else
                ciftToplam += i;

        }     
            Console.WriteLine("Tek toplam: "+ tekToplam);
            Console.WriteLine("Çift toplam: "+ ciftToplam);

            // break, continue
            for (int i = 1; i < 10; i++)
        {
            if(i == 4)
                break;
            Console.WriteLine(i);   
        }

    }
}