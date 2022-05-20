namespace InterfacesAndAbstractionDemo.Documents
{
    public class ExcelFile : IPrintable, ISavable
    {
        public void Print()
        {
        }

        public void PrintToPdf()
        {
        }

        public void SaveToFile(string fileName)
        {
        }

        public void SetCellValue(int row, char col, string value)
        {
        }
    }
}
