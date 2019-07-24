using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using System;
using System.IO;
using System.Reflection;

namespace SportsMeet.Reports
{
    class Cover
    {

        public Cover()
        {
            ParaGraphText = "A document carrying sports meet data.";
            CoverImagePath = "./images/runner-304409_1280.png";
        }

        public void DefineCover(Document document)
        {
            Section section = document.AddSection();

            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.SpaceAfter = "3cm";

            //Image image = section.AddImage("runner-304409_1280.png");
            //image.Width = "10cm";

            paragraph = section.AddParagraph(ParaGraphText);
            paragraph.Format.Font.Size = 16;
            paragraph.Format.Font.Color = Colors.DarkRed;
            paragraph.Format.SpaceBefore = "8cm";
            paragraph.Format.SpaceAfter = "3cm";

            paragraph = section.AddParagraph("Rendering date: ");
            paragraph.AddDateField();
        }

        public String CoverImagePath { get; set; }
        public String ParaGraphText { get; set; }
    }
}
