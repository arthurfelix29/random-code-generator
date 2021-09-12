using StnXCodeGenerator.Domain.Models;
using System;
using System.Diagnostics;
using System.IO;
using static System.Console;

var before0 = GC.CollectionCount(0);
var before1 = GC.CollectionCount(1);
var before2 = GC.CollectionCount(2);

WriteLine("Tell me the number of lines do you need and press enter.");

var key = new Key { Size = 7 };
var fullFileName = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "CodeFiles", "aleatory-file.txt");
var codeFile = new CodeFile(fullFileName, int.Parse(ReadLine()), key);

var sw = Stopwatch.StartNew();
codeFile.Create();
sw.Stop();

WriteLine($"Tempo: {sw.ElapsedMilliseconds} ms");
WriteLine($"# GC - Geração 0: {GC.CollectionCount(0) - before0}");
WriteLine($"# GC - Geração 1: {GC.CollectionCount(1) - before1}");
WriteLine($"# GC - Geração 2: {GC.CollectionCount(2) - before2}");
WriteLine($"Memória utilizada: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");
