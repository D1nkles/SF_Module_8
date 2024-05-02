try
{
    DirectoryInfo root = new DirectoryInfo(@"C:\\");

    if (root.Exists)
    {
        Console.WriteLine($"Кол-во объектов в корне диска:  {root.GetDirectories().Length + root.GetFiles().Length}");
    }
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}