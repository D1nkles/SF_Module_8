try
{
    DirectoryInfo root = new DirectoryInfo(@"C:\\");
    DirectoryInfo newDirectory = new DirectoryInfo(@"C:\\NewFolder\\");
    if (root.Exists)
    {
        Console.WriteLine($"Кол-во объектов в корне диска:  {root.GetDirectories().Length + root.GetFiles().Length}");
        newDirectory.Create();
        Console.WriteLine($"Кол-во объектов в корне диска:  {root.GetDirectories().Length + root.GetFiles().Length}");
        newDirectory.Delete(true);
        Console.WriteLine($"Кол-во объектов в корне диска:  {root.GetDirectories().Length + root.GetFiles().Length}");
    }
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}