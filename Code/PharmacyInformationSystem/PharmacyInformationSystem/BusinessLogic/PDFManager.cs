using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace PharmacyInformationSystem.BusinessLogic
{
    /// <summary>
    /// Wrapper class to generate invoices and print them
    /// </summary>
    public class PDFManager
    {
        /// <summary>
        /// The Order for which to create invoice
        /// </summary>
        readonly Order Order;
        /// <summary>
        /// The Filename of the invoice
        /// </summary>
        readonly string Filename;
        
        /// <summary>
        /// Initializes a PDFManager Object
        /// </summary>
        /// <param name="Order">Requires the order to work with</param>
        public PDFManager(Order Order)
        {
            this.Order = Order;
            this.Filename = GenerateFilename();
        }
        /// <summary>
        /// Generate the filename for the pdf
        /// </summary>
        /// <returns>The generated location of the pdf</returns>
        private string GenerateFilename()
        {
            string Base = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderName = "Pharmacy Information System";
            string BaseDir = System.IO.Path.Combine(Base, folderName);
            System.IO.Directory.CreateDirectory(BaseDir);
            string filename = Order.OrderID + "-" + Order.Pharmacist.LastName + "_" + DateTime.Now.ToString("yyyy-MM-dd.HH.mm") + ".pdf";
            return System.IO.Path.Combine(BaseDir, filename);
        }

        /// <summary>
        /// Creates the invoice of the specified order
        /// </summary>
        public void CreateInvoice()
        {
            PdfWriter writer = new PdfWriter(this.Filename);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            PdfFont font = PdfFontFactory.CreateFont("c:/windows/fonts/arial.ttf", PdfEncodings.IDENTITY_H);
            document.SetFont(font);
            Paragraph header = new Paragraph("Τιμολόγιο")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(25);

            Paragraph GenInfo = new Paragraph(
                $"Αριθμός Παραγγελίας: {Order.OrderID}\n" +
                $"Φαρμακοποιός: {Order.Pharmacist.LastName + " " + Order.Pharmacist.FirstName}\n" +
                $"ΑΦΜ Φαρμακοποιού: {Order.Pharmacist.AFM}\n" +
                $"Τηλέφωνο Φαρμακοποιού: {Order.Pharmacist.Phone}\n" +
                $"Διεύθυνση Παράδοσης: {Order.Pharmacist.PATown + " , " + Order.Pharmacist.PAStreet + " " + Order.Pharmacist.PANumber}\n" +
                $"Ταχυδρομικός Κώδικας: {Order.Pharmacist.PAPostalCode}\n" +
                $"Ημερομηνία: {Order.OrderDate}\n" +
                $"Υπεύθυνος Παραγγελίας: {Order.Seller.LastName + " " + Order.Seller.FirstName}\n"+
                $"Τηλέφωνο Πωλητή: {Order.Seller.PhoneNumbers[0]}\n\n\n\n"
                ).SetFontSize(10);
            document.Add(header);
            document.Add(GenInfo);

            foreach (var list in Order.OrderList)
            {
                document.Add(new Paragraph($"{ new String('*', 74)}\n").SetTextAlignment(TextAlignment.CENTER));
                document.Add(MedicinePar(list));
            }
            document.Add(new Paragraph($"{ new String('*', 74)}\n").SetTextAlignment(TextAlignment.CENTER));

            document.Add(new Paragraph($"Τελικό Ποσό Παραγγελίας: {Order.TotalCost + "€"}").SetFontSize(14).SetTextAlignment(TextAlignment.RIGHT));

            document.Close();
           
        }

        /// <summary>
        /// Generates and Prints the invoice
        /// </summary>
        public void PrintInvoice()
        {
            CreateInvoice();
            Process.Start(this.Filename);
        }
        /// <summary>
        /// Dynamically creates paragraph based on the information of the specific item
        /// </summary>
        /// <param name="Med">The medicine information to display</param>
        /// <returns>The generated paragraph</returns>
        private Paragraph MedicinePar(OrderLine Med)
        {
            return new Paragraph(
                $"Προϊόν: {Med.Medicine.MedName}\n" + 
                $"Κατηγορία: {Med.Medicine.MedCategory}\n" +
                $"Εταιρία Παρασκευής: {Med.Medicine.MedManfactureComp}\n"+ 
                $"Τιμή: {Med.Medicine.MedSellingValue + "€"}\n" +
                $"Ποσότητα: {Med.ProductQuantity + " Τεμάχια"}\n" + 
                $"Τελική τιμή: {Med.TotalProductCost + "€"}\n"
                ).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER);
        }
    }
}
