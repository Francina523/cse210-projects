public class Journal
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    } 
   
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);     
    }
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }

    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
        
    }
        
    
    public void LoadFromFile(string file)
    {
         _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            while (!reader.EndOfStream)
            {
                string[] entryParts = reader.ReadLine().Split(',');
                if (entryParts.Length == 3)
                {
                    Entry loadedEntry = new Entry(entryParts[0], entryParts[1], entryParts[2]);
                    _entries.Add(loadedEntry);
                }
            }
        }
    }
        
}





    

    

    