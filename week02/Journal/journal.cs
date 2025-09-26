using System.Collections.Generic;
using System.IO;

public class Journal
{
    public  List<Entry> _entries = new List<Entry>();



    public void AddEntry(Entry NewEntry)
    {
        _entries.Add(NewEntry);
        //_entries.Insert(_entries.Count, NewEntry);
        
    }

    public void DisplayAll()
    {
        int i = 0;

        foreach (Entry singleEntry in _entries)
        {
            //Console.WriteLine(_entries[i]);
            i = i + 1;
            
            singleEntry.Display(); //display entry

            Console.WriteLine(i); // used to count entries as displayed. will be deleted when method works
           
            

        }
    }

    public void SaveToFile(string filepath)
    {
        
        using (StreamWriter outputfile = new StreamWriter(filepath, false))
        {
            foreach (Entry singleEntry in _entries)
            {
                Console.WriteLine(singleEntry.GetEntryText());
                Console.WriteLine(_entries.Count);
                outputfile.WriteLine($"{singleEntry.GetDate()}*{singleEntry.GetPrompt()}*{singleEntry.GetEntryText()}");
                //outputfile.WriteLine(singleEntry.getEntryText())
            }
        }

        

    }

    public void LoadFromFile(string fileName)
    {
        

        //string filename = "Journal.txt";
        string[] Lines = System.IO.File.ReadAllLines(fileName);
        _entries.Clear();
        foreach (string line in Lines)// 
        {
            if (line != "")
            {
                Entry aEntry;//create new enty item to fill
                aEntry = new Entry();
                string[] parts = line.Split("*");
                aEntry.SetDate(parts[0]);
                aEntry.SetPrompt(parts[1]);
                aEntry.SetEntryText(parts[2]);

                _entries.Add(aEntry);// add each entry to journal
                aEntry = null;
            }
        }
    }


}