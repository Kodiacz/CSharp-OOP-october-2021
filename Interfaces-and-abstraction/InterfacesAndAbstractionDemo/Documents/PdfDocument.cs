namespace InterfacesAndAbstractionDemo.Documents
{
    public class PdfDocument : Document, ISavable, IPrintable
    {
        public PdfDocument()
            : base("PDF")
        {

        }

        public override void CreateNewDocument()
        {
            //...
        }

        public override void Print()
        {
        }

        public override void PrintToPdf()
        {
        }
    }
}
