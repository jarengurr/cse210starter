
using System.IO;

public class Journal()
{




    public void AddEntry(Entry NewEntry)
    {

    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string saveme)
    {
        string filepath = "journal.text";
        using (StreamWriter outputfile = new StreamWriter(filepath, true))
        {
            outputfile.WriteLine(saveme);
        }

       

    }

    public void LoadFromFile(string File)
    {

    }


}