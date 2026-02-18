using System.Text;
using VisitorChallenge.Document;

namespace VisitorChallenge.Visitor;

public class HtmlExporter : IElementVisitor
{
    private readonly StringBuilder _sb = new();
    private bool _closed;

    public HtmlExporter(string title)
    {
        _sb.Append($"<html><head><title>{title}</title></head><body>");
    }

    public void Visit(Paragraph paragraph)
    {
        _sb.Append($"<p style='font-family:{paragraph.FontFamily};font-size:{paragraph.FontSize}px'>{paragraph.Text}</p>");
    }

    public void Visit(Image image)
    {
        _sb.Append($"<img src='{image.Url}' width='{image.Width}' height='{image.Height}' alt='{image.Alt}' />");
    }

    public void Visit(Table table)
    {
        _sb.Append("<table>");
        foreach (var row in table.Cells)
        {
            _sb.Append("<tr>");
            foreach (var cell in row) _sb.Append($"<td>{cell}</td>");
            _sb.Append("</tr>");
        }
        _sb.Append("</table>");
    }

    public string Result
    {
        get
        {
            if (!_closed)
            {
                _sb.Append("</body></html>");
                _closed = true;
            }
            return _sb.ToString();
        }
    }
}

