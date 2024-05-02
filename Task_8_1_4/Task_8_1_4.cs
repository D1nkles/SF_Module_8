class DiskManager 
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

    DiskManager(string name, decimal space, decimal freeSpace) 
    {
        Name = name;
        Space = space;
        FreeSpace = freeSpace;
    }
}