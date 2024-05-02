string codePATH = @"C:\Users\Dinkles\source\repos\SkillfactoryModules\SF_Module_8\Task 8_3_1\Task 8_3_1.cs";
using (StreamReader sr = File.OpenText(codePATH)) 
{
    string str;
    while ((str = sr.ReadLine()) != null) 
    {
        Console.WriteLine(str);
    }
}