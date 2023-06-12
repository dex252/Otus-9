using System.Reflection;

namespace SettingsReader.SettingsAggregation.Readers
{
    public class FileReader : IReader
    {
        string FileName { get; }
        public FileReader(string fileName)
        {
            FileName = fileName;    
        }

        public string ReadResource()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assambleyName = assembly.GetManifestResourceNames()
               .FirstOrDefault(e => e.EndsWith(FileName));
            
            if (assambleyName == null)
                throw new FileNotFoundException(FileName);

            using (var stream = assembly.GetManifestResourceStream(assambleyName))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
