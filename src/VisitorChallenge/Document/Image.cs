using VisitorChallenge.Visitor;

namespace VisitorChallenge.Document;

public class Image : DocumentElement
{
    public string Url { get; }
    public int Width { get; }
    public int Height { get; }
    public string Alt { get; } = "";

    public Image(string url, int width, int height)
    {
        Url = url;
        Width = width;
        Height = height;
    }

    public override void Render()
    {
        Console.WriteLine($"[Imagem] {Url} ({Width}x{Height})");
    }

    public override void Accept(IElementVisitor visitor)
    {
        visitor.Visit(this);
    }
}

