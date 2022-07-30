using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StructuredTextEmu.TextReader
{
	public class TextReader
	{
		public List<string> ReadFile(string fileName)
		{
			string[] text = File.ReadAllLines(fileName);
			return text.ToList();
		}
	}
}
