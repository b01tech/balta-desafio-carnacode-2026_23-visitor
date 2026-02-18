![CO-11](https://github.com/user-attachments/assets/f6639a45-7212-49ad-b0b9-b61c6ac94dda)

## 🥁 CarnaCode 2026 - Desafio 23 - Visitor

Oi, eu sou o Bruno e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio

No desafio **Visitor** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:

- ✅ Boas Práticas de Software
- ✅ Código Limpo
- ✅ SOLID
- ✅ Design Patterns (Padrões de Projeto)

## Problema

Um sistema de documentos tem diferentes tipos de elementos (Parágrafo, Imagem, Tabela) e precisa realizar múltiplas operações (exportar HTML, PDF, contar palavras, validar).
O código atual adiciona cada operação como método em cada classe, violando Open/Closed Principle.

# Solução

Implementei o padrão **Visitor**, onde cada operação (exportar HTML, PDF, contar palavras, validar) é um visitante separado. Isso permite adicionar novas operações sem modificar as classes dos elementos.

## Arquivos principais:

- Elementos: `DocumentElement.cs`, `Paragraph.cs`, `Image.cs`, `Table.cs`
- Visitantes: `ElementVisitor.cs`, `HtmlExporter.cs`, `PdfExporter.cs`, `WordCounter.cs`, `Validator.cs`
- Documento (orquestra visitantes): `Document.cs`

## Como executar

```bash
cd src/VisitorChallenge
dotnet build
dotnet run
```

## Como estender

- Nova operação (ex.: Markdown, LaTeX, SEO):
  - Criar uma classe visitante em src/VisitorChallenge/Visitor implementando IElementVisitor.
  - Adicionar um método público em Document que instancia e percorre os elementos com o novo visitante, retornando o resultado.
- Novo tipo de elemento:
  - Criar classe derivada de DocumentElement com Accept chamando visitor.Visit(this).
  - Adicionar o novo Visit no IElementVisitor e implementá-lo nos visitantes existentes.

## Sobre o CarnaCode 2026

O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns

Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio

[Repositório Central do Desafio](https://github.com/b01tech/desafio-carnacode-2026-design-patterns.git)
