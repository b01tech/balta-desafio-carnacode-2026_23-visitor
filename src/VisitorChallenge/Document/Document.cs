namespace VisitorChallenge.Document;

using System.Collections.Generic;
using VisitorChallenge.Visitor;

public class Document
{
    public string Title { get; }
    public List<DocumentElement> Elements { get; } = new();

    public Document(string title)
    {
        Title = title;
    }

    public void AddElement(DocumentElement element)
    {
        Elements.Add(element);
    }

    public string ExportToHtml()
    {
        var visitor = new HtmlExporter(Title);
        foreach (var e in Elements) e.Accept(visitor);
        return visitor.Result;
    }

    public string ExportToPdf()
    {
        var visitor = new PdfExporter(Title);
        foreach (var e in Elements) e.Accept(visitor);
        return visitor.Result;
    }

    public int CountTotalWords()
    {
        var visitor = new WordCounter();
        foreach (var e in Elements) e.Accept(visitor);
        return visitor.Total;
    }

    public bool ValidateAll()
    {
        var visitor = new Validator();
        foreach (var e in Elements) e.Accept(visitor);
        return visitor.IsValid;
    }

}

