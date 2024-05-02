FileInfo code = new FileInfo(@"C:\Users\Dinkles\source\repos\SkillfactoryModules\SF_Module_8\Task 8_3_1\Task 8_3_1.cs");

using (var a = code.AppendText()) 
{ 
    
    a.WriteLine($"//Время последнего заупуска: {DateTime.Now}");
}
using (StreamReader sr = File.OpenText(code.FullName))
{
    string str;
    while ((str = sr.ReadLine()) != null) 
    {
        Console.WriteLine(str);
    }
}
