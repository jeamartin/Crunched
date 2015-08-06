using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RWDefinition;

namespace Crunched
{
    public class ReadImporter
    {
        [ImportMany(typeof(IGenReader))]
        private IEnumerable<Lazy<IGenReader>> sources;

        public void DoImport()
        {
            //An aggregate catalog that combines multiple catalogs
            var catalog = new AggregateCatalog();

            //Add all the parts found in all assemblies in
            //the same directory as the executing program
            catalog.Catalogs.Add(
                new DirectoryCatalog(
                    Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly().Location
                    )
                )
            );

            //Create the CompositionContainer with the parts in the catalog.
            CompositionContainer container = new CompositionContainer(catalog);

            //Fill the imports of this object
            container.ComposeParts(this);
        }

        public int AvailableNumberOfProtocol
        {
            get { return sources != null ? sources.Count() : 0; }
        }

        public List<string> EnumerateAllComponents()
        {
            var result = new List<string>();

            foreach (Lazy<IGenReader> com in sources)
            {
                //Console.WriteLine(com.Description);
                result.Add(com.Value.Protocol);
            }

            return result;
        }
    }
}
