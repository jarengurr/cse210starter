using System.Collections.Generic;
using System.IO;

public class Journal
{
    public  List<Entry> _entries = new List<Entry>();



    public void AddEntry(Entry NewEntry)
    {
        _entries.Add(NewEntry);
        
    }

    public void DisplayAll()
    {
        foreach (Entry singleEntry in _entries)
        {
            Console.WriteLine($"{singleEntry.getDate} {singleEntry.getPrompt} {singleEntry.getEntryText}");
        }
    }

    public void SaveToFile()
    {
        string filepath = "journal.text";
        using (StreamWriter outputfile = new StreamWriter(filepath, false))
        {
            foreach ( Entry singleEntry in _entries)
            {
                Console.WriteLine(singleEntry.getEntryText());
                outputfile.WriteLine($"{singleEntry.getDate}*{singleEntry.getPrompt}*{singleEntry.getEntryText}");
           }
        }

        

    }

    public void LoadFromFile(string File)
    {
        Entry aEntry;//create new enty item to fill
        aEntry = new Entry();

        string filename = "Journal.cs";
        string[] Lines = System.IO.File.ReadAllLines(filename);
       
        foreach (string line in Lines)// 
        {
            string[] parts = line.Split("*");
            aEntry.setDate(parts[0]);
            aEntry.setPrompt(parts[1]);
            aEntry.setEntryText(parts[2]);

            _entries.Add(aEntry);// add each entry to journal
        }
    }


}