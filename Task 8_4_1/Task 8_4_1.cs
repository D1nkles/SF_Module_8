FileInfo binaryFile = new FileInfo(@"C:\Users\Dinkles\Desktop\BinaryFile.bin");

using (BinaryWriter bw = new BinaryWriter(binaryFile.OpenWrite()))
{
    bw.Write($"Файл изменен {DateTime.Now} на компьютере {Environment.OSVersion}");
}

string str;
using (BinaryReader br = new BinaryReader(binaryFile.OpenRead())) 
{
    str = br.ReadString();
}


Console.WriteLine(str);
