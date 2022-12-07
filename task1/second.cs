Console.WriteLine("eded daxil edin");
int eded = Convert.ToInt32(Console.ReadLine());
if (eded > 0)
{
    if (eded % 7 == 0 && eded % 3 == 0)
    {
        Console.WriteLine("eded 3-e ve 7-e bolunur");
    }
    else { Console.WriteLine("eded bolunmur");
            }
}
else
{
    Console.WriteLine("eded menfidir");
}