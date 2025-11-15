using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;
    private readonly Random _rand = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = Tokenize(text).Select(t => new Word(t)).ToList();
    }

    public string GetDisplayText()
    {
        var sb = new StringBuilder();
        sb.AppendLine(_reference.GetDisplayText());
        sb.AppendLine();
        sb.Append(string.Join(" ", _words.Select(w => w.GetDisplayText())));
        return sb.ToString();
    }

    public void HideRandomWords(int count)
    {
        var visibleIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden()) visibleIndices.Add(i);
        }
        if (visibleIndices.Count == 0) return;

        int toHide = Math.Min(count, visibleIndices.Count);
        Shuffle(visibleIndices);

        for (int i = 0; i < toHide; i++)
        {
            _words[visibleIndices[i]].Hide();
        }
    }

    public bool AllHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    private static IEnumerable<string> Tokenize(string text)
    {
        // Simple space based split keeps punctuation attached
        // This is enough for the assignment and preserves commas and semicolons.
        return text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }

    private void Shuffle(List<int> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = _rand.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
}
