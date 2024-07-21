// Geri değer döndürmeyen void metot 
static void sarki()
    {
        Console.WriteLine("Bana ancak dilsiz anlattı dile olanın dile getiremediklerini");
    }

//Geri tamsayı döndüren metot
// Rastgele bir sayı üretip 2'ye bölümünden kalan 
Random rnd = new Random();
int sayi = rnd.Next(100);
Console.WriteLine(sayi);
Console.WriteLine(kalan(sayi));

    static int kalan(int sayi)
{
    return sayi % 2;
}


// Parametre alan ve geriye değer döndüren metod

Console.WriteLine(carpma(10,2));
static int carpma (int sayi1 , int sayi2)
{
    return sayi1 * sayi2;
}

// Parametre alan ve geriye değer döndürmeyen bir metod

hosgeldiniz("Sefa", "Yılmaz");
static void hosgeldiniz (string isim , string soyisim)
{
    Console.WriteLine($"Hoşgeldiniz {isim}{soyisim}");
}
   