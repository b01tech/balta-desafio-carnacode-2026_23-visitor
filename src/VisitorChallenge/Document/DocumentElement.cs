using VisitorChallenge.Visitor;

namespace VisitorChallenge.Document;

public abstract class DocumentElement
{
    public abstract void Render();
    public abstract void Accept(IElementVisitor visitor);
}
