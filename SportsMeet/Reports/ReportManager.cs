using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SportsMeet.Data;
using SportsMeet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsMeet.Reports
{
    public class ReportManager
    {
        public void Report()
        {
            IEnumerable<Player> players = DataBase.LoadPlayers();

            foreach (var player in players)
            {
                ReportPlayer(player);
                break;
            }
        }


        public void Report(String folderPath)
        {
            ReportPath = folderPath;
            IEnumerable<Player> players = DataBase.LoadPlayers();

            foreach (var player in players)
            {
                ReportPlayer(player);
                break;
            }
        }

        private String folderPath;

        public String ReportPath
        {
            get { return folderPath; }
            set { folderPath = value; }
        }


        private void ReportPlayer(Player player)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString("Hello, World!", font, XBrushes.Black,
              new XRect(0, 0, page.Width, page.Height),
              XStringFormats.Center);

            // Save the document...
            String pdfPath = ReportPath + "\\HelloWorld.pdf";
            document.Save(pdfPath);
            // ...and start a viewer.
        }


    }
}
