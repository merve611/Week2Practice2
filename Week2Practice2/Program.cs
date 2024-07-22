
//Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int sayac = 0;
while (sayac <10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim");
    sayac++;
}

Console.WriteLine("---------------------------");

//1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int sayac2 = 0;
while (sayac2 < 20)
{
    Console.WriteLine(sayac2);
    sayac2++;
}

Console.WriteLine("----------------------------");

//1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int sayac3 = 0;
while (sayac3<20)
{
    if(sayac3 % 2 == 0)
    {
        Console.WriteLine(sayac3);
    }
    sayac3++;
}

Console.WriteLine("---------------------------");


// 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int sayac4 = 50;
int toplam = 0;

while (sayac4<150)
{
    toplam = toplam + sayac4;
    

    sayac4++;
}
Console.WriteLine(toplam);

Console.WriteLine("---------------------------");

// 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int sayac5 = 1;
int toplamT=0;
int toplamC=0;

while (sayac5<120)
{
    if(sayac5 % 2 == 0)
    {
        toplamC = toplamC + sayac5;

    }
    else
    {
        toplamT = toplamT + sayac5;
    }
    sayac5++;
}
Console.WriteLine("Çift sayilar toplamı : " + toplamC);

Console.WriteLine("Tek sayilar toplamı : " + toplamT);
