using System;
using System.Collections.Generic;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;


    public Reference()
    {
        _book = "Proverbs";
        _chapter = 3;
        _startVerse = 5;
        _endVerse = 6;
    }

    public string GetDisplayText()
    {
        return $"{_book},{_chapter}: {_startVerse}-{_endVerse}";
    }
}