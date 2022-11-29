using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VArchiveNet4.Objects
{
    public class Ligne
    {
        private string _rep;
        private string _fileName;
        private bool _isFile;
        private uint _size;
        private string _creationDate;
        private string _attribues;
        private string _nomArchive;

        public Ligne(string rep, string fileName, bool isFile, uint size, string creationDate, string attribues, string nomArchive)
        {
            _rep = rep;
            _fileName = fileName;
            _isFile = isFile;
            _size = size;
            _creationDate = creationDate;
            _attribues = attribues;
            _nomArchive = nomArchive;
        }

        public bool IsFile
        {
            get { return _isFile; }
        }

        public string FileName
        {
            get { return _fileName; }
        }

        public string ArchiveName
        {
            get { return _nomArchive; }
        }

        public string FileRep
        {
            get { return _rep; }
        }

        public uint Size
        {
            get { return _size;  }
        }

        public string CreationDate
        {
            get { return _creationDate; }
        }

        public string Attribues
        {
            get { return _attribues; }
        }

        public override string ToString()
        {
            return $"{FileRep}{FileName}";
        }
    }
}
