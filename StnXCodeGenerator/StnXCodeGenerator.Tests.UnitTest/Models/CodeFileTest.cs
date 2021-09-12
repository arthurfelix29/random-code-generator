using StnXCodeGenerator.Domain.Models;
using System.IO;
using Xunit;

namespace StnXCodeGenerator.Tests.UnitTest.Models
{
    public class CodeFileTest
    {
        [Fact]
        public void CreateFile_Ok()
        {
            CodeFile codeFile = new(FullPathName: "teste.txt", LinesNumber: 100, Key: new Key { Size = 7 });

            codeFile.Create();

            Assert.True(File.Exists(codeFile.FullPathName));
        }
    }
}