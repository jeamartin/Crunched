using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using RWDefinition;

namespace ExtFile
{
    [Export(typeof(IGenReader))]
    public class FileReader : IGenReader
    {
        BinaryReader reader; 
        public string Protocol
        {
            get { return "file"; }
        }
        //open
        public void Open(string targetUri) 
        {
            reader = new BinaryReader(File.Open(targetUri, FileMode.Open));
        }
        //read chunk
        public int Read(byte[] buffer, int count)
        {
            return 0 ; 
        }
        //close
        public void Dispose()
        {
            reader.Close();
            reader.Dispose();
        }
    }
    [Export(typeof(IGenWriter))]
    public class FileWriter : IGenWriter
    {
        public string Protocol
        {
            get { return "file"; }
        }
        public void Open(string targetUri)
        {

        }
        public int Write(byte[] buffer, int count)
        {
            return 0;
        }
        public void Dispose()
        {

        }
    }
}
