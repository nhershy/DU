using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DU
{
    public class FolderOrFile : IComparable<FolderOrFile>
    {
        public string Name { get; }
        public long Bytes { get; }
        public bool Dir { get; }

        public FolderOrFile(string name, long bytes, bool dir)
        {
            this.Name = name;
            this.Bytes = bytes;
            this.Dir = dir;
        }

        public int CompareTo(FolderOrFile other)
        {
            return this.Bytes.CompareTo(other.Bytes) * -1;
        }
    }
}
