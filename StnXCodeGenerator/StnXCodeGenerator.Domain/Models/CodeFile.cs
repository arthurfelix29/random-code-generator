using System.IO;

namespace StnXCodeGenerator.Domain.Models
{
    public record CodeFile(string FullPathName, int LinesNumber, Key Key)
    {
        public void Create()
        {
            using StreamWriter outputFile = new(FullPathName);

            for (int i = 0; i < LinesNumber; i++)
            {
                outputFile.WriteLine(Key.GenerateDistinctKey());
            }
        }
    }
}