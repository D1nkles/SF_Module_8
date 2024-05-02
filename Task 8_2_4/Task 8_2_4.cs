DirectoryInfo folder = new DirectoryInfo(@"C:\Users\Dinkles\Desktop\testFolder");

DirectoryInfo bin = new DirectoryInfo(@"C:\$Recycle.Bin");

void MoveToBin(DirectoryInfo folder) 
{
    folder.MoveTo(@$"{bin.FullName}\testFolder");
}

MoveToBin(folder);