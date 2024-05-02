public class Drive 
{
    private string name;
	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	private decimal space;
    public decimal Space
    {
        get { return space; }
        set { space = value; }
    }

    private decimal freeSpace;
    public decimal FreeSpace
    {
        get { return freeSpace; }
        set { freeSpace = value; }
    }

    Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

    Drive(string name, decimal space, decimal freeSpace) 
    {
        Name = name;
        Space = space;
        FreeSpace = freeSpace;
    }

    public void CreateFolder(string name) 
    {
        Folders.Add(name, new Folder());
    }
}

public class Folder
{
    public List<string> Files { get; set; } = new List<string>();
}