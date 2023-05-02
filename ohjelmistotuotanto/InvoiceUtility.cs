using iText.Layout;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Document = iTextSharp.text.Document;

namespace ohjelmistotuotanto
{
    public static class InvoiceUtility
    {
        public static string invoicesDir = null;
        public static string projectRootDir = null;

        static BaseFont f_cb = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        static BaseFont f_cn = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

        static private void writeText(PdfContentByte cb, string Text, int X, int Y, BaseFont font, int Size)
        {
            cb.SetFontAndSize(font, Size);
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Text, X, Y, 0);
        }

        static private PdfTemplate PdfFooter(PdfContentByte cb, DataRow drFoot)
        {
            // Create the template and assign height
            PdfTemplate tmpFooter = cb.CreateTemplate(580, 70);
            // Move to the bottom left corner of the template
            tmpFooter.MoveTo(1, 1);
            // Place the footer content
            tmpFooter.Stroke();
            // Begin writing the footer
            tmpFooter.BeginText();
            // Set the font and size
            tmpFooter.SetFontAndSize(f_cn, 8);
            // Write out details from the payee table
            // Bold text for ther headers
            tmpFooter.SetFontAndSize(f_cb, 8);
            // Regular text for infomation fields
            tmpFooter.SetFontAndSize(f_cn, 8);
            // End text
            tmpFooter.EndText();
            // Stamp a line above the page footer
            cb.SetLineWidth(0f);
            cb.MoveTo(30, 60);
            cb.LineTo(570, 60);
            cb.Stroke();
            // Return the footer template
            return tmpFooter;
        }

        public static void CreateInvoice(string billId)
        {
            try
            {
                // Read the XML file using the contructor, giving the file path
                Invoice invoice = new Invoice(invoicesDir + $"\\{billId}.xml");
                // Create references for each of the on-row tables to make it easier to access the values
                DataRow drHead = invoice.GetInvoiceHeader().Rows[0];
                DataRow drTotal = invoice.GetInvoiceTotal().Rows[0];
                DataRow drPayee = invoice.GetInvoicePayeeInfo().Rows[0];

                using (System.IO.FileStream fs = new FileStream(invoicesDir + "\\" + "Invoice_" + drHead["invoiceId"].ToString() + ".pdf", FileMode.Create))
                {
                    Document document = new Document(PageSize.A4, 25, 25, 30, 1);
                    PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, fs);

                    // Add meta information to the document
                    document.AddAuthor("WhoAmI");
                    document.AddCreator("Lasku");
                    document.AddKeywords("PDF");
                    document.AddSubject("pdf - lasku");
                    document.AddTitle("Varaus lasku");

                    // Open the document to enable you to write to the document
                    document.Open();

                    // Makes it possible to add text to a specific place in the document using 
                    // a X & Y placement syntax.
                    PdfContentByte cb = writer.DirectContent;
                    // Add a footer template to the document
                    cb.AddTemplate(PdfFooter(cb, drPayee), 30, 1);

                    // Add a logo to the invoice
                    iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(projectRootDir + "\\ohjelmistotuotanto\\img\\brand_logo.png");
                    png.ScaleAbsolute(200, 55);
                    png.SetAbsolutePosition(40, 750);
                    cb.AddImage(png);

                    // First we must activate writing
                    cb.BeginText();


                    // First we write out the header information

                    // Start with the invoice type header
                    writeText(cb, drHead["invoiceType"].ToString(), 350, 820, f_cb, 14);
                    // HEader details; invoice number, invoice date, due date and customer Id
                    writeText(cb, "Laskun Numero", 350, 800, f_cb, 10);
                    writeText(cb, drHead["invoiceId"].ToString(), 420, 800, f_cn, 10);
                    writeText(cb, "Laskun pvm", 350, 788, f_cb, 10);
                    writeText(cb, drHead["invoiceDate"].ToString(), 420, 788, f_cn, 10);
                    writeText(cb, "Eräpäivä", 350, 776, f_cb, 10);
                    writeText(cb, drHead["dueDate"].ToString(), 420, 776, f_cn, 10);


                    int left_margin = 40;
                    int top_margin = 720;


                    // Invoice address
                    left_margin = 350;
                    writeText(cb, "Laskun osoite", left_margin, top_margin, f_cb, 10);
                    writeText(cb, drHead["invCustomerName"].ToString(), left_margin, top_margin - 12, f_cn, 10);
                    writeText(cb, drHead["invAddress1"].ToString(), left_margin, top_margin - 24, f_cn, 10);
                    writeText(cb, drHead["invZipcode"].ToString(), left_margin, top_margin - 36, f_cn, 10);

                    // Write out invoice terms details
                    left_margin = 40;
                    top_margin = 620;
                    // Move down
                    left_margin = 40;
                    top_margin = 590;

                    cb.EndText();
                    // Separate the header from the rows with a line
                    cb.SetLineWidth(0f);
                    cb.MoveTo(40, 570);
                    cb.LineTo(560, 570);
                    cb.Stroke();
                    cb.BeginText();

                    int lastwriteposition = 100;

                    // Loop thru the rows in the rows table
                    // Start by writing out the line headers
                    top_margin = 550;
                    left_margin = 40;
                    // Line headers
                    writeText(cb, "Description", left_margin + 70, top_margin, f_cb, 10);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "päivien määrä", left_margin + 415, top_margin, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Hinta", left_margin + 495, top_margin, 0);

                    // First item line position starts here
                    top_margin = 538;

                    // Loop thru the table of items and set the linespacing to 12 points.
                    foreach (DataRow drItem in invoice.GetInvoiceRows().Rows)
                    {
                        writeText(cb, drItem["itemDescription"].ToString(), left_margin + 70, top_margin, f_cn, 10);
                        cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, drItem["dayCount"].ToString(), left_margin + 415, top_margin, 0);
                        cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, drItem["price"].ToString(), left_margin + 495, top_margin, 0);
                        writeText(cb, drItem["currency"].ToString(), left_margin + 500, top_margin, f_cn, 10);

                        // This is the line spacing, if you change the font size, you might want to change this as well.
                        top_margin -= 12;

                        // Implement a page break function, checking if the write position has reached the lastwriteposition
                        if (top_margin <= lastwriteposition)
                        {
                            // We need to end the writing before we change the page
                            cb.EndText();
                            // Make the page break
                            document.NewPage();
                            // Start the writing again
                            cb.BeginText();
                            top_margin = 780;
                        }
                    }

                    top_margin -= 80;
                    left_margin = 350;

                    // First the headers
                    writeText(cb, "Tilauksen tavat yhteensä", left_margin, top_margin, f_cb, 10);
                    writeText(cb, "ALV 24%", left_margin, top_margin - 24, f_cb, 10);
                    writeText(cb, "Laskun loppusumma", left_margin, top_margin - 48, f_cb, 10);
                    // Move right to write out the values
                    left_margin = 540;
                    // Write out the invoice currency and values in regular text
                    cb.SetFontAndSize(f_cn, 10);
                    string curr = drTotal["currency"].ToString();
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, curr, left_margin, top_margin, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, curr, left_margin, top_margin - 24, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, curr, left_margin, top_margin - 48, 0);
                    left_margin = 535;
                    cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, drTotal["invoicedAmount"].ToString(), left_margin, top_margin, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, drTotal["ALV"].ToString(), left_margin, top_margin - 24, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, drTotal["totalAmount"].ToString(), left_margin, top_margin - 48, 0);

                    // End the writing of text
                    cb.EndText();

                    // Close the document, the writer and the filestream!
                    document.Close();
                    writer.Close();
                    fs.Close();
                }
            }
            catch (Exception rror)
            {
                MessageBox.Show("jotain meni pieleen: " + rror.Message);
            }
        }

        public static void CreateXMLFile(InvoiceDataModel invoice)
        {
            // Create an XmlWriterSettings object to configure the XmlWriter
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; // Enable indentation for readability

            // Create a new XmlWriter object with the specified file name and settings
            using (XmlWriter writer = XmlWriter.Create(invoicesDir + $"\\{invoice.BillId}.xml", settings))
            {
                // Write the XML declaration
                writer.WriteStartDocument();

                // Write the root element
                writer.WriteStartElement("Invoice");

                CreateInvoiceHeader(writer, invoice.BillId, invoice.IssueDate, invoice.DueDate, invoice.CusName, invoice.CusAddress, invoice.CusPostalCode, invoice.CusCity);

                CreateInvoiceRow(writer, invoice.CottageDescription, VillageNewbies.GetDaysDifference(invoice.StartDate, invoice.EndDate), invoice.Sum);

                CreateInvoiceTotal(writer, invoice.Sum, invoice.Alv, invoice.FinalPrice);

                writer.WriteStartElement("invoice_payeeinfo");
                writer.WriteStartElement("lol");
                writer.WriteValue("who knows");
                writer.WriteEndElement();
                writer.WriteEndElement();

                // Write the end tag for the invoice element
                writer.WriteEndElement();

                // Write the end of the document
                writer.WriteEndDocument();
            }
        }

        public static void CreateInvoiceHeader(XmlWriter writer, string billId, string issueDate, string dueDate, string cName, string cAddress, string cZipcode, string cCity)
        {
            // Write invoice header
            writer.WriteStartElement("invoice_header");

            writer.WriteStartElement("invoiceId");
            writer.WriteValue(" " + billId);
            writer.WriteEndElement();

            writer.WriteStartElement("invoiceType");
            writer.WriteValue("Lasku");
            writer.WriteEndElement();

            writer.WriteStartElement("invoiceDate");
            writer.WriteValue(issueDate);
            writer.WriteEndElement();

            writer.WriteStartElement("dueDate");
            writer.WriteValue(dueDate);
            writer.WriteEndElement();

            writer.WriteStartElement("invCustomerName");
            writer.WriteValue(cName);
            writer.WriteEndElement();

            writer.WriteStartElement("invAddress1");
            writer.WriteValue(cAddress);
            writer.WriteEndElement();

            writer.WriteStartElement("invZipcode");
            writer.WriteValue(cZipcode);
            writer.WriteEndElement();

            writer.WriteStartElement("invCity");
            writer.WriteValue(cCity);
            writer.WriteEndElement();

            // End of header
            writer.WriteEndElement();
        }

        public static void CreateInvoiceRow(XmlWriter writer, string description, string dayCount, string price)
        {
            // Invoice row
            writer.WriteStartElement("invoice_rows");

            writer.WriteStartElement("rowId");
            writer.WriteValue("1");
            writer.WriteEndElement();

            writer.WriteStartElement("itemDescription");
            writer.WriteValue(description);
            writer.WriteEndElement();

            writer.WriteStartElement("dayCount");
            writer.WriteValue(dayCount);
            writer.WriteEndElement();

            writer.WriteStartElement("price");
            writer.WriteValue(price);
            writer.WriteEndElement();

            writer.WriteStartElement("currency");
            writer.WriteValue("€");
            writer.WriteEndElement();

            writer.WriteEndElement();
        }

        public static void CreateInvoiceTotal(XmlWriter writer, string total, string alvTotal, string totalSum)
        {
            // Invoice total
            writer.WriteStartElement("invoice_total");

            writer.WriteStartElement("invoicedAmount");
            writer.WriteValue(total);
            writer.WriteEndElement();

            writer.WriteStartElement("ALV");
            writer.WriteValue(alvTotal);
            writer.WriteEndElement();

            writer.WriteStartElement("totalAmount");
            writer.WriteValue(totalSum);
            writer.WriteEndElement();

            writer.WriteStartElement("currency");
            writer.WriteValue("€");
            writer.WriteEndElement();

            // End of total
            writer.WriteEndElement();
        }

        public static void GetInvoicesDir()
        {
            invoicesDir = Directory.GetCurrentDirectory();

            // Navigate up the directory tree until a .sln file is found
            while (!Directory.GetFiles(invoicesDir, "*.sln").Any())
            {
                invoicesDir = Directory.GetParent(invoicesDir).FullName;

                // If we reach the root directory and haven't found a .sln file, throw an exception
                if (invoicesDir == null)
                {
                    throw new FileNotFoundException(".sln file not found in directory tree");
                }
            }
            projectRootDir = invoicesDir;
            invoicesDir += "\\ohjelmistotuotanto\\invoices";
        }

        public static async void InvoiceProcedure(string billId)
        { // Gets details of the bill that requires an invoice
            string billQuery = $"SELECT r.start_date, r.end_date, b.id AS bill_id, b.sum, b.issue_date, b.due_date, c.city AS c_city, c.postal_code AS c_postal_code, c.address AS c_address, CONCAT(c.firstname, ' ', c.lastname) AS c_full_name, co.description FROM bill b JOIN reservation r ON b.reservation_id = r.id JOIN customer c ON r.customer_id = c.id JOIN cottage co ON r.cottage_id = co.id WHERE b.id = {billId}";

            var billsdetails = await VillageNewbies._dbManager.GetBillDetails(billQuery);
            foreach (var bill in billsdetails)
            {
                CreateXMLFile(bill);
                InvoiceUtility.CreateInvoice(bill.BillId);
            }
        }
    }
}
