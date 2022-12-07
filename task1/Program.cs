Console.WriteLine("Imtahan qiymeti: ");
int imtahanQiymeti = Convert.ToInt32(Console.ReadLine());
if (imtahanQiymeti > 0 && imtahanQiymeti < 100)
{
    if (imtahanQiymeti > 90 && imtahanQiymeti <= 100)
    {
        Console.WriteLine("A");
    }
    else if (imtahanQiymeti > 80 && imtahanQiymeti <= 90)
    {
        Console.WriteLine("B");
    }
    else if (imtahanQiymeti > 70 && imtahanQiymeti <= 80)
    {
        Console.WriteLine("C");
    }
    else if (imtahanQiymeti > 60 && imtahanQiymeti <= 70)
    {
        Console.WriteLine("D");
    }
    else if (imtahanQiymeti > 50 && imtahanQiymeti <= 60)
    {
        Console.WriteLine("E");
    }
    else
    {
        Console.WriteLine("Kesildiniz");
    }
}
else
{
    Console.WriteLine("Imtahan qiymeti 0 ve 100 arasinda olmalidir");
}