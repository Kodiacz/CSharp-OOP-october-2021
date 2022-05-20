using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractionDemo.Documents
{
    public class WordDocument : IPrintable, ISavable, IComparable<WordDocument>
    {
        public int CompareTo(WordDocument other)
        {
            return 0;
        }

        public void Print()
        {
        }

        public void PrintToPdf()
        {
        }

        public void SaveToFile(string fileName)
        {
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(WordDocument left, WordDocument right)
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(WordDocument left, WordDocument right)
        {
            return !(left == right);
        }

        public static bool operator <(WordDocument left, WordDocument right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }

        public static bool operator <=(WordDocument left, WordDocument right)
        {
            return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
        }

        public static bool operator >(WordDocument left, WordDocument right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator >=(WordDocument left, WordDocument right)
        {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
        }
    }
}
