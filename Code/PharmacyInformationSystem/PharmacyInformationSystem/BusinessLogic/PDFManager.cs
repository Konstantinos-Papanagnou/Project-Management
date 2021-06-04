using System;
using System.Collections.Generic;
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
    public class PDFManager
    {
        /// <summary>
        /// Generate the filename for the pdf
        /// </summary>
        /// <param name="PharmacistName">The pharmacist's name to use in the filename</param>
        /// <param name="orderid">The order id to use in the filename</param>
        /// <returns>The generated location of the pdf</returns>
        private string GenerateFilename(string PharmacistName, int orderid)
        {
            string Base = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderName = "Pharmacy Information System";
            string BaseDir = System.IO.Path.Combine(Base, folderName);
            System.IO.Directory.CreateDirectory(BaseDir);
            string filename = orderid + "-" + PharmacistName + "_" + DateTime.Now.ToString("yyyy-MM-dd.HH.mm") + ".pdf";
            return System.IO.Path.Combine(BaseDir, filename);
        }

        /// <summary>
        /// Creates the invoice of the specified order
        /// </summary>
        /// <param name="Order">The order for which to create an invoice</param>
        public void CreateInvoice(Order Order)
        {
            PdfWriter writer = new PdfWriter(GenerateFilename(Order.Pharmacist.LastName, Order.OrderID));
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
                $"Διεύθυνση Παράδοσης: {Order.Pharmacist.PATown + " " + Order.Pharmacist.PAStreet + " " + Order.Pharmacist.PANumber}\n" +
                $"Ταχυδρομικός Κώδικας: {Order.Pharmacist.PAPostalCode}\n" +
                $"Τηλέφωνο Επικοινωνίας: {Order.Pharmacist.Phone}\n" +
                $"Ημερομηνία: {Order.OrderDate}\n" +
                $"Υπεύθυνος Παραγγελίας: {Order.Seller.LastName + " " + Order.Seller.FirstName}\n\n\n\n"
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
