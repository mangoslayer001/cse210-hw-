using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    private const string DELIM = "~|~";
    private readonly List<Entry> _entries = new();

    public void AddEntry(Entry e) => _entries.Add(e);

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        for (int i = 0; i < _entries.Count; i++)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Entry {i + 1}");
            Console.WriteLine(_entries[i]);
        }
        Console.WriteLine("--------------------------------------------------");
    }

    // Save as plain text using custom delimiter to avoid comma/quote issues
    public void SaveToFile(string filename)
    {
        var lines = _entries.Select(e =>
            string.Join(DELIM, Escape(e.Date), Escape(e.Prompt), Escape(e.Response)));
        File.WriteAllLines(filename, lines);
        Console.WriteLine($"Journal saved to {filename}");
    }

    // Load from plain text with the same delimiter
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        var lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (var line in lines)
        {
            var parts = line.Split(DELIM);
            if (parts.Length < 3) continue;

            _entries.Add(new Entry
            {
                Date = Unescape(parts[0]),
                Prompt = Unescape(parts[1]),
                Response = Unescape(parts[2])
            });
        }

        Console.WriteLine($"Loaded {_entries.Count} entries from {filename}");
    }

    private static string Escape(string s) => s.Replace("\r", "\\r").Replace("\n", "\\n");
    private static string Unescape(string s) => s.Replace("\\r", "\r").Replace("\\n", "\n");
}
