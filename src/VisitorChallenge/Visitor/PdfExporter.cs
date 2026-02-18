using System.Text;
using VisitorChallenge.Document;

namespace VisitorChallenge.Visitor;

public class PdfExporter : IElementVisitor
{
    private readonly StringBuilder _sb = new();
    private bool _finalized;

    public PdfExporter(string title)
    {
        _sb.Append($"PDF_DOCUMENT({title})");
    }

    public void Visit(Paragraph paragraph)
    {
        _sb.Append($" PDF_TEXT({paragraph.Text}, {paragraph.FontFamily}, {paragraph.FontSize})");
    }

    public void Visit(Image image)
    {
        _sb.Append($" PDF_IMAGE({image.Url}, {image.Width}, {image.Height})");
    }

    public void Visit(Table table)
    {
        _sb.Append($" PDF_TABLE({table.Rows}, {table.Columns}, data...)");
    }

    public string Result
    {
        get
        {
            if (!_finalized)
            {
                _finalized = true;
            }
            return _sb.ToString();
        }
    }
}

