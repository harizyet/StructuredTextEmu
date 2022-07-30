using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommandLine;

namespace StructuredTextEmu
{
	class Program
	{
		public class Options
		{
			//[Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
			//public bool Verbose { get; set; }

			[Option('s', "script", Required = true, HelpText = "Set location of script.")]
			public string Script { get; set; }
		}

		static void Main(string[] args)
		{
			Parser.Default.ParseArguments<Options>(args)
				.WithParsed<Options>(o =>
				{
					if ( !string.IsNullOrWhiteSpace(o.Script) )
					{
						StructuredTextEmu.TextReader.TextReader textReader = new TextReader.TextReader();
						var scriptText = textReader.ReadFile(o.Script);
						foreach (var str in scriptText)
						{
							Console.WriteLine(str);
						}
					}

				});
		}
	}
}
