using System;
using System.Collections.Generic;
using System.Text;

namespace StructuredTextEmu.TextReader
{
	public enum FunctionType
	{
		IfThen,
		IfElse,
		Function
	}

	public class FunctionClass
	{
		public FunctionType FunctionType;
		public Dictionary<string,string> VariablesDeclared = new Dictionary<string,string>();
	}
}
