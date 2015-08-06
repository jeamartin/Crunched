using System;
using System.Collections.Generic;
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
        public string Protocol
        {
            get { return "file"; }
        }

        //open
        public void Open(string targetUri) 
        {

        }
        //read chunk
        public int Read(byte[] buffer, int count)
        {
            return 0 ; 
        }
        //close
        public void Dispose()
        {

        }
    }
}
