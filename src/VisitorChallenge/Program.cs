using VisitorChallenge.Document;

Console.WriteLine("=== Visitor Challenge ===");

var doc = new Document("Relatório Anual");
doc.AddElement(new Paragraph("Este é o relatório anual da empresa."));
doc.AddElement(new Image("grafico.png", 800, 600));
doc.AddElement(new Paragraph("Abaixo os resultados financeiros do ano:"));
doc.AddElement(new Table(3, 4));
doc.AddElement(new Paragraph("Conclusão do relatório com recomendações."));

Console.WriteLine($"Documento: {doc.Title}");
Console.WriteLine($"Elementos: {doc.Elements.Count}");

var totalWords = doc.CountTotalWords();
Console.WriteLine($"Total de palavras: {totalWords}");

var isValid = doc.ValidateAll();
Console.WriteLine($"Documento válido: {isValid}");

var html = doc.ExportToHtml();
Console.WriteLine(html.Substring(0, Math.Min(200, html.Length)) + "...");

var pdf = doc.ExportToPdf();
Console.WriteLine(pdf.Substring(0, Math.Min(150, pdf.Length)) + "...");
