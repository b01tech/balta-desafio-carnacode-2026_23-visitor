using VisitorChallenge.Document;

namespace VisitorChallenge.Visitor;

public interface IElementVisitor
{
    void Visit(Paragraph paragraph);
    void Visit(Image image);
    void Visit(Table table);
}
