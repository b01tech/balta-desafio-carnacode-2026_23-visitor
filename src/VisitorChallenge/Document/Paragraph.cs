using VisitorChallenge.Visitor;

namespace VisitorChallenge.Document;

public class Paragraph : DocumentElement
{
    public string Text { get; }
    public string FontFamily { get; } = "Arial";
    public int FontSize { get; } = 12;

    public Paragraph(string text)
    {
        Text = text;
    }

    public override void Render()
    {
        Console.WriteLine($"[Parágrafo] {Text}");
    }

    public override void Accept(IElementVisitor visitor)
    {
        visitor.Visit(this);
    }
}

