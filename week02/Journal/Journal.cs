using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    // I used streamwriter and streamreader to save and load the journal entries to a file.
    // Each entry is stored in the file as a single line with the date, prompt, and entry text separated by a pipe (|) character.
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        
        foreach (Entry entry in _entries)
        {

            Console.WriteLine();
            entry.Display();
        }
    }  
    public void SaveToFile(string file)
    {
        using (var response = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                
                response.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {

        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
    }


}
