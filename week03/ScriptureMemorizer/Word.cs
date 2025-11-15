using System;
using System.Text;

public class Word
{
    private readonly string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetDisplayText()
    {
        if (!_hidden) return _text;
        return MaskLetters(_text);
    }

    private static string MaskLetters(string token)
    {
        var sb = new StringBuilder(token.Length);
        foreach (char c in token)
        {
            sb.Append(char.IsLetter(c) ? '_' : c);
        }
        return sb.ToString();
    }
}
