using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    
        internal abstract class DataExporter
        {
            
            public void Export()
            {
                Connect();
                FetchData();
                FormatData();
                SaveToFile();
            }

            public abstract void Connect();
            public abstract void FetchData();
            public abstract void FormatData();
            public abstract void SaveToFile();
        }

        class CsvExporter : DataExporter
        {
            public override void Connect()
            {
                Console.WriteLine("Connecting to data source for CSV...");
            }

            public override void FetchData()
            {
                Console.WriteLine("Fetching data for CSV...");
            }

            public override void FormatData()
            {
                Console.WriteLine("Formatting data as CSV...");
            }

            public override void SaveToFile()
            {
                Console.WriteLine("Saving CSV file...");
            }
        }

        class JsonExporter : DataExporter
        {
            public override void Connect()
            {
                Console.WriteLine("Connecting to data source for JSON...");
            }

            public override void FetchData()
            {
                Console.WriteLine("Fetching data for JSON...");
            }

            public override void FormatData()
            {
                Console.WriteLine("Formatting data as JSON...");
            }

            public override void SaveToFile()
            {
                Console.WriteLine("Saving JSON file...");
            }
        }

        class XmlExporter : DataExporter
        {
            public override void Connect()
            {
                Console.WriteLine("Connecting to data source for XML...");
            }

            public override void FetchData()
            {
                Console.WriteLine("Fetching data for XML...");
            }

            public override void FormatData()
            {
                Console.WriteLine("Formatting data as XML...");
            }

            public override void SaveToFile()
            {
                Console.WriteLine("Saving XML file...");
            }
        }
}
