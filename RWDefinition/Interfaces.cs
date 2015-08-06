using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWDefinition
{
    //using FileStream for file or webrequest for http
    public interface IGenReader : IDisposable
    {
        string Protocol { get; }
        //open
        void Open(string targetUri);
        //read chunk
        int Read(byte[] buffer, int count);
        //close
        new void Dispose();
    }
}