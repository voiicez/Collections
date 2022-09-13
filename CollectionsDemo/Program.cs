string input;
int sayi;
int bulunmaSayisi=0;
List<int> sayilar = new List<int>();

Console.WriteLine("sayı: (ç: exit");
 input = Console.ReadLine();

while (input!="ç")
{
    if (!int.TryParse(input, out sayi))
    {
        Console.WriteLine("Adam akıllı bir sayı gir veya ç yaz");

    }
    else
    {
        sayilar.Add(sayi);
        Console.WriteLine("Sayı: ");

    }
    input = Console.ReadLine(); 
}
foreach (int s in sayilar)
{
    Console.Write(s+" ");
}
if (sayilar.Count == 0)
{
    Console.WriteLine("Sayı bulunmadı");
    return;
}
Console.WriteLine("Toplam: "+sayilar.Sum());
Console.WriteLine("Max: "+sayilar.Max());
Console.WriteLine("Min: "+sayilar.Min());
Console.WriteLine("Ortalama: "+sayilar.Average());
Console.WriteLine("Aranacak sayı: ");
input = Console.ReadLine();

if(!int.TryParse(input,out sayi))
{
    Console.WriteLine("Sayı aranmalıdır, güle güle!");
    return;
}

if (!sayilar.Contains(sayi))
{
    Console.WriteLine("Sayı bulunamadı.");
    return;
}
foreach (int s in sayilar)
{
    if (s == sayi)
    {
        bulunmaSayisi++;
        if (bulunmaSayisi > 1)
            break;
    }
}
if(bulunmaSayisi>1)
    Console.WriteLine(sayi+ " listede tekil değildir.");
else
    Console.WriteLine(sayi+" listede tekildir.");