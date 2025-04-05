using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

public class Scripture
{
    private Reference _reference;
    private List<string> _words;
    private string _s1;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _s1 = text;
        _words = text.Split(' ').ToList(); ;
    
    }

    public void HideRandomWords()
    {

        List<int> randomized_indices = Enumerable.Range(0, _words.Count).OrderBy(x => Random.Shared.Next()).ToList();

        int do_this_many = 3;
        while (true)
        {
            IEnumerable<string> output =
                _words
                    .Select((word, index) =>
                        randomized_indices
                            .Take(do_this_many)
                                .Contains(index)
                                ? Regex.Replace(word, "[a-zA-Z]", "_")
                                : word);
            Console.WriteLine(String.Join(" ", output));

            if (_words.Count == do_this_many)
                break;

            do_this_many += Random.Shared.Next(1, _words.Count - do_this_many);
        }
    }

    public string GetDisplayText()
    {

        var text = String.Join("", _s1.ToArray());

        Console.WriteLine(_reference.GetDisplayText());
        return text;
    }

    // public bool IsCompletelyHidden()
    // {
    //     while (true)
    //     {
    //         Console.Clear();
    //     }

    // }
}