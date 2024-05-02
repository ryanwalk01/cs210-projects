using System.IO;

public class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) {
        _entries.Add(newEntry);
    }

    public void DisplayAll() {
        Console.WriteLine("Journal Entries:\n");
        foreach (Entry entry in _entries) {
            entry.Display();
        }
    }

    public void SaveToFile(string file) {
        Console.WriteLine("Saving Entries...");
        using (StreamWriter outfile = new StreamWriter(file)) {
            foreach (Entry entry in _entries) {
                outfile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
        Console.WriteLine("Entries Saved.");
    }

    public void LoadFromFile(string file) {
        Console.WriteLine("Loading Entries...");
        string[] lines = System.IO.File.ReadAllLines(file);
        List<Entry> entry = new List<Entry>();

        foreach (string line in lines) {
            string[] parts = line.Split(",");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
        Console.WriteLine("Journal entries loaded successfully.");
    }
}