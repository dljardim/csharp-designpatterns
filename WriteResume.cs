using System;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Examples
{
    class WordDocCreator
    {
        public static void CreateDoc()
        {
            // Create a new Word document.
            string fileName = "MyDocument.docx";
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document))
            {
                // Add a new main document part.
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                // Create the document structure.
                mainPart.Document = new Document();
                Body body = new Body();
                mainPart.Document.AppendChild(body);
                Paragraph para = new Paragraph();
                Run run = new Run();
                Text text = new Text("Hello, World!");
                run.Append(text);
                para.Append(run);
                body.AppendChild(para);
            }

            Console.WriteLine("Document created successfully.");
            Console.ReadLine();
        }
    }
}
