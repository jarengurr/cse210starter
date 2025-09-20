using System.Collections.Generic;
using System.IO;

public class Journal
{
    public  List<Entry> _entries = new List<Entry>();



    public void AddEntry(Entry NewEntry)
    {
        //_entries.Add(NewEntry);
        _entries.Insert(_entries.Count, NewEntry);
        
    }

    public void DisplayAll()
    {
        int i = 0;

        foreach (Entry singleEntry in _entries)
        {
            //Console.WriteLine(_entries[i]);
            i = i + 1;
            string hold;
            singleEntry.Display();

            Console.WriteLine(i); // used to count entries as displayed. will be deleted when method works
            Console.WriteLine();
            hold = _entries[0].getEntryText();
            Console.WriteLine(hold);
            hold = singleEntry.getEntryText();
            Console.WriteLine(hold);


        }
    }

    public void SaveToFile(string filepath)
    {
        
        using (StreamWriter outputfile = new StreamWriter(filepath, false))
        {
            foreach (Entry singleEntry in _entries)
            {
                Console.WriteLine(singleEntry.getEntryText());
                Console.WriteLine(_entries.Count);
                outputfile.WriteLine($"{singleEntry.getDate}*{singleEntry.getPrompt}*{singleEntry.getEntryText}");
            }
        }

        

    }

    public void LoadFromFile(string File)
    {
        Entry aEntry;//create new enty item to fill
        aEntry = new Entry();

        string filename = "Journal.txt";
        string[] Lines = System.IO.File.ReadAllLines(filename);
       
        foreach (string line in Lines)// 
        {
            if (line != "")
            {
                string[] parts = line.Split("*");
                aEntry.setDate(parts[0]);
                aEntry.setPrompt(parts[1]);
                aEntry.setEntryText(parts[2]);

                _entries.Add(aEntry);// add each entry to journal
            }
        }
    }


}