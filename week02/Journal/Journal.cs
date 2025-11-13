using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private bool _mood = true;

    // This is for 
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Displays all entries from the user entries
    public void DisplayAllEntries()
    {
        foreach (Entry ent in _entries)
        {
            ent.Display(_mood);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry ent in _entries)
            {
                outputfile.WriteLine(ent.ToFormattedString());
            }
        }

    }
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Error: File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 4)
            {
                Entry loadedEntry = new Entry(parts[0], parts[1], parts[2], parts[3]);
                _entries.Add(loadedEntry);
            }
            else
            {
                Console.WriteLine("Warning: Malformed line in file: " + line);
            }

        }
    }

}
