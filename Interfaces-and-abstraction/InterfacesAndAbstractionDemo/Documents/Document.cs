using System;

namespace InterfacesAndAbstractionDemo.Documents
{
    public abstract class Document : ISavable, IPrintable
    {
        public Document(string name)
        {
            this.Name = name;
        }

        string Name { get; }

        public abstract void Print();

        public abstract void PrintToPdf();

        public void SaveToFile(string fileName)
        {
            Console.WriteLine(fileName);
        }

        public abstract void CreateNewDocument();
    }
}
