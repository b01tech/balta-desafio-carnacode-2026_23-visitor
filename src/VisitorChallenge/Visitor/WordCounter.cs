using VisitorChallenge.Document;

namespace VisitorChallenge.Visitor;

public class WordCounter : IElementVisitor
{
    public int Total { get; private set; }

    public void Visit(Paragraph paragraph)
    {
        var words = paragraph.Text?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length ?? 0;
        Total += words;
    }

    public void Visit(Image image)
    {
    }

    public void Visit(Table table)
    {
        foreach (var row in table.Cells)
        {
            foreach (var cell in row)
            {
                var words = cell?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length ?? 0;
                Total += words;
            }
        }
    }
}

